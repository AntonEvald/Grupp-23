using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace ClassLibrary1
{


    public class Fetch_Podcast
    {


        public void Podcastlink(string Url,string cat)
        {
            XmlConection xmlConection = new XmlConection();
                var podcastfeed = FetchXml.DownloadXml(Url);
                var name = FeedName(podcastfeed);
                var folder = CreateFolders.CreateXmlFolder();
                podcastfeed.Save(folder+@"\"+name+".xml");
                xmlConection.writeToXml(name,Url,cat);
        }

        public string FeedName(XmlDocument e)
        {
            var a = e.SelectSingleNode("(//title)[1]");
            string b = a.InnerText;
            return b;
        }


        public List<String> Episodes(XmlDocument e)
        {
            List<string> episodes = new List<string>();
            foreach (System.Xml.XmlNode item
         in e.DocumentElement.SelectNodes("channel/item"))
            {
                //Skriv ut dess titel.
                var title = item.SelectSingleNode("title");
                episodes.Add(title.InnerText);
            }
            return episodes;
        }

        public string Description(XmlDocument e)
        {
            
            var tit = FeedName(e);
            XmlNode nodeList;
            XmlNode root = e.DocumentElement;

            nodeList = root.SelectSingleNode("descendant::item[title='" + tit + "']/description");
            var descrition = nodeList.InnerText;
            return descrition;


        }
        
    }
}


