using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class PlayMp3
    {

        public void PlayMp3File(string s)
        {
            System.Diagnostics.Process.Start(@"..\Mp3\"+s+".mp3");
        }

    }
}
