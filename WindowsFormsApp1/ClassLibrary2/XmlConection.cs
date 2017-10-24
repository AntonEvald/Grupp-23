using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ClassLibrary2
{
    public class XmlConection
    {
        public void writeToXml(string title, string url, string cat, string interval)
        {
            if (File.Exists("xml.xml") == false)
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.IndentChars = ("    ");

                using (XmlWriter writer = XmlWriter.Create("xml.xml", settings))
                {
                    writer.WriteStartElement("Feeds");
                    writer.WriteStartElement("Feed");
                    writer.WriteElementString("Title", title);
                    writer.WriteElementString("URL", url);
                    writer.WriteElementString("Category", cat);
                    writer.WriteElementString("Interval", interval);
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Flush();
                    writer.Close();
                }
            }
            else
            {
                XDocument xdoc = XDocument.Load("xml.xml");
                XElement feeds = xdoc.Element("Feeds");
                feeds.Add(new XElement("Feed",
                    new XElement("Title", title),
                    new XElement("URL", url),
                    new XElement("Category", cat),
                    new XElement("Interval", interval)));
                xdoc.Save("xml.xml");
            }
        }
    }
}
