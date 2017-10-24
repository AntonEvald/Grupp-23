using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace ClassLibrary2
{
    public class XmlConection
    {
        public void writeToXml(string title, string url, string cat)
        {

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            using (XmlWriter writer = XmlWriter.Create("xml.xml", settings))
            {
                writer.WriteStartElement("Feed");
                writer.WriteElementString("Title", title);
                writer.WriteElementString("URL", url);
                writer.WriteElementString("Category", cat);
                //writer.WriteElementString("Interval", interval);
                writer.WriteEndElement();



            }


        }
    }
}
