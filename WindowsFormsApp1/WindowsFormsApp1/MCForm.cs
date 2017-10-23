using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MCForm : Form
    {
        public MCForm()
        {
            InitializeComponent();
        }


        private void AddCatBtn_Click(object sender, EventArgs e)
        {
            AddCategory ac = new AddCategory();
            ac.Show();
        }

        private void ChangeCatBtn_Click(object sender, EventArgs e)
        {
            ChangeCategory cc = new ChangeCategory();
            cc.Show();
        }

        private void RemoveCatBtn_Click(object sender, EventArgs e)
        {
            RemoveCategory rc = new RemoveCategory();
            rc.Show();
        }
    }
}
