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
        XmlDocument pod; 
        
            public bool PodcastObject(string s)
        {
            if (Validation.IsXML(s))
            {
                var podcastfeed = FetchXml.DownloadXml(s);
                pod = podcastfeed;
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }

}


