using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ClassLibrary2
{
     public class SaveXML
    {
        public static void SaveXMLDoc (XmlDocument x)
        {
            x.Save(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }
    }
}
