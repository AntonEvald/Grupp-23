namespace WindowsFormsApp1
{
    partial class RemoveFeed
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
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.removeCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(577, 235);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(335, 133);
            this.RemoveBtn.TabIndex = 1;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // removeCombo
            // 
            this.removeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.removeCombo.FormattingEnabled = true;
            this.removeCombo.Location = new System.Drawing.Point(30, 149);
            this.removeCombo.Name = "removeCombo";
            this.removeCombo.Size = new System.Drawing.Size(425, 39);
            this.removeCombo.TabIndex = 0;
            // 
            // RemoveFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 542);
            this.Controls.Add(this.removeCombo);
            this.Controls.Add(this.RemoveBtn);
            this.Name = "RemoveFeed";
            this.Text = "RemoveFeed";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.ComboBox removeCombo;
    }
}