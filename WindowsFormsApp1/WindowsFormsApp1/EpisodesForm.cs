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

namespace WindowsFormsApp1
{
    public partial class EpisodesForm : Form
    {
        private string a;
        Fetch_Podcast podcast;
        XmlDocument xml;
        public EpisodesForm(string a)
        {
            InitializeComponent();
            this.a = a;
            listBox1.MouseDoubleClick += new MouseEventHandler(listBox1_DoubleClick);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void listBox1_DoubleClick(object sender, MouseEventArgs e)
        {

            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                string episode = listBox1.SelectedItem.ToString();
                var list = podcast.Description(xml, episode);
                textBox1.Text = list;
            }

        }

    }
}
