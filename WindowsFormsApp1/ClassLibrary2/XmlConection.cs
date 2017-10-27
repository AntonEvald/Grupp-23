using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Xml.XPath;

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


        public static void createXml(string a)
        {
            string b = a;
            try
            {
                if (File.Exists("Played.xml") == false)
                {
                    XmlWriterSettings settings = new XmlWriterSettings();
                    settings.Indent = true;
                    settings.IndentChars = ("    ");

                    using (XmlWriter writer = XmlWriter.Create("Played.xml", settings))
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

        public void writeToXml(string title, string url, string cat, string interval, string nextupdate, string isPlayed)
        {
            try
            {
                string lastUpdate = DateTime.Now.ToString(); 
                XDocument xdoc = XDocument.Load("xml.xml");
                XElement feeds = xdoc.Element("Feeds");
                feeds.Add(new XElement("Feed",
                    new XAttribute("id", title),
                    new XElement("Title", title),
                    new XElement("URL", url),
                    new XElement("Category", cat),
                    new XElement("Interval", interval),
                    new XElement("NextUpdate", nextupdate),
                    new XElement("LastUpdate",lastUpdate ),
                    new XElement("Played", isPlayed)));
                xdoc.Save("xml.xml");
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void writeToXml(string title)
        {
            try
            {
                XDocument xdoc = XDocument.Load("Played.xml");
                XElement feeds = xdoc.Element("Feeds");
                feeds.Add(new XElement("Podcasts",
                    new XAttribute("id", title),
                    new XElement("Title", title),
                    new XElement("Played", "No")));
                xdoc.Save("Played.xml");
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static void setPlayedYes(string title)
        {

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("Played.xml");
            XmlNode node = xmlDoc.SelectSingleNode("/Feeds/Podcasts[@id='" + title + "']");
            XmlNode a = node.SelectSingleNode("Played");
            a.InnerText = "Yes";
            xmlDoc.Save("played.xml");

        }


            public static void removeXmlFile(string title)
        {
            File.Delete(@"..\XmlFeeds\" + title + ".xml");
        }
    }
}
