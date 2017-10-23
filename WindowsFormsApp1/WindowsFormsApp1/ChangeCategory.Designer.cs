namespace WindowsFormsApp1
{
    partial class ChangeCategory
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
            this.changeCombo = new System.Windows.Forms.ComboBox();
            this.changeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangeToField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // changeCombo
            // 
            this.changeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.changeCombo.FormattingEnabled = true;
            this.changeCombo.Location = new System.Drawing.Point(165, 100);
            this.changeCombo.Name = "changeCombo";
            this.changeCombo.Size = new System.Drawing.Size(337, 39);
            this.changeCombo.TabIndex = 0;
            this.changeCombo.SelectedIndexChanged += new System.EventHandler(this.changeCombo_SelectedIndexChanged);
            // 
            // changeBtn
            // 
            this.changeBtn.Location = new System.Drawing.Point(693, 312);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(203, 65);
            this.changeBtn.TabIndex = 1;
            this.changeBtn.Text = "Change";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Change to:";
            // 
            // ChangeToField
            // 
            this.ChangeToField.Location = new System.Drawing.Point(165, 324);
            this.ChangeToField.Name = "ChangeToField";
            this.ChangeToField.Size = new System.Drawing.Size(337, 38);
            this.ChangeToField.TabIndex = 3;
            this.ChangeToField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ChangeCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 578);
            this.Controls.Add(this.ChangeToField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.changeCombo);
            this.Name = "ChangeCategory";
            this.Text = "ChangeCategory";
            this.Load += new System.EventHandler(this.ChangeCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox changeCombo;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ChangeToField;
    }
}