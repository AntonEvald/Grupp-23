﻿namespace WindowsFormsApp1
{
    partial class MainPage
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
            this.Feeds = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Feeds
            // 
            this.Feeds.Location = new System.Drawing.Point(119, 27);
            this.Feeds.Name = "Feeds";
            this.Feeds.Size = new System.Drawing.Size(75, 23);
            this.Feeds.TabIndex = 0;
            this.Feeds.Text = "Feeds";
            this.Feeds.UseVisualStyleBackColor = true;
            this.Feeds.Click += new System.EventHandler(this.Feeds_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 242);
            this.Controls.Add(this.Feeds);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Feeds;
    }
}