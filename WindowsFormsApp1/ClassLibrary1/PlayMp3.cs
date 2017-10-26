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

        public void PlayMp3File(string s)
        {
            Fetch_Podcast podcast = new Fetch_Podcast();
            string Played = "Yes";
            System.Diagnostics.Process.Start(@"..\Mp3\"+s+".mp3");
            podcast.Podcastlink(s,Played);
        }

    }
}
