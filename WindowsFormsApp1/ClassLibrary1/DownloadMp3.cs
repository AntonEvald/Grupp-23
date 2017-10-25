using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;
using System.Net;
using System.Xml;

namespace ClassLibrary1
{
    class DownloadMp3
    {

        LoadXml xml = new LoadXml();
        // tar in två stängar, en för vilken podcast och en annan för vilket avsnitt som nman vill ladda ner.
        public void Download(string e, string f)
        {
            var xmldoc = xml.ReadXml(e);
            XmlNode nodeList;
            XmlNode root = xmldoc.DocumentElement;

            nodeList = root.SelectSingleNode("descendant::item[title='" + f + "']/enclosure/@url");
            var link = nodeList.InnerText;
            WebClient client = new WebClient();
            var folder = CreateFolders.CreateMp3Folder();
            client.DownloadFileAsync(new Uri(link), folder+@"\"+f+".mp3");
        }

    }
}
