using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;
using System.Net;
using System.Xml;
using System.Windows.Forms;
using System.ComponentModel;

namespace ClassLibrary1
{
    public class DownloadMp3
    {
        WebClient client = new WebClient();
        LoadXml xml = new LoadXml();
        // tar in två stängar, en för vilken podcast och en annan för vilket avsnitt som nman vill ladda ner.
        public void Download(string e, string f)
        {
            var xmldoc = xml.ReadXml(e);
            XmlNode nodeList;
            XmlNode root = xmldoc.DocumentElement;

            nodeList = root.SelectSingleNode("descendant::item[title='" + f + "']/enclosure/@url");
            var link = nodeList.InnerText;
            var folder = CreateFolders.CreateMp3Folder(e);
            client.DownloadFileAsync(new Uri(link), folder + @"\"+ f + ".mp3");
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressChanged);
        }

        public void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {

           
        }

        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Complete");
        }

        public void Cancel()
        {
            client.CancelAsync();   
        }
    }

}
