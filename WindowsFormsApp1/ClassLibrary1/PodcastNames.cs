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
                    List<string> titleList = new List<string>();
                    XmlDocument xdoc = new XmlDocument();
                    xdoc.Load("xml.xml");

                    XmlNodeList eList = xdoc.GetElementsByTagName("Title");
                    for(int i=0; i < eList.Count; i++)
                    {
                        titleList.Add(eList[i].InnerXml);
                    }
                    
                    return titleList;
                }
                else
                {
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
