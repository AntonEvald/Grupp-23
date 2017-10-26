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
    public partial class ChangeFeed : Form
    {
        public ChangeFeed()
        {
            InitializeComponent();
            fillFeedCombo();
            fillCatCombo();
        }

        private void fillFeedCombo()
        {
            PickFeedCombo.Items.Clear();
            List<string> titles = PodcastNames.getPodcastsFromXML();
            foreach (string title in titles)
            {
                PickFeedCombo.Items.Add(title);
            }
        }

        private void fillCatCombo()
        {
            List<string> list = ModifyCategories.Categories;
            foreach(string category in list)
            {
                changeCatCombo.Items.Add(category);
            }
        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            string newCat = changeCatCombo.GetItemText(this.changeCatCombo.SelectedItem);
            string feed = PickFeedCombo.GetItemText(this.PickFeedCombo.SelectedItem);
            string newInt = intervalCombo.GetItemText(this.intervalCombo.SelectedItem);
            if (Validation.textEmpty(feed))
            {
                MessageBox.Show("Du måste välja en feed att ändra!");
            }
            else
            {
                if (Validation.textEmpty(newCat))
                {
                    MessageBox.Show("Du måste välja en kategori!");
                }
                else
                {
                    if (Validation.textEmpty(newInt))
                    {
                        MessageBox.Show("Du måste välja en intervall");
                    }
                    else
                    {
                        XmlConection.UpdateXml(feed, newCat, newInt);
                    }
                }
            }
        }
    }
}
