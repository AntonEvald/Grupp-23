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
    public partial class ModifyFeeds : Form
    {
        public ModifyFeeds()
        {
            InitializeComponent();
        }

        private void addFeedBtn_Click(object sender, EventArgs e)
        {
            AddFeed AF = new AddFeed();
            AF.Show();
        }

        private void removeFeedBtn_Click(object sender, EventArgs e)
        {
            RemoveFeed rf = new RemoveFeed();
            rf.Show();
        }

        private void alterFeed_Click(object sender, EventArgs e)
        {
            ChangeFeed cf = new ChangeFeed();
            cf.Show();
        }
    }
}
