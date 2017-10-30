using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using System.Xml;
using System.IO;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class EpisodesForm : Form
    {
        private string a;
        Fetch_Podcast podcast;
        XmlDocument xml;
        string episode;
        CompareXml compare = new CompareXml();
        public EpisodesForm(string a)
        {
            InitializeComponent();
            this.a = a;
            listBox1.MouseClick += new MouseEventHandler(listBox1_Click);
            podcast = new Fetch_Podcast();
            xml = new XmlDocument();
            xml.Load(@"..\XmlFeeds\" + a + ".xml");
            
        }

        private void EpisodesForm_Load(object sender, EventArgs e)
        {
            label1.Text = a;
            label2.Text = "description";;
            var list = podcast.Episodes(xml);
            listBox1.DataSource = list;
        }

        internal void CheckIfPlayed(string w)
        {

            var Played = compare.Check(w);
            if (Played == "Yes")
            {
                label3.Text = "Already Played";
            }
            else
            {
                label3.Text = "";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void listBox1_Click(object sender, MouseEventArgs e)
        {

            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                string episode = listBox1.SelectedItem.ToString();
                this.episode = episode;
                var list = podcast.Description(xml, episode);
                podcast.Podcastlink(episode);
                CheckIfPlayed(episode);
                textBox1.Text = list;
                if (File.Exists(@"..\Mp3\"+a+@"\" + episode + ".mp3"))
                {
                    button1.Text = "Play Episode";
                }
                else
                {
                    button1.Text = "Download Episode";
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(button1.Text.ToString().Contains("Play Episode"))
            {
                PlayMp3 play = new PlayMp3();
                play.PlayMp3File(episode, a); 
            }
            else
            {
                DownloadMp3 download = new DownloadMp3();
                var b = listBox1.SelectedItem.ToString();
                download.Download(a, b);
                DownloadWindow window = new DownloadWindow(b);
                window.Show();
            }

        }

    }
}
