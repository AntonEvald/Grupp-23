using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ClassLibrary1
{
    public class PodcastNames
    {
        public static List<string> podcastsList = new List<string>();

      /*  public static void getPodcastsFromXML()
        {
            podcastsList.Clear();
            XDocument xdoc = XDocument.Load("xml.xml");
            podcastsList = xdoc.Root.Elements("Title")
                .Select(element => element.Value)
                .ToList();
        }*/
    }
}
