using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ClassLibrary2
{
    public class LoadXml
    {
        public XmlDocument ReadXml(string s)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\MightyKong\Desktop\C sharp projekt\Xml feeds\"+s+".xml");
            return doc;
        }
        
    }
}
