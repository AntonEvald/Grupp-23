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
    public partial class Start : Form
    {
       
        public Start()
        {
            InitializeComponent();
            fillCombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCategory ac = new AddCategory();
            ac.Show();
        }

        public void fillCombo()
        {
            List <string> list = ModifyCategories.Categories;
            categoryCombo.Items.Clear();
            categoryCombo.Items.Add("All");
            for (int i = 0; i < list.Count; i++)
            {
                string category = list[i];
                categoryCombo.Items.Add(category);
            }
            categoryCombo.SelectedIndex = 0;
        }

        private void categoryCombo_Click(object sender, EventArgs e)
        {
            fillCombo();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            RemoveCategory rc = new RemoveCategory();
            rc.Show();
        }

        private void changeCatBtn_Click(object sender, EventArgs e)
        {
            ChangeCategory cc = new ChangeCategory();
            cc.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ModifyCategories.SaveCategories();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ModifyCategories.GetCategories();
            //PodcastNames.getPodcastsFromXML();
            listBox1.DataSource = PodcastNames.podcastsList;
        }

        private void feedsBtn_Click(object sender, EventArgs e)
        {
            ModifyFeeds F = new ModifyFeeds();
            F.Show();
        }

        private void ModifyCategoriesBtn_Click(object sender, EventArgs e)
        {
            MCForm mcf = new MCForm();
            mcf.Show();
        }
    }
}
