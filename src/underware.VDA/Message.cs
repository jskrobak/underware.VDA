using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using underware.Edi.Common;
using underware.Edi.Common.DocumentModel;
using underware.VDA.Messages;

namespace underware.VDA
{
    public class Message(Interchange interchange): IDocument, IEdiData, IParent, ITree
    {

        public Interchange Interchange { get; set; } = interchange;
        
        public List<Record> AllRecords { get; } = [];

        public XElement ToXml()
        {
            return new XElement("Message", Subrecords.Select(r => r.ToXml()));
        }
        

        public string ToVDA()
        {
            return string.Concat(AllRecords.Select(r => r.ToVDA()));
        }

        public static Message Parse(List<string> lines, Interchange interchange)
        {
            var messageType = interchange.Header.MessageType;

            var msg = (Message)Activator.CreateInstance(messageType, new object[] { interchange});
            
            foreach (var rec in from line in lines
                     where line.Length > 3
                     select Record.Parse(line))
            {
                msg.AllRecords.Add(rec);
            }
            
            //create tree structure
            for (var i = 0; i < msg.AllRecords.Count; i++)
            {
                var record = msg.AllRecords[i];
                var parentType = record.GetType().GetCustomAttribute<ParentAttribute>()?.Type;

                var parent = parentType == null || parentType.BaseType == typeof(Message)
                    ? msg
                    : msg.AllRecords.Take(i).OfType<IParent>().LastOrDefault(p => p.Is(parentType));
                
                parent?.Subrecords.Add(record);    
            }
            
            //FindChildren(msg,  msg.AllRecords, 0);
            
            return msg;
        }
        
        public virtual BaseDocument GetDocument()
        {
            throw new NotImplementedException();
        }

        public virtual void FromDocument(BaseDocument doc)
        {
            throw new NotImplementedException();
        }

        public IList<Record> Subrecords { get; set; } = new List<Record>();

        public TreeNode BuildTree()
        {
            var root = new TreeNode{Name = "Message"};
            foreach (var rec in AllRecords)
            {
                root.Children.Add(rec.BuildTree());
            }

            return root;
        }
    }
}
