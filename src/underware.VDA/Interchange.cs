using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using underware.Edi.Common;
using underware.Edi.Common.DocumentModel;

namespace underware.VDA
{
    public class Interchange : IEdiInterchange, IXmlExportable

    {
        public Interchange()
        {
            Messages = [];
        }
        
        public Interchange(IInterchangeHeaderRecord header, IInterchangeTrailerRecord trailer)
        {
            Header = header;
            Trailer = trailer;
            Messages = [];
        }
        
        public void RecalculateTrailer()
        {
            Trailer?.Recalculate(this);
        }
        
        public List<Record> GetAllRecords()
        {
            var allRecords = Messages.SelectMany(s => s.AllRecords).ToList();
            allRecords.Insert(0, Header as Record);
            allRecords.Add(Trailer as Record);

            return allRecords;
        }
        
        public IInterchangeHeaderRecord Header { get; set; }
        public IInterchangeTrailerRecord Trailer { get; set; }
        
        public List<Message> Messages { get; set; }
        public DateTime? Created { get; set; }
        public IEnumerable<IDocument> Documents => Messages;
        

        public string ToVDA(bool wrapLines = false)
        {
            RecalculateTrailer();
            
            var records = new List<Record> { Header as Record };

            foreach(var msg in Messages)
                records.AddRange(msg.AllRecords);
            
            records.Add(Trailer as Record);

            return wrapLines
                ? string.Join(Environment.NewLine, records.Select(r => r.ToVDA()))
                : string.Concat(records.Select(r => r.ToVDA()));
        }

        public static Interchange FromFile(string filePath)
        {
            return Interchange.Parse(File.ReadAllText(filePath, Encoding.ASCII));
        }

        public static Interchange FromFile(string filePath, Encoding enc)
        {
            return Interchange.Parse(File.ReadAllText(filePath, enc));
        }

        

        public static Interchange Parse(string text)
        {
            var content = text.Replace("\r", "").Replace("\n", "");
            
            var lines = new List<string>();

            var lineLen = 128;
            var pos = 0;
            while (pos < content.Length)
            {
                lines.Add(content.Substring(pos, lineLen));
                pos += lineLen;
            }

            var itr = new Interchange()
            {
                Header = Record.Parse(lines[0]) as IInterchangeHeaderRecord,
                Trailer = Record.Parse(lines.Last()) as IInterchangeTrailerRecord,
            };

            //itr.Created = itr.Header.TransmissionDate;
            
            lines.RemoveAt(0);
            lines.RemoveAt(lines.Count - 1);

            var firstMessageRecType = lines[0].Substring(0, 3);

            List<string> lineBuffer = null;

            foreach (var line in lines)
            {
                if (line.StartsWith(firstMessageRecType))
                {
                    if (lineBuffer != null)
                        itr.Messages.Add(Message.Parse(lineBuffer, itr));

                    lineBuffer = [];
                }

                lineBuffer.Add(line);
            }

            if (lineBuffer != null)
                itr.Messages.Add(Message.Parse(lineBuffer, itr));

            return itr;
        }

        public string Sender
        {
            get => Header.Sender;
            set => Header.Sender = value;
        }

        public string Receiver 
        {
            get => Header.Receiver;
            set => Header.Receiver = value;
        }
        public string Format => $"VDA.{Header.MessageName}";

        public string RefNo => Header.RefNumber;


        public XDocument ToXml(Encoding outEnc)
        {
            var nodes = new List<XElement> { ((Record)Header).ToXml() };
            nodes.AddRange(Messages.Select(m => m.ToXml()));
            nodes.Add(((Record)Trailer).ToXml());
            
            var xDoc = new XDocument(new XElement("Interchange", nodes));

            using var ms = new MemoryStream();

            // Create an XML writer with UTF-8 encoding
            var settings = new XmlWriterSettings
            {
                Encoding = outEnc, // false for no BOM
                Indent = true // optional: for pretty formatting
            };

            using var xmlWriter = XmlWriter.Create(ms, settings);

            // Write the XML document to the memory stream with UTF-8 encoding
            xDoc.WriteTo(xmlWriter);


            // Reset the memory stream position to the beginning
            ms.Position = 0;

            // Load the XML data from the memory stream as UTF-8 encoded
            return XDocument.Load(ms, LoadOptions.PreserveWhitespace);
            
        }
         
    }
}
