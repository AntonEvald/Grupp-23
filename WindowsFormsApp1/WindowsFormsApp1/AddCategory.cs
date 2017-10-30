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
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
            Validation v = new Validation();
            string category = textBox1.Text;
            if (Validation.textEmpty(category))
            {
                MessageBox.Show("Ange en kategori att lägga till!");
            }
            else
            {
                if (v.IsNewCat(category))
                {
                    v.IsNewCat(category);
                    Categories.AddCategory(category);
                    MessageBox.Show("Kategorin: " + category + " har lagts till!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Denna kategori finns redan!");
                }
            }
        }
    }
}
