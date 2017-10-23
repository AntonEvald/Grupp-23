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
            doc.Load(s);
            return doc;
        }
        
    }
}
