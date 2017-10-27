using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using ClassLibrary2;
using System.Diagnostics;

namespace ClassLibrary1
{
    public class CompareXml
    {

        FetchXml fetch = new FetchXml();
        LoadXml load = new LoadXml();

        public void Comapare(string e)
        {
            XmlDocument doc = new XmlDocument();
            XmlDocument doc2 = new XmlDocument();
            doc2.Load("xml.xml");
            XmlNode nodeList;
            XmlNode root = doc2.DocumentElement;

            nodeList = root.SelectSingleNode("descendant::Feed[Title='" + e + "']/URL");
            var a = nodeList.InnerText;
            var b = FetchXml.DownloadXml(a);
            var c = load.ReadXml(e);
            int old = c.GetElementsByTagName("Item").Count;
            int rss = b.GetElementsByTagName("Item").Count;
            Debug.WriteLine(old);
            Debug.WriteLine(rss);
            if (old < rss)
            {
                b.Save(@"..\XmlFeeds\" + e + ".xml");

            }
            else
            {

            }
        }

        public string Check(string e)
        {

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("Played.xml");
            XmlNode node = xmlDoc.SelectSingleNode("/Feeds/Podcasts[@id='" + e + "']");
            XmlNode a = node.SelectSingleNode("Played");
            string ret = a.InnerText;
            return ret;
        }

        public bool CheckIfTitleExists(string title)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Played.xml");
            List<string> episodes = new List<string>();
            foreach (System.Xml.XmlNode item
         in doc.DocumentElement.SelectNodes("Podcasts"))
            {
                //Skriv ut dess titel.
                var titles = item.SelectSingleNode("Title");
                episodes.Add(titles.InnerText);
            }


            string result = episodes.FirstOrDefault(x => x == title);

            if (result != null)
            {
                return true;
            }
            return false;
        }
    }
}
