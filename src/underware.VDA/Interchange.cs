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
        public List<Message> Messages { get; set; }
        public DateTime Created { get; }
        public IEnumerable<IDocument> Documents => Messages;
        public Interchange()
        {
            Messages = new List<Message>();
        }

        public string ToVDA()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(string.Concat(Messages.Select(m => m.ToVDA())));

            return sb.ToString();
        }

        public static Interchange FromFile(string filePath)
        {
            return Interchange.Parse(File.ReadAllText(filePath, ASCIIEncoding.ASCII));
        }

        public static Interchange FromFile(string filePath, Encoding enc)
        {
            return Interchange.Parse(File.ReadAllText(filePath, enc));
        }

        public static Interchange Parse(string content)
        {
            List<string> lines = new List<string>();

            int lineLen = 128;
            int pos = 0;
            while (pos < content.Length)
            {
                lines.Add(content.Substring(pos, lineLen));
                pos += lineLen;
            }

            Interchange itr = new Interchange();

            string firstRecType = lines[0].Substring(0, 3);

            List<string> lineBuffer = null;


            foreach (string line in lines)
            {
                if (line.StartsWith(firstRecType))
                {
                    if (lineBuffer != null)
                        itr.Messages.Add(Message.Parse(lineBuffer));

                    lineBuffer = new List<string>();
                }

                lineBuffer.Add(line);
            }

            if (lineBuffer != null)
                itr.Messages.Add(Message.Parse(lineBuffer));

            return itr;
        }

        public string Sender
        {
            get { return Messages.First().Sender; }
        }
        
        public string Receiver
        {
            get { return Messages.First().Receiver; }
        }

        public string Format
        {
            get { return $"VDA.{Messages.First().MessageType}"; }
        }

        public string RefNo => string.Empty;


        public XDocument ToXml(Encoding outEnc)
        {
            var xDoc = new XDocument(new XElement("Interchange", Messages.Select(m => m.ToXml())));

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
