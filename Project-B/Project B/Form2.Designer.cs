namespace Project_B
{
    partial class Form2
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
            this.btnregistreer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbFNaam = new System.Windows.Forms.TextBox();
            this.txbLName = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbDOB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbAdres = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnregistreer
            // 
            this.btnregistreer.Location = new System.Drawing.Point(623, 262);
            this.btnregistreer.Name = "btnregistreer";
            this.btnregistreer.Size = new System.Drawing.Size(130, 53);
            this.btnregistreer.TabIndex = 0;
            this.btnregistreer.Text = "Registreer";
            this.btnregistreer.UseVisualStyleBackColor = true;
            this.btnregistreer.Click += new System.EventHandler(this.btnregistreer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Voornaam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Achternaam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Wachtwoord";
            // 
            // txbFNaam
            // 
            this.txbFNaam.Location = new System.Drawing.Point(338, 55);
            this.txbFNaam.Name = "txbFNaam";
            this.txbFNaam.Size = new System.Drawing.Size(100, 22);
            this.txbFNaam.TabIndex = 7;
            // 
            // txbLName
            // 
            this.txbLName.Location = new System.Drawing.Point(338, 96);
            this.txbLName.Name = "txbLName";
            this.txbLName.Size = new System.Drawing.Size(100, 22);
            this.txbLName.TabIndex = 8;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(338, 132);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(100, 22);
            this.txbEmail.TabIndex = 11;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(338, 210);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(100, 22);
            this.txbPassword.TabIndex = 12;
            // 
            // txbUsername
            // 
            this.txbUsername.Location = new System.Drawing.Point(338, 169);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(100, 22);
            this.txbUsername.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Geboortedatum";
            // 
            // txbDOB
            // 
            this.txbDOB.Location = new System.Drawing.Point(338, 246);
            this.txbDOB.Name = "txbDOB";
            this.txbDOB.Size = new System.Drawing.Size(100, 22);
            this.txbDOB.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Adres";
            // 
            // txbAdres
            // 
            this.txbAdres.Location = new System.Drawing.Point(338, 280);
            this.txbAdres.Name = "txbAdres";
            this.txbAdres.Size = new System.Drawing.Size(100, 22);
            this.txbAdres.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Terug";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 340);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbAdres);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbDOB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbLName);
            this.Controls.Add(this.txbFNaam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnregistreer);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnregistreer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbFNaam;
        private System.Windows.Forms.TextBox txbLName;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbDOB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbAdres;
        private System.Windows.Forms.Button button1;
    }
}