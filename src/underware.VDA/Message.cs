using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using underware.Edi.Common;
using underware.Edi.Common.DocumentModel;
using underware.VDA.Messages;

namespace underware.VDA
{
    public class Message: IDocument
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
            var msg = new Message();

            var typeName = $"underwarex.VDA.Messages.M{lines[0].Substring(0, 3)}";
            var messageType = Type.GetType(typeName);

            if(messageType != null)
            {
                msg = (Message)Activator.CreateInstance(messageType);
            }


            foreach (var rec in from line in lines
                     where line.Length > 3
                     let name = line.Substring(0, 3).TrimEnd()
                     let version = line.Substring(3, 2).TrimEnd()
                     let t = GetRecordType(name, version)
                     select (Record)Activator.CreateInstance(t, line))
            {
                msg.AllRecords.Add(rec);
            }

            return msg;
        }

        private static Type GetRecordType(string name, string version)
        {
            var t = Type.GetType($"underware.VDA.Records.V{version}.R{name}");

            return t ?? typeof(Record);
        }

        public virtual BaseDocument GetDocument()
        {
            throw new NotImplementedException();
        }

        public virtual void FromDocument(BaseDocument doc)
        {
            throw new NotImplementedException();
        }
    }
}
