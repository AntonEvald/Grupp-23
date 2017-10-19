namespace WindowsFormsApp1
{
    partial class RemoveCategory
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
            this.removeCombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // removeCombo
            // 
            this.removeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.removeCombo.FormattingEnabled = true;
            this.removeCombo.Location = new System.Drawing.Point(67, 250);
            this.removeCombo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.removeCombo.Name = "removeCombo";
            this.removeCombo.Size = new System.Drawing.Size(316, 39);
            this.removeCombo.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(525, 250);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RemoveCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 622);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.removeCombo);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "RemoveCategory";
            this.Text = "RemoveCategory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox removeCombo;
        private System.Windows.Forms.Button button1;
    }
}