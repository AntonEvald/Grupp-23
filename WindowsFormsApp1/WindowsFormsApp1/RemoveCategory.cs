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
    public partial class RemoveCategory : Form
    {
        public RemoveCategory()
        {
            InitializeComponent();
            fillRemoveCombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string category = removeCombo.GetItemText(this.removeCombo.SelectedItem);
            if(category != "")
            {
                ModifyCategories.Categories.Remove(category);
                MessageBox.Show("Kategorin: " + category + " har tagits bort!");
                Close();
            }
            else
            {
                MessageBox.Show("Ingen kategori vald!");
            }
        }

        public void fillRemoveCombo()
        {
            List<string> list = ModifyCategories.Categories;
            removeCombo.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                string category = list[i];
                removeCombo.Items.Add(category);
            }
        }
    }
}
