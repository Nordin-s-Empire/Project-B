﻿namespace Project_B
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
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(600, 504);
            this.Controls.Add(this.Menuknopacc);
            this.Name = "Account";
            this.Text = "Account";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Menuknopacc;
    }
}