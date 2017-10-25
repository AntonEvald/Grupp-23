using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace ClassLibrary1
{
    public class PodcastNames
    {

        public static List<string> getPodcastsFromXML()
        {
            try
            {
                if(File.Exists("xml.xml"))
                {
                    XDocument xdoc = XDocument.Load("xml.xml");
                    List <string> titleList = xdoc.Root.Elements("Title")
                        .Select(element => element.Value)
                        .ToList();
                    return titleList;
                }
                else
                {
                    XmlConection.createXml();
                    List<string> titleList = new List<string>();
                    return titleList;
                }
               
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
