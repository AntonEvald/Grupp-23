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


        public void Podcastlink(string s)
        {
            if (Validation.IsXML(s))
            {
                var podcastfeed = FetchXml.DownloadXml(s);
                var name = FeedName(podcastfeed);
                podcastfeed.Save(@"C:\Users\MightyKong\Desktop\C sharp projekt\Xml feeds\"+name+".xml"); 
            }
        }

        public string FeedName(XmlDocument e)
        {
            var a = e.SelectSingleNode("(//title)[1]");
            string b = a.InnerText;
            return b;
        }

       /* public List<String> Episodes()
        {
            List<string> episodes = new List<string>();
            foreach (System.Xml.XmlNode item
         in pod.DocumentElement.SelectNodes("channel/item"))
            {
                //Skriv ut dess titel.
                var title = item.SelectSingleNode("title");
                episodes.Add(title.InnerText);
            }
            return episodes;
        }

        public string Description(string e)
        {
            
            var tit = FeedName();
            var xml = "";
            using (var client = new System.Net.WebClient())
            {
                client.Encoding = Encoding.UTF8;
                xml = client.DownloadString(e);
            }

            //Skapa en objektrepresentation.
            var dom = new System.Xml.XmlDocument();
            dom.LoadXml(xml);

            XmlNode nodeList;
            XmlNode root = dom.DocumentElement;

            nodeList = root.SelectSingleNode("descendant::item[title='" + tit + "']/description");
            var descrition = nodeList.InnerText;
            return descrition;


        }
        */
    }
}


