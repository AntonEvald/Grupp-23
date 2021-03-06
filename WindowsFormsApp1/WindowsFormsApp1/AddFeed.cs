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
            List<string> list = Categories.CategoryList;
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
                Feeds Fp = new Feeds();
                string chosenCat = AddFeedCategoryCB.GetItemText(this.AddFeedCategoryCB.SelectedItem);
                string chosenUrl = urlTB.Text;
                string chosenInt = IntervallCb.GetItemText(this.IntervallCb.SelectedItem);

                string lastUpdate = IntervalClass.now.ToString();
                string updateAday = IntervalClass.aDay.ToString();
                string updateSevenDays = IntervalClass.sevenDays.ToString();
                string updateAmonth = IntervalClass.aMonth.ToString();

                if (!Validation.textEmpty(chosenCat))
                {
                    if (!Validation.textEmpty(chosenUrl))
                    {
                        if (!Feeds.FeedExists(chosenUrl))
                        {
                            if (chosenInt == "Every day")
                            {
                                Fp.Podcastlink(chosenUrl, chosenCat, chosenInt, updateAday);
                                Close();
                                MessageBox.Show("Feeden har lagts till!");
                                
                            }
                            else if (chosenInt == "Every week")
                            {
                                Fp.Podcastlink(chosenUrl, chosenCat, chosenInt, updateSevenDays);
                                Close();
                                MessageBox.Show("Feeden har lagts till!");
                                
                            }
                            else if (chosenInt == "Every month")
                            {
                                Fp.Podcastlink(chosenUrl, chosenCat, chosenInt, updateAmonth);
                                Close();
                                MessageBox.Show("Feeden har lagts till!");
                            }
                            else if (Validation.textEmpty(chosenInt))
                            {
                                MessageBox.Show("Du måste välja ett intervall");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Denna feed finns redan!");
                        }
                        
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
