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
            this.SuspendLayout();
            // 
            // PickFeedCombo
            // 
            this.PickFeedCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PickFeedCombo.FormattingEnabled = true;
            this.PickFeedCombo.Location = new System.Drawing.Point(107, 106);
            this.PickFeedCombo.Name = "PickFeedCombo";
            this.PickFeedCombo.Size = new System.Drawing.Size(279, 39);
            this.PickFeedCombo.TabIndex = 0;
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.Location = new System.Drawing.Point(491, 278);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(293, 59);
            this.ChangeBtn.TabIndex = 2;
            this.ChangeBtn.Text = "Change";
            this.ChangeBtn.UseVisualStyleBackColor = true;
            // 
            // changeCatCombo
            // 
            this.changeCatCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.changeCatCombo.FormattingEnabled = true;
            this.changeCatCombo.Location = new System.Drawing.Point(107, 278);
            this.changeCatCombo.Name = "changeCatCombo";
            this.changeCatCombo.Size = new System.Drawing.Size(279, 39);
            this.changeCatCombo.TabIndex = 3;
            // 
            // ChangeFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 508);
            this.Controls.Add(this.changeCatCombo);
            this.Controls.Add(this.ChangeBtn);
            this.Controls.Add(this.PickFeedCombo);
            this.Name = "ChangeFeed";
            this.Text = "ChangeFeed";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox PickFeedCombo;
        private System.Windows.Forms.Button ChangeBtn;
        private System.Windows.Forms.ComboBox changeCatCombo;
    }
}