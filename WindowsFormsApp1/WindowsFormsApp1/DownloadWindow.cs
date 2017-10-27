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
    public partial class DownloadWindow : Form
    {
        DownloadMp3 DownloadMp3 = new DownloadMp3();
        public DownloadWindow(string b)
        {
            InitializeComponent();
            label1.Text = "Downloading Episode:  " + b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DownloadMp3.Cancel();
            this.Dispose();
        }
    }
}
