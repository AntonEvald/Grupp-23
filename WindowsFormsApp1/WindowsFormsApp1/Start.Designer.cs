﻿namespace WindowsFormsApp1
{
    partial class Start
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.categoryCombo = new System.Windows.Forms.ComboBox();
            this.feedsBtn = new System.Windows.Forms.Button();
            this.ModifyCategoriesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(12, 21);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(671, 593);
            this.listBox1.TabIndex = 1;
            // 
            // categoryCombo
            // 
            this.categoryCombo.BackColor = System.Drawing.SystemColors.Control;
            this.categoryCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryCombo.FormattingEnabled = true;
            this.categoryCombo.Items.AddRange(new object[] {
            "All"});
            this.categoryCombo.Location = new System.Drawing.Point(736, 43);
            this.categoryCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryCombo.MaxDropDownItems = 10;
            this.categoryCombo.Name = "categoryCombo";
            this.categoryCombo.Size = new System.Drawing.Size(380, 39);
            this.categoryCombo.TabIndex = 3;
            this.categoryCombo.Click += new System.EventHandler(this.categoryCombo_Click);
            // 
            // feedsBtn
            // 
            this.feedsBtn.Location = new System.Drawing.Point(1458, 509);
            this.feedsBtn.Name = "feedsBtn";
            this.feedsBtn.Size = new System.Drawing.Size(321, 68);
            this.feedsBtn.TabIndex = 6;
            this.feedsBtn.Text = "Modify Feeds";
            this.feedsBtn.UseVisualStyleBackColor = true;
            this.feedsBtn.Click += new System.EventHandler(this.feedsBtn_Click);
            // 
            // ModifyCategoriesBtn
            // 
            this.ModifyCategoriesBtn.Location = new System.Drawing.Point(1458, 605);
            this.ModifyCategoriesBtn.Name = "ModifyCategoriesBtn";
            this.ModifyCategoriesBtn.Size = new System.Drawing.Size(321, 68);
            this.ModifyCategoriesBtn.TabIndex = 7;
            this.ModifyCategoriesBtn.Text = "Modify Categories";
            this.ModifyCategoriesBtn.UseVisualStyleBackColor = true;
            this.ModifyCategoriesBtn.Click += new System.EventHandler(this.ModifyCategoriesBtn_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1888, 992);
            this.Controls.Add(this.ModifyCategoriesBtn);
            this.Controls.Add(this.feedsBtn);
            this.Controls.Add(this.categoryCombo);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Start";
            this.Text = "Podcast player";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox categoryCombo;
        private System.Windows.Forms.Button feedsBtn;
        private System.Windows.Forms.Button ModifyCategoriesBtn;
    }
}
