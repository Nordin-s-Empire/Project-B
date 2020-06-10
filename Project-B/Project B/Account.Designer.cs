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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uitloggen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Menuknopacc
            // 
            this.Menuknopacc.Location = new System.Drawing.Point(45, 37);
            this.Menuknopacc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Menuknopacc.Name = "Menuknopacc";
            this.Menuknopacc.Size = new System.Drawing.Size(105, 38);
            this.Menuknopacc.TabIndex = 0;
            this.Menuknopacc.Text = "Terug";
            this.Menuknopacc.UseVisualStyleBackColor = true;
            this.Menuknopacc.Click += new System.EventHandler(this.Menuknopacc_Click);
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
            this.textBox1.Location = new System.Drawing.Point(343, 130);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(343, 199);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 22);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(343, 270);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 22);
            this.textBox3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email adres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Geboortedatum";
            // 
            // uitloggen
            // 
            this.uitloggen.Location = new System.Drawing.Point(415, 420);
            this.uitloggen.Name = "uitloggen";
            this.uitloggen.Size = new System.Drawing.Size(121, 41);
            this.uitloggen.TabIndex = 9;
            this.uitloggen.Text = "Uitloggen";
            this.uitloggen.UseVisualStyleBackColor = true;
            this.uitloggen.Click += new System.EventHandler(this.uitloggen_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(600, 505);
            this.Controls.Add(this.uitloggen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Loginname);
            this.Controls.Add(this.Menuknopacc);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Account";
            this.Text = "Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button Menuknopacc;
        private System.Windows.Forms.Label Loginname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button uitloggen;
    }
}