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
                var chosenCat = addFeedCategoryCB.SelectedItem;
                string chosenUrl = urlTB.Text;
                if (chosenCat != null )
                {
                    if (!Validation.textEmpty(chosenUrl) && Validation.IsXML(chosenUrl))
                    {
                        /*if ()
                        {

                        }*/

                    }
                    else
                    {
                        MessageBox.Show("Du måste ange en giltig URL");
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

        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            AddCategory ac = new AddCategory();
            ac.Show();
        }
    }
}
