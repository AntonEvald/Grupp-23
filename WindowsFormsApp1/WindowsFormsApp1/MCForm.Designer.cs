namespace WindowsFormsApp1
{
    partial class MCForm
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
            this.AddCatBtn = new System.Windows.Forms.Button();
            this.ChangeCatBtn = new System.Windows.Forms.Button();
            this.RemoveCatBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddCatBtn
            // 
            this.AddCatBtn.Location = new System.Drawing.Point(158, 78);
            this.AddCatBtn.Name = "AddCatBtn";
            this.AddCatBtn.Size = new System.Drawing.Size(327, 99);
            this.AddCatBtn.TabIndex = 0;
            this.AddCatBtn.Text = "Add Category";
            this.AddCatBtn.UseVisualStyleBackColor = true;
            this.AddCatBtn.Click += new System.EventHandler(this.AddCatBtn_Click);
            // 
            // ChangeCatBtn
            // 
            this.ChangeCatBtn.Location = new System.Drawing.Point(158, 216);
            this.ChangeCatBtn.Name = "ChangeCatBtn";
            this.ChangeCatBtn.Size = new System.Drawing.Size(327, 99);
            this.ChangeCatBtn.TabIndex = 1;
            this.ChangeCatBtn.Text = "Change Category";
            this.ChangeCatBtn.UseVisualStyleBackColor = true;
            this.ChangeCatBtn.Click += new System.EventHandler(this.ChangeCatBtn_Click);
            // 
            // RemoveCatBtn
            // 
            this.RemoveCatBtn.Location = new System.Drawing.Point(158, 359);
            this.RemoveCatBtn.Name = "RemoveCatBtn";
            this.RemoveCatBtn.Size = new System.Drawing.Size(327, 95);
            this.RemoveCatBtn.TabIndex = 2;
            this.RemoveCatBtn.Text = "Remove Category";
            this.RemoveCatBtn.UseVisualStyleBackColor = true;
            this.RemoveCatBtn.Click += new System.EventHandler(this.RemoveCatBtn_Click);
            // 
            // MCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 506);
            this.Controls.Add(this.RemoveCatBtn);
            this.Controls.Add(this.ChangeCatBtn);
            this.Controls.Add(this.AddCatBtn);
            this.Name = "MCForm";
            this.Text = "Modify Categories";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddCatBtn;
        private System.Windows.Forms.Button ChangeCatBtn;
        private System.Windows.Forms.Button RemoveCatBtn;
    }
}