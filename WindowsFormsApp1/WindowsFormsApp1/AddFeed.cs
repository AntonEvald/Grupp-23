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
            FillCombo();
        }

        public void FillCombo()
        {
            List<string> list = ModifyCategories.Categories;
            AddFeedCategoryCB.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                string category = list[i];
                AddFeedCategoryCB.Items.Add(category);
            }
        }

        private void AddFeedBtn_Click(object sender, EventArgs e)
        {
            try {
                string chosenCat = AddFeedCategoryCB.GetItemText(this.AddFeedCategoryCB.SelectedItem);
                string chosenUrl = urlTB.Text;
                if (Validation.textEmpty(chosenCat))
                {
                    MessageBox.Show("Du måste ange en kategori");
                }
                else
                {
                    MessageBox.Show("Du måste ange en kategori");
                    if (Validation.IsXML(chosenUrl) && !Validation.textEmpty(chosenUrl))
                    {


                    }
                    else
                    {
                        MessageBox.Show("Du måste ange en giltig url");
                    }
                }
            }
            catch (Exception)
            {
               
                throw;
            }
        }

        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            AddCategory ac = new AddCategory();
            ac.Show();
        }

        private void AddFeedCategoryCB_MouseClick(object sender, MouseEventArgs e)
        {
            FillCombo();
        }

        private void addFeedBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                Fetch_Podcast Fp = new Fetch_Podcast();
                string chosenCat = AddFeedCategoryCB.GetItemText(this.AddFeedCategoryCB.SelectedItem);
                string chosenUrl = urlTB.Text;

                if (!Validation.textEmpty(chosenCat))
                {
                    if (Validation.IsXML(chosenUrl) && !Validation.textEmpty(chosenUrl))
                    {
                        Fp.Podcastlink(chosenUrl,chosenCat);


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
