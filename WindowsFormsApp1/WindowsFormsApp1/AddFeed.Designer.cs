namespace WindowsFormsApp1
{
    partial class AddFeed
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
            this.urlTB = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.addFeedBtn = new System.Windows.Forms.Button();
            this.AddFeedCategoryCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddCategoryBtn = new System.Windows.Forms.Button();
            this.IntervallCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // urlTB
            // 
            this.urlTB.Location = new System.Drawing.Point(32, 241);
            this.urlTB.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.urlTB.Name = "urlTB";
            this.urlTB.Size = new System.Drawing.Size(561, 38);
            this.urlTB.TabIndex = 0;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(32, 203);
            this.urlLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(151, 32);
            this.urlLabel.TabIndex = 1;
            this.urlLabel.Text = "Feed URL:";
            // 
            // addFeedBtn
            // 
            this.addFeedBtn.Location = new System.Drawing.Point(680, 362);
            this.addFeedBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.addFeedBtn.Name = "addFeedBtn";
            this.addFeedBtn.Size = new System.Drawing.Size(245, 55);
            this.addFeedBtn.TabIndex = 2;
            this.addFeedBtn.Text = "Add Feed";
            this.addFeedBtn.UseVisualStyleBackColor = true;
            this.addFeedBtn.Click += new System.EventHandler(this.addFeedBtn_Click_1);
            // 
            // AddFeedCategoryCB
            // 
            this.AddFeedCategoryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddFeedCategoryCB.FormattingEnabled = true;
            this.AddFeedCategoryCB.Location = new System.Drawing.Point(32, 117);
            this.AddFeedCategoryCB.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.AddFeedCategoryCB.Name = "AddFeedCategoryCB";
            this.AddFeedCategoryCB.Size = new System.Drawing.Size(316, 39);
            this.AddFeedCategoryCB.TabIndex = 0;
            this.AddFeedCategoryCB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddFeedCategoryCB_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Category";
            // 
            // AddCategoryBtn
            // 
            this.AddCategoryBtn.Location = new System.Drawing.Point(680, 100);
            this.AddCategoryBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddCategoryBtn.Name = "AddCategoryBtn";
            this.AddCategoryBtn.Size = new System.Drawing.Size(245, 55);
            this.AddCategoryBtn.TabIndex = 5;
            this.AddCategoryBtn.Text = "Add Category";
            this.AddCategoryBtn.UseVisualStyleBackColor = true;
            this.AddCategoryBtn.Click += new System.EventHandler(this.addCategoryBtn_Click);
            // 
            // IntervallCb
            // 
            this.IntervallCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IntervallCb.FormattingEnabled = true;
            this.IntervallCb.Items.AddRange(new object[] {
            "Every day",
            "Every week",
            "Every month"});
            this.IntervallCb.Location = new System.Drawing.Point(32, 362);
            this.IntervallCb.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.IntervallCb.Name = "IntervallCb";
            this.IntervallCb.Size = new System.Drawing.Size(316, 39);
            this.IntervallCb.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 324);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Intervall:";
            // 
            // AddFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 551);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IntervallCb);
            this.Controls.Add(this.AddCategoryBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddFeedCategoryCB);
            this.Controls.Add(this.addFeedBtn);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.urlTB);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "AddFeed";
            this.Text = "AddFeed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlTB;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Button addFeedBtn;
        private System.Windows.Forms.ComboBox AddFeedCategoryCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddCategoryBtn;
        private System.Windows.Forms.ComboBox IntervallCb;
        private System.Windows.Forms.Label label2;
    }
}