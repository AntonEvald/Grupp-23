using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace ClassLibrary1
{
    public class PlayMp3
    {

        public void PlayMp3File(string s, string a)
        {
            XmlConection xmlConection = new XmlConection();
            System.Diagnostics.Process.Start(@"..\Mp3\"+a+@"\"+s+".mp3");
            XmlConection.setPlayedYes(s);
        }



    }
}
