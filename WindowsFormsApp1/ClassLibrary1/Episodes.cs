using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ClassLibrary1
{
    public class Episodes
    {
        public static List<String> ListEpisodes(XmlDocument e)
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

        public static string Description(XmlDocument e, string a)
        {

            var tit = a;
            XmlNode nodeList;
            XmlNode root = e.DocumentElement;

            nodeList = root.SelectSingleNode("descendant::item[title='" + tit + "']/description");
            var descrition = nodeList.InnerText;
            return descrition;


        }
    }
}
