using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using underware.VDA.Messages;

namespace underware.VDA
{
    public class Message
    {
        private List<Record> _allRecords;

        public Message()
        {
            _allRecords = new List<Record>();
        }

        public virtual string Sender { get; }

        public virtual string Receiver { get; }

        public virtual string MessageType => "000";

        public List<Record> AllRecords { get { return _allRecords; } }

        public XElement ToXml()
        {
            return new XElement("Message", AllRecords.Select(r => r.ToXml()));
        }
        

        public string ToVDA()
        {
            return string.Concat(AllRecords.Select(r => r.ToVDA()));
        }

        public static Message Parse(List<string> lines)
        {
            Message msg = new Message();

            string typeName = $"underwarex.VDA.Messages.M{lines[0].Substring(0, 3)}";
            var messageType = Type.GetType(typeName);

            if(messageType != null)
            {
                msg = (Message)Activator.CreateInstance(messageType);
            }


            for (int i = 0; i < lines.Count; i++)
            {
                string line = lines[i];

                if (line.Length > 3)
                {
                    string name = line.Substring(0, 3).TrimEnd();
                    string version = line.Substring(3, 2).TrimEnd();
                    Type t = GetRecordType(name, version);
                    Record rec = (Record)Activator.CreateInstance(t, line);
                    msg.AllRecords.Add(rec);
                }
            }

            return msg;
        }

        private static Type GetRecordType(string name, string version)
        {
            Type t = Type.GetType(string.Format("underware.VDA.Records.V{0}.R{1}", version, name));

            if (t != null)
                return t;
            else
                return typeof(Record);
        }
    }
}
