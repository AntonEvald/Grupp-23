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
    public partial class ChangeCategory : Form
    {
        public ChangeCategory()
        {
            InitializeComponent();
            fillChangeCombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string category = changeCombo.GetItemText(this.changeCombo.SelectedItem);
            string newCategory = ChangeToField.Text;
            Validation v = new Validation();
            if(Validation.textEmpty(category))
            {
                MessageBox.Show("Välj en kategori att ändra!");
                
            }
            else
            {
                if (v.IsNewCat(newCategory))
                {
                    Categories.RemoveCategory(category);
                    Categories.AddCategory(newCategory);
                    MessageBox.Show("Kategorin: " + category + " har ändrats till: " + newCategory);
                    Close();
                }
                else
                {
                    MessageBox.Show("Ändringen du angett är inte giltig!");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void fillChangeCombo()
        {
            List<string> list = Categories.CategoryList;
            changeCombo.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                string category = list[i];
                changeCombo.Items.Add(category);
            }
        }

        private void changeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = changeCombo.GetItemText(this.changeCombo.SelectedItem);
            ChangeToField.Text = item;
        }

        private void ChangeCategory_Load(object sender, EventArgs e)
        {

        }
    }
}
