﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using ClassLibrary2;

namespace ClassLibrary1
{
    class CompareXml
    {

        FetchXml fetch = new FetchXml();
        LoadXml load = new LoadXml();

        public void Comapare(string e)
        {
            XmlDocument doc = new XmlDocument();
            XmlDocument doc2 = new XmlDocument();
            doc2.Load("xml.xml");
            XmlNode nodeList;
            XmlNode root = doc2.DocumentElement;

            nodeList = root.SelectSingleNode("descendant::Feed[title='" + e + "']/URL");
            var a = nodeList.InnerText;
            var b = FetchXml.DownloadXml(a);

            var c = load.ReadXml(e);

            int old = c.DocumentElement.
            
        }

    }
}