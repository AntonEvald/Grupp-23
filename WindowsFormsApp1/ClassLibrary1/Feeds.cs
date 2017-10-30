using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Diagnostics;

namespace ClassLibrary1
{
    public class Feeds
    {

        public static List<string> getPodcastsFromXML()
        {
            try
            {
                if(File.Exists("xml.xml"))
                {
                    List<string> titleList = new List<string>();
                    XmlDocument xdoc = new XmlDocument();
                    xdoc.Load("xml.xml");

                    XmlNodeList eList = xdoc.GetElementsByTagName("Title");
                    for(int i=0; i < eList.Count; i++)
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

        public static void RemoveFromXml(string title)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("xml.xml");
                XmlNode node = xmlDoc.SelectSingleNode("/Feeds/Feed[@id='" + title + "']");
                if(node != null)
                {
                    XmlNode parent = node.ParentNode;
                    parent.RemoveChild(node);
                    xmlDoc.Save("xml.xml");
                    XmlConection.removeXmlFile(title);
                }
                
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static void UpdateXml(string title, string cat, string interval)
        {
            string nextupdate;
            if (interval == "Every day")
            {
                nextupdate = IntervalClass.aDay.ToString();
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load("xml.xml");
                XmlNode node = xdoc.SelectSingleNode("/Feeds/Feed[@id='" + title + "']");
                XmlNode catNode = node.SelectSingleNode("Category");
                catNode.InnerText = cat;
                XmlNode intNode = node.SelectSingleNode("Interval");
                intNode.InnerText = interval;
                XmlNode nuNode = node.SelectSingleNode("NextUpdate");
                nuNode.InnerText = nextupdate;
                xdoc.Save("xml.xml");
            }
            else if (interval == "Every week")
            {
                nextupdate = IntervalClass.sevenDays.ToString();
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load("xml.xml");
                XmlNode node = xdoc.SelectSingleNode("/Feeds/Feed[@id='" + title + "']");
                XmlNode catNode = node.SelectSingleNode("Category");
                catNode.InnerText = cat;
                XmlNode intNode = node.SelectSingleNode("Interval");
                intNode.InnerText = interval;
                XmlNode nuNode = node.SelectSingleNode("NextUpdate");
                nuNode.InnerText = nextupdate;
                xdoc.Save("xml.xml");
            }
            else if (interval == "Every month")
            {
                nextupdate = IntervalClass.aMonth.ToString();
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load("xml.xml");
                XmlNode node = xdoc.SelectSingleNode("/Feeds/Feed[@id='" + title + "']");
                XmlNode catNode = node.SelectSingleNode("Category");
                catNode.InnerText = cat;
                XmlNode intNode = node.SelectSingleNode("Interval");
                intNode.InnerText = interval;
                XmlNode nuNode = node.SelectSingleNode("NextUpdate");
                nuNode.InnerText = nextupdate;
                xdoc.Save("xml.xml");
            }
        }

        public static bool FeedExists(string url)
        {
            if (File.Exists("xml.xml"))
            {
                XDocument doc = XDocument.Load("xml.xml");
                var result = doc.Descendants("Feed").Any(x => x.Element("URL").Value.Equals(url));
                if (result == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            
        }

        public static List<string> fList(string cat)
        {
            List<string> titles = getPodcastsFromXML();
            List<string> filtredList = new List<string>();
            if(cat == "All")
            {
                return titles;
            }
            else
            {
                foreach (string title in titles)
                {
                    XmlDocument xdoc = new XmlDocument();
                    xdoc.Load("xml.xml");
                    XmlNode node = xdoc.SelectSingleNode("/Feeds/Feed[@id='" + title + "']");
                    XmlNode catNode = node.SelectSingleNode("Category");
                    string category = catNode.InnerText;
                    if(cat == category)
                    {
                        filtredList.Add(title);
                    }
                }
                return filtredList;
            }
            
        }

        CompareXml CompareXml = new CompareXml();
        public void Podcastlink(string Url, string cat, string interval, string nextupdate)
        {
            XmlConection xmlConection = new XmlConection();
            XmlDocument podcastfeed = FetchXml.DownloadXml(Url);
            var name = FeedName(podcastfeed);
            Podcastlink(name);
            var folder = CreateFolders.CreateXmlFolder();
            podcastfeed.Save(folder + @"\" + name + ".xml");
            if (File.Exists("xml.xml"))
            {
                xmlConection.writeToXml(name, Url, cat, interval, nextupdate, "No");
            }
            else
            {
                XmlConection.createXml();
                xmlConection.writeToXml(name, Url, cat, interval, nextupdate, "No");
            }

        }
        public void Podcastlink(string title)
        {

            XmlConection xml = new XmlConection();
            if (File.Exists("played.xml"))
            {
                XDocument doc = XDocument.Load("Played.xml");
                var CustNoExist = doc.Descendants("Title").Any(x => (string)x == title);
                if (CustNoExist == false)
                {
                    xml.writeToXml(title);
                }
            }

            else
            {
                XmlConection.createXml(title);
                xml.writeToXml(title);
            }


        }

        public string FeedName(XmlDocument e)
        {
            var a = e.SelectSingleNode("(//title)[1]");
            string b = a.InnerText;
            return b;
        }
    }
}
