namespace Project_B
{
    partial class StoelenReservatie
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
            this.seatA1 = new System.Windows.Forms.Button();
            this.seatA2 = new System.Windows.Forms.Button();
            this.seatA3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // seatA1
            // 
            this.seatA1.Location = new System.Drawing.Point(258, 174);
            this.seatA1.Name = "seatA1";
            this.seatA1.Size = new System.Drawing.Size(58, 57);
            this.seatA1.TabIndex = 0;
            this.seatA1.UseVisualStyleBackColor = true;
            this.seatA1.Click += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // seatA2
            // 
            this.seatA2.Location = new System.Drawing.Point(380, 174);
            this.seatA2.Name = "seatA2";
            this.seatA2.Size = new System.Drawing.Size(58, 57);
            this.seatA2.TabIndex = 1;
            this.seatA2.UseVisualStyleBackColor = true;
            this.seatA2.Click += new System.EventHandler(this.seatA2_Click);
            // 
            // seatA3
            // 
            this.seatA3.Location = new System.Drawing.Point(500, 174);
            this.seatA3.Name = "seatA3";
            this.seatA3.Size = new System.Drawing.Size(58, 57);
            this.seatA3.TabIndex = 2;
            this.seatA3.UseVisualStyleBackColor = true;
            this.seatA3.Click += new System.EventHandler(this.seatA3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(240, 307);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(366, 22);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // StoelenReservatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.seatA3);
            this.Controls.Add(this.seatA2);
            this.Controls.Add(this.seatA1);
            this.Name = "StoelenReservatie";
            this.Text = "StoelenReservatie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button seatA1;
        private System.Windows.Forms.Button seatA2;
        private System.Windows.Forms.Button seatA3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}