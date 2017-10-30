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
            XmlHandler xmlConection = new XmlHandler();
            System.Diagnostics.Process.Start(@"..\Mp3\"+a+@"\"+s+".mp3");
            XmlHandler.setPlayedYes(s);
        }



    }
}
