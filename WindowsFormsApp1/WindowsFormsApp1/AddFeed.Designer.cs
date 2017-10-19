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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.addFeedBtn = new System.Windows.Forms.Button();
            this.addFeedCategoryCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 0;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(13, 102);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(59, 13);
            this.urlLabel.TabIndex = 1;
            this.urlLabel.Text = "Feed URL:";
            // 
            // addFeedBtn
            // 
            this.addFeedBtn.Location = new System.Drawing.Point(255, 118);
            this.addFeedBtn.Name = "addFeedBtn";
            this.addFeedBtn.Size = new System.Drawing.Size(92, 23);
            this.addFeedBtn.TabIndex = 2;
            this.addFeedBtn.Text = "Add Feed";
            this.addFeedBtn.UseVisualStyleBackColor = true;
            // 
            // addFeedCategoryCB
            // 
            this.addFeedCategoryCB.FormattingEnabled = true;
            this.addFeedCategoryCB.Location = new System.Drawing.Point(12, 49);
            this.addFeedCategoryCB.Name = "addFeedCategoryCB";
            this.addFeedCategoryCB.Size = new System.Drawing.Size(121, 21);
            this.addFeedCategoryCB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Category";
            // 
            // AddFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 231);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addFeedCategoryCB);
            this.Controls.Add(this.addFeedBtn);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.textBox1);
            this.Name = "AddFeed";
            this.Text = "AddFeed";
            this.Load += new System.EventHandler(this.AddFeed_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Button addFeedBtn;
        private System.Windows.Forms.ComboBox addFeedCategoryCB;
        private System.Windows.Forms.Label label1;
    }
}