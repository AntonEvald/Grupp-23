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
using System.Threading;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Start : Form
    {
       
        public Start()
        {
            InitializeComponent();
            listBox1.MouseDoubleClick += new MouseEventHandler(listBox1_DoubleClick);
            fillCombo();
            new Thread(() => IntervalClass.updateTitles(IntervalClass.toBeUpdatedList())) { IsBackground = true }.Start();

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
            List<string> titles = PodcastNames.getPodcastsFromXML();
            listBox1.DataSource = titles;
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

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            List<string> titles = PodcastNames.getPodcastsFromXML();
            listBox1.DataSource = titles;
        }

        private void listBox1_DoubleClick(object sender, MouseEventArgs e)
        {

            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                string a = listBox1.SelectedItem.ToString();
                EpisodesForm form = new EpisodesForm(a);
                form.Show();

            }
        }

        private void categoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCat = categoryCombo.GetItemText(this.categoryCombo.SelectedItem);
            List<string> filtredTitles = PodcastNames.fList(selectedCat);
            listBox1.DataSource = filtredTitles;
        }
    }
}
