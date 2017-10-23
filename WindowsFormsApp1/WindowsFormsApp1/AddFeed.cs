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
    public partial class AddFeed : Form
    {
        
        public AddFeed()
        {
            InitializeComponent();
            fillCombo();
        }

        private void AddFeed_Load(object sender, EventArgs e)
        {
            ModifyCategories.GetCategories();
            fillCombo();
        }
        public void fillCombo()
        {
            List<string> list = ModifyCategories.Categories;
            addFeedCategoryCB.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                string category = list[i];
                addFeedCategoryCB.Items.Add(category);
            }
        }
       
        private void addFeedCategoryCB_Click(object sender, EventArgs e)
        {
            fillCombo();
        }

        private void addFeedBtn_Click(object sender, EventArgs e)
        {
            try {
                string chosenCat = addFeedCategoryCB.SelectedItem.ToString();
                string chosenUrl = urlTB.Text;
                if (!Validation.textEmpty(chosenCat))
                {
                    if (Validation.IsXML(chosenUrl))
                    {
                        Fetch_Podcast podcast = new Fetch_Podcast();
                        podcast.Podcastlink(chosenUrl);
                    }
                    else
                    {
                        MessageBox.Show("Du måste ange en giltig url");
                    }
                }
                else
                {
                    MessageBox.Show("Du måste ange en kategori");
                }
            }
            catch (Exception)
            {
               
                throw;
            }
        }
    }
}
