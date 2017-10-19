namespace WindowsFormsApp1
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1160, 33);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Category";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(40, 43);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(671, 593);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // categoryCombo
            // 
            this.categoryCombo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.categoryCombo.FormattingEnabled = true;
            this.categoryCombo.Items.AddRange(new object[] {
            "Alla",
            "Komedi",
            "Drama",
            "Historia",
            "Musik"});
            this.categoryCombo.Location = new System.Drawing.Point(736, 43);
            this.categoryCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoryCombo.Name = "categoryCombo";
            this.categoryCombo.Size = new System.Drawing.Size(380, 39);
            this.categoryCombo.TabIndex = 3;
            this.categoryCombo.SelectedIndexChanged += new System.EventHandler(this.categoryCombo_SelectedIndexChanged);
            this.categoryCombo.Click += new System.EventHandler(this.categoryCombo_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(1160, 158);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(277, 66);
            this.removeBtn.TabIndex = 4;
            this.removeBtn.Text = "Remove Category";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // changeCatBtn
            // 
            this.changeCatBtn.Location = new System.Drawing.Point(1160, 280);
            this.changeCatBtn.Name = "changeCatBtn";
            this.changeCatBtn.Size = new System.Drawing.Size(277, 58);
            this.changeCatBtn.TabIndex = 5;
            this.changeCatBtn.Text = "Change Categories";
            this.changeCatBtn.UseVisualStyleBackColor = true;
            this.changeCatBtn.Click += new System.EventHandler(this.changeCatBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1637, 677);
            this.Controls.Add(this.changeCatBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.categoryCombo);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
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
    }
}

