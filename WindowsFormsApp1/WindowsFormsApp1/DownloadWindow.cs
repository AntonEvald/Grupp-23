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
            label1.Text = "Downloading Episode.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Download.Cancel();
            this.Dispose();
            
        }

        public void Progressbar()
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            var procent =  Download.progress;
            while (procent < 100)
            {
                procent = Download.progress;
            }
            label1.Text = "Download Complete.";
        }
    }
}
