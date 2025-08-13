using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using underware.Edi.Common;

namespace underware.VDA
{
    public class Record: IRecord, IParent, ITree
    {
        [Field(-2, 3, Align.LEFT)]
        public string Name { get; set; }

        [Field(-1, 2, Align.LEFT)]
        public string Version { get; set; }

        public Record()
        {
        }

        public Record(string line)
        {
            InternalParse(line);
        }
        
        public IList<Record> Subrecords { get; set; } = new List<Record>(); 

        private List<FieldAttribute> GetStructure()
        {
            var t = GetType();

            var items = new List<FieldAttribute>();

            foreach (var property in t.GetProperties())
            {
                var info = property.GetCustomAttribute<FieldAttribute>();


                if (info != null)
                {
                    info.Name = property.Name;
                    items.Add(info);
                }
            }

            return items.OrderBy(i => i.Ordinal).ToList();
        }

        public static Record Parse(string line)
        {
            if (line.Length < 5)
                throw new Exception("Line is too short");

            var name = line.Substring(0, 3).TrimEnd();
            var version = line.Substring(3, 2).TrimEnd();
                
            var recordType = Type.GetType($"underware.VDA.Records.V{version}.R{name}") ?? typeof(Record);
            
            return (Record)Activator.CreateInstance(recordType, line);
        }

        private void InternalParse(string line)
        {
            var structure = GetStructure();

            //if (line.Length < structure.Sum(i => i.Length))
            //    throw new Exception("Line is too short");

            var curPos = 0;
            foreach (var info in structure)
            {
                var prop = this.GetType().GetProperty(info.Name);
                var len = info.Length;

                var strVal = "";

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
                    strValue = info.Align == Align.LEFT ? strValue[..len] : strValue[^len..];
                
                s.Append(info.Align == Align.LEFT ? strValue.PadRight(len, info.PadChar) : strValue.PadLeft(len, info.PadChar));
            }

            return s.ToString();
        }

        public XElement ToXml()
        {
            var structure = GetStructure();

            var items = new List<XElement>();

            foreach (var info in structure)
            {
                var prop = this.GetType().GetProperty(info.Name);
                var strValue = (string)prop.GetValue(this);

                items.Add(new XElement($"{prop.Name}", strValue));
            }


            return new XElement($"R{Name}", items, Subrecords.Select(r => r.ToXml()));
        }

        public TreeNode BuildTree()
        {
            var node = TreeNode.Build(Name, this);
            
            foreach (var sub in Subrecords)
            {
            //    node.Children.Add(sub.BuildTree());
            }
            
            return node;
        }
    }
}
