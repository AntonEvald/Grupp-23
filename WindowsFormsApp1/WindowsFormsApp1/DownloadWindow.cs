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
        DownloadMp3 Download;

        public DownloadWindow()
        {
            InitializeComponent();
            Download = new DownloadMp3();
            progressBar1.Value = Download.ProgressBar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Download.Cancel();
            this.Dispose();
        }
    }
}
