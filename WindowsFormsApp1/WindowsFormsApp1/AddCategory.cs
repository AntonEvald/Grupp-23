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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OKbtn_Click(object sender, EventArgs e)
        {
            string category = textBox1.Text;
            try
            {
                if (ModifyCategories.validateNewCat(category) is true)
                {
                    ModifyCategories.AddCategory(category);
                    MessageBox.Show("Tillagt");
                    Close();
                }
                else
                {
                    MessageBox.Show("Ej giltig");
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        
           
            
        }
    }
}
