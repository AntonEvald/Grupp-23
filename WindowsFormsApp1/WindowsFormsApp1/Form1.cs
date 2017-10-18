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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            fillCombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void categoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillCombo()
        {
            List <string> list = ModifyCategories.Categories;
            for (int i = 0; i < list.Count; i++)
            {
                string category = list[i];
                categoryCombo.Items.Add(category);
            }
        }
    }
}
