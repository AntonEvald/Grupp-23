namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.categoryCombo = new System.Windows.Forms.ComboBox();
            this.removeBtn = new System.Windows.Forms.Button();
            this.changeCatBtn = new System.Windows.Forms.Button();
            this.feedsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Category";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(4, 9);
            this.listBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(254, 251);
            this.listBox1.TabIndex = 1;
            // 
            // categoryCombo
            // 
            this.categoryCombo.BackColor = System.Drawing.SystemColors.Control;
            this.categoryCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryCombo.FormattingEnabled = true;
            this.categoryCombo.Items.AddRange(new object[] {
            "All"});
            this.categoryCombo.Location = new System.Drawing.Point(276, 18);
            this.categoryCombo.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.categoryCombo.MaxDropDownItems = 10;
            this.categoryCombo.Name = "categoryCombo";
            this.categoryCombo.Size = new System.Drawing.Size(145, 21);
            this.categoryCombo.TabIndex = 3;
            this.categoryCombo.Click += new System.EventHandler(this.categoryCombo_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(435, 66);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(104, 28);
            this.removeBtn.TabIndex = 4;
            this.removeBtn.Text = "Remove Category";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // changeCatBtn
            // 
            this.changeCatBtn.Location = new System.Drawing.Point(435, 117);
            this.changeCatBtn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.changeCatBtn.Name = "changeCatBtn";
            this.changeCatBtn.Size = new System.Drawing.Size(104, 24);
            this.changeCatBtn.TabIndex = 5;
            this.changeCatBtn.Text = "Change Categories";
            this.changeCatBtn.UseVisualStyleBackColor = true;
            this.changeCatBtn.Click += new System.EventHandler(this.changeCatBtn_Click);
            // 
            // feedsBtn
            // 
            this.feedsBtn.Location = new System.Drawing.Point(435, 172);
            this.feedsBtn.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.feedsBtn.Name = "feedsBtn";
            this.feedsBtn.Size = new System.Drawing.Size(104, 27);
            this.feedsBtn.TabIndex = 6;
            this.feedsBtn.Text = "Modify Feeds";
            this.feedsBtn.UseVisualStyleBackColor = true;
            this.feedsBtn.Click += new System.EventHandler(this.feedsBtn_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(568, 307);
            this.Controls.Add(this.feedsBtn);
            this.Controls.Add(this.changeCatBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.categoryCombo);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Start";
            this.Text = "Podcast player";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox categoryCombo;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button changeCatBtn;
        private System.Windows.Forms.Button feedsBtn;
    }
}

