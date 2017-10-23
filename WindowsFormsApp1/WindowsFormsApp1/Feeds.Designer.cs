namespace WindowsFormsApp1
{
    partial class Feeds
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
            this.addFeedBtn = new System.Windows.Forms.Button();
            this.removeFeedBtn = new System.Windows.Forms.Button();
            this.alterFeed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addFeedBtn
            // 
            this.addFeedBtn.Location = new System.Drawing.Point(915, 148);
            this.addFeedBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.addFeedBtn.Name = "addFeedBtn";
            this.addFeedBtn.Size = new System.Drawing.Size(243, 55);
            this.addFeedBtn.TabIndex = 0;
            this.addFeedBtn.Text = "Add Feed";
            this.addFeedBtn.UseVisualStyleBackColor = true;
            this.addFeedBtn.Click += new System.EventHandler(this.addFeedBtn_Click);
            // 
            // removeFeedBtn
            // 
            this.removeFeedBtn.Location = new System.Drawing.Point(915, 279);
            this.removeFeedBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.removeFeedBtn.Name = "removeFeedBtn";
            this.removeFeedBtn.Size = new System.Drawing.Size(243, 55);
            this.removeFeedBtn.TabIndex = 1;
            this.removeFeedBtn.Text = "Remove Feed";
            this.removeFeedBtn.UseVisualStyleBackColor = true;
            this.removeFeedBtn.Click += new System.EventHandler(this.removeFeedBtn_Click);
            // 
            // alterFeed
            // 
            this.alterFeed.Location = new System.Drawing.Point(915, 401);
            this.alterFeed.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.alterFeed.Name = "alterFeed";
            this.alterFeed.Size = new System.Drawing.Size(243, 55);
            this.alterFeed.TabIndex = 2;
            this.alterFeed.Text = "Alter Feed";
            this.alterFeed.UseVisualStyleBackColor = true;
            // 
            // Feeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 622);
            this.Controls.Add(this.alterFeed);
            this.Controls.Add(this.removeFeedBtn);
            this.Controls.Add(this.addFeedBtn);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Feeds";
            this.Text = "Feeds";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addFeedBtn;
        private System.Windows.Forms.Button removeFeedBtn;
        private System.Windows.Forms.Button alterFeed;
    }
}