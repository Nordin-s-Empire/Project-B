namespace Project_B
{
    partial class Account
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
            this.Menuknopacc = new System.Windows.Forms.Button();
            this.Loginname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Menuknopacc
            // 
            this.Menuknopacc.Location = new System.Drawing.Point(45, 37);
            this.Menuknopacc.Name = "Menuknopacc";
            this.Menuknopacc.Size = new System.Drawing.Size(105, 38);
            this.Menuknopacc.TabIndex = 0;
            this.Menuknopacc.Text = "Menu";
            this.Menuknopacc.UseVisualStyleBackColor = true;
            this.Menuknopacc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AcctoMain);
            // 
            // Loginname
            // 
            this.Loginname.AutoSize = true;
            this.Loginname.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Loginname.Location = new System.Drawing.Point(196, 57);
            this.Loginname.Name = "Loginname";
            this.Loginname.Size = new System.Drawing.Size(0, 17);
            this.Loginname.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(277, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(600, 504);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Loginname);
            this.Controls.Add(this.Menuknopacc);
            this.Name = "Account";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Menuknopacc;
        private System.Windows.Forms.Label Loginname;
        private System.Windows.Forms.TextBox textBox1;
    }
}