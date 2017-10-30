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

namespace WindowsFormsApp1
{
    public partial class RemoveFeed : Form
    {
        public RemoveFeed()
        {
            InitializeComponent();
            fillCombo();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            String feed = removeCombo.GetItemText(this.removeCombo.SelectedItem);
            if (Validation.textEmpty(feed))
            {
                MessageBox.Show("Du måst välja en feed att ta bort!");
            }
            else
            {
                Feeds.RemoveFromXml(feed);
                Remove remove = new Remove();
                remove.RemoveMp3(feed);
                MessageBox.Show(feed + " har tagits bort!");
                Close();
            }
        }

        private void fillCombo()
        {
            removeCombo.Items.Clear();
            List<string> titles = Feeds.getPodcastsFromXML();
            foreach(string title in titles)
            {
                removeCombo.Items.Add(title);
            }
        }
    }
}
