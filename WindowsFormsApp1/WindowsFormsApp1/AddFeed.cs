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
        List<String> cats = ModifyCategories.Categories;
        public AddFeed()
        {
            InitializeComponent();
        }

        private void AddFeed_Load(object sender, EventArgs e)
        {

        }
        
    }
}
