namespace WindowsFormsApp1
{
    partial class ChangeFeed
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
            this.PickFeedCombo = new System.Windows.Forms.ComboBox();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.changeCatCombo = new System.Windows.Forms.ComboBox();
            this.intervalCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PickFeedCombo
            // 
            this.PickFeedCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PickFeedCombo.FormattingEnabled = true;
            this.PickFeedCombo.Location = new System.Drawing.Point(107, 106);
            this.PickFeedCombo.Name = "PickFeedCombo";
            this.PickFeedCombo.Size = new System.Drawing.Size(519, 39);
            this.PickFeedCombo.TabIndex = 0;
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.Location = new System.Drawing.Point(875, 559);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(293, 59);
            this.ChangeBtn.TabIndex = 2;
            this.ChangeBtn.Text = "Change";
            this.ChangeBtn.UseVisualStyleBackColor = true;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // changeCatCombo
            // 
            this.changeCatCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.changeCatCombo.FormattingEnabled = true;
            this.changeCatCombo.Location = new System.Drawing.Point(107, 570);
            this.changeCatCombo.Name = "changeCatCombo";
            this.changeCatCombo.Size = new System.Drawing.Size(519, 39);
            this.changeCatCombo.TabIndex = 3;
            // 
            // intervalCombo
            // 
            this.intervalCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.intervalCombo.FormattingEnabled = true;
            this.intervalCombo.Items.AddRange(new object[] {
            "Every day",
            "Every week",
            "Every month"});
            this.intervalCombo.Location = new System.Drawing.Point(107, 370);
            this.intervalCombo.Name = "intervalCombo";
            this.intervalCombo.Size = new System.Drawing.Size(519, 39);
            this.intervalCombo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pick feed to change:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pick a new category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 532);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pick a new interval";
            // 
            // ChangeFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 768);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.intervalCombo);
            this.Controls.Add(this.changeCatCombo);
            this.Controls.Add(this.ChangeBtn);
            this.Controls.Add(this.PickFeedCombo);
            this.Name = "ChangeFeed";
            this.Text = "ChangeFeed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PickFeedCombo;
        private System.Windows.Forms.Button ChangeBtn;
        private System.Windows.Forms.ComboBox changeCatCombo;
        private System.Windows.Forms.ComboBox intervalCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}