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
        public static DateTime aDay = DateTime.Now.AddDays(1);
        public static DateTime aWeek = DateTime.Now.AddDays(7);
        public static DateTime aMonth = DateTime.Now.AddMonths(1);
        public static DateTime now = DateTime.Now;

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
                    new XElement("LastUpdate", lastUpdate),
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
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("Played.xml");
            XmlNode node = xdoc.SelectSingleNode("/Feeds/Podcasts[@id='" + title + "']");
            XmlNode playedNode = node.SelectSingleNode("Played");
            playedNode.InnerText = "Yes";
            xdoc.Save("Played.xml");

        }
        public static string getSingleNextUpdate(string title)
        {
            XmlDocument xdoc = new XmlDocument();
            XmlNode node = xdoc.SelectSingleNode("/Feeds/Feed[@id='" + title + "']");
            XmlNode NextUpdateNode = node.SelectSingleNode("NextUpdate");
            return NextUpdateNode.ToString();
        }
        public static string getIntString(string title)
        {
            XmlDocument xdoc = new XmlDocument();
            XmlNode node = xdoc.SelectSingleNode("/Feeds/Feed[@id='" + title + "']");
            XmlNode IntervalNode = node.SelectSingleNode("Interval");
            return IntervalNode.ToString();
        }
        public static void setNextupdate(string title)
        {
           string datitle=  getSingleNextUpdate(title);
           string interval = getIntString(title);
            if (interval == "Every day")
            {
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load("xml.xml");
                XmlNode node = xdoc.SelectSingleNode("/Feeds/Feed[@id='" + title + "']");
                XmlNode nuNode = node.SelectSingleNode("NextUpdate");
                nuNode.InnerText = aDay.ToString();
            }
            else if (interval == "Every week")
            {
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load("xml.xml");
                XmlNode node = xdoc.SelectSingleNode("/Feeds/Feed[@id='" + title + "']");
                XmlNode nuNode = node.SelectSingleNode("NextUpdate");
                nuNode.InnerText = aWeek.ToString();
            }
            else if (interval == "Every month")
            {
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load("xml.xml");
                XmlNode node = xdoc.SelectSingleNode("/Feeds/Feed[@id='" + title + "']");
                XmlNode nuNode = node.SelectSingleNode("NextUpdate");
                nuNode.InnerText = aMonth.ToString();
            }
        }
        public static List<string> getNextUpdate()
        {
            try
            {
                if (File.Exists("xml.xml"))
                {
                    List<string> titles = getPodcastTitlesFromXml();
                    List<string> titlesToUpdateList = new List<string>();

                    XmlDocument xdoc = new XmlDocument();
                    xdoc.Load("xml.xml");

                    XmlNodeList eList = xdoc.GetElementsByTagName("NextUpdate");
                    foreach (string title in titles)
                    {
                        string nextupdate = getSingleNextUpdate(title);
                        if (compareDates(nextupdate))
                        {
                            titlesToUpdateList.Add(title);
                        }
                    }

                    return titlesToUpdateList;
                }
                else
                {
                    List<string> titlesToUpdateList = new List<string>();
                    return titlesToUpdateList;
                }
                
            }
            catch (Exception)
            {
                throw;
                
            }
        }
        
        public static bool compareDates(string date)
        {
            DateTime dt = Convert.ToDateTime(date);
            int result = DateTime.Compare(now, dt);
            if (result >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void removeXmlFile(string title)
        {
            File.Delete(@"..\XmlFeeds\" + title + ".xml");
        }
        public static List<string> getPodcastTitlesFromXml()
        {
            try
            {
                if (File.Exists("xml.xml"))
                {
                    List<string> titleList = new List<string>();
                    XmlDocument xdoc = new XmlDocument();
                    xdoc.Load("xml.xml");

                    XmlNodeList eList = xdoc.GetElementsByTagName("Title");
                    for (int i = 0; i < eList.Count; i++)
                    {
                        titleList.Add(eList[i].InnerXml);
                    }

                    return titleList;
                }
                else
                {
                    List<string> titleList = new List<string>();
                    return titleList;
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
