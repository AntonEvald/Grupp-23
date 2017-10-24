using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace ClassLibrary2
{
    class XmlConection
    {
        public void writeToXml()
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            using (XmlWriter writer = XmlWriter.Create("xml.xml", settings))
            {
                writer.WriteElementString("Title",);


            }
        }

    }
}
