using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace underware.VDA
{
    public class Record
    {
        [RecordInfo(-2, 3, Align.LEFT)]
        public string Name { get; set; }

        [RecordInfo(-1, 2, Align.LEFT)]
        public string Version { get; set; }

        public Record()
        {
        }

        public Record(string line)
        {
            Parse(line);
        }

        private List<RecordInfo> GetStructure()
        {
            Type t = GetType();

            List<RecordInfo> items = new List<RecordInfo>();

            foreach (PropertyInfo property in t.GetProperties())
            {
                var info = property.GetCustomAttribute<RecordInfo>();


                if (info != null)
                {
                    info.Name = property.Name;
                    items.Add(info);
                }
            }

            return items.OrderBy(i => i.Ordinal).ToList();
        }

        private void Parse(string line)
        {
            List<RecordInfo> structure = GetStructure();

            //if (line.Length < structure.Sum(i => i.Length))
            //    throw new Exception("Line is too short");

            int curPos = 0;
            foreach (RecordInfo info in structure)
            {
                PropertyInfo prop = this.GetType().GetProperty(info.Name);
                int len = info.Length;

                string strVal = "";

                if (line.Length > curPos + len)
                    strVal = line.Substring(curPos, len).TrimEnd().TrimStart();
                else if (line.Length > curPos)
                    strVal = line.Substring(curPos).TrimEnd().TrimStart();

                prop.SetValue(this, strVal);

                curPos += len;
            }
        }

        public string ToVDA()
        {
            var structure = GetStructure();

            var s = new StringBuilder();

            foreach (var info in structure)
            {
                var prop = this.GetType().GetProperty(info.Name); 
                var len = info.Length;
                var strValue = $"{prop.GetValue(this)}";


                if (strValue.Length > len)
                {
                    // throw new ArgumentOutOfRangeException("Value is too long");
                    strValue = strValue.Substring(0, len);
                }

                if (info.Align == Align.LEFT)
                    s.Append(strValue.PadRight(len));
                else
                    s.Append(strValue.PadRight(len));
            }

            return s.ToString();
        }

        public XElement ToXml()
        {
            List<RecordInfo> structure = GetStructure();

            List<XElement> items = new List<XElement>();

            foreach (RecordInfo info in structure)
            {
                PropertyInfo prop = this.GetType().GetProperty(info.Name);
                string strValue = (string)prop.GetValue(this);

                items.Add(new XElement($"{prop.Name}", strValue));
            }


            return new XElement($"R{Name}", items);
        }
    }
}
