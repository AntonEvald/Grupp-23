﻿using System;
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
        
        public AddFeed()
        {
           
            InitializeComponent();
            FillCatCombo();
        }
        
        public void FillCatCombo()
        {
            List<string> list = ModifyCategories.Categories;
            AddFeedCategoryCB.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                string category = list[i];
                AddFeedCategoryCB.Items.Add(category);
            }
        }


        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            AddCategory ac = new AddCategory();
            ac.Show();
        }

        private void AddFeedCategoryCB_MouseClick(object sender, MouseEventArgs e)
        {
            FillCatCombo();
        }

        private void addFeedBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                Fetch_Podcast Fp = new Fetch_Podcast();
                string chosenCat = AddFeedCategoryCB.GetItemText(this.AddFeedCategoryCB.SelectedItem);
                string chosenUrl = urlTB.Text;
                string chosenInt = IntervallCb.GetItemText(this.IntervallCb.SelectedItem);
                IntervalClass T = new IntervalClass();

                if (!Validation.textEmpty(chosenCat))
                {
                    if (!Validation.textEmpty(chosenUrl))
                    {
 
                        Fp.Podcastlink(chosenUrl, chosenCat, chosenInt);
                        MessageBox.Show("Feeden har lagts till!");
                        Close();

                    }
                    else
                    {
                        MessageBox.Show("Du måste ange en giltig url");
                    }
                }
                else
                {
                    MessageBox.Show("Du måste ange en kategori");

                }
            }
            catch (Exception)
            {

            }
        }

    }
}
