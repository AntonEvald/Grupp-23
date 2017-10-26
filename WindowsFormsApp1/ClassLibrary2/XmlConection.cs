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

        public static void createXml()
        {
            try
            {
                if (File.Exists("xml.xml") == false)
                {
                    XmlWriterSettings settings = new XmlWriterSettings();
                    settings.Indent = true;
                    settings.IndentChars = ("    ");

                    using (XmlWriter writer = XmlWriter.Create("xml.xml", settings))
                    {
                        writer.WriteStartDocument();
                        writer.WriteStartElement("Feeds");
                        writer.WriteEndElement();
                        writer.WriteEndDocument();
                        writer.Flush();
                        writer.Close();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void writeToXml(string title, string url, string cat, string interval)
        {
            try
            {
                XDocument xdoc = XDocument.Load("xml.xml");
                XElement feeds = xdoc.Element("Feeds");
                feeds.Add(new XElement("Feed",
                    new XAttribute("id", title),
                    new XElement("Title", title),
                    new XElement("URL", url),
                    new XElement("Category", cat),
                    new XElement("Interval", interval)));
                xdoc.Save("xml.xml");
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static void removeXmlFile(string title)
        {
            File.Delete(@"..\XmlFeeds\" + title + ".xml");
        }

            

    }
}
