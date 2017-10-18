using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace ClassLibrary1
{
    public class FetchXml
    {

        public static ClassLibrary2.FetchXml fetch = new ClassLibrary2.FetchXml();
        public List<string> calledList = new List<string>();

        public void PodcastList()
        {
            calledList = fetch.DownloadXmlTitles();
        }

    }
}
