namespace Betaalscherm_versie_3
{
    partial class Betaalscherm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.aantal = new System.Windows.Forms.Label();
            this.list_of_seats = new System.Windows.Forms.Label();
            this.Film_label = new System.Windows.Forms.Label();
            this.Film_naam = new System.Windows.Forms.Label();
            this.Seats = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Payl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(282, 295);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prijs";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(656, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Bank";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Items.AddRange(new object[] {
            "ABN AMRO.",
            "Rabobank.",
            "ING.",
            "bunq.",
            "SNS Bank.",
            "ASN Bank.",
            "Triodos."});
            this.listBox2.Location = new System.Drawing.Point(660, 133);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(140, 180);
            this.listBox2.TabIndex = 9;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(680, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Afrekenen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aantal
            // 
            this.aantal.AutoSize = true;
            this.aantal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(167)))), ((int)(((byte)(88)))));
            this.aantal.Location = new System.Drawing.Point(348, 295);
            this.aantal.Name = "aantal";
            this.aantal.Size = new System.Drawing.Size(225, 24);
            this.aantal.TabIndex = 14;
            this.aantal.Text = "Hier komt de prijs te staan";
            // 
            // list_of_seats
            // 
            this.list_of_seats.AutoSize = true;
            this.list_of_seats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(167)))), ((int)(((byte)(88)))));
            this.list_of_seats.Location = new System.Drawing.Point(282, 239);
            this.list_of_seats.Name = "list_of_seats";
            this.list_of_seats.Size = new System.Drawing.Size(270, 24);
            this.list_of_seats.TabIndex = 15;
            this.list_of_seats.Text = "Hier komen de stoelen te staan";
            this.list_of_seats.Click += new System.EventHandler(this.list_of_seats_Click);
            // 
            // Film_label
            // 
            this.Film_label.AutoSize = true;
            this.Film_label.ForeColor = System.Drawing.SystemColors.Control;
            this.Film_label.Location = new System.Drawing.Point(282, 81);
            this.Film_label.Name = "Film_label";
            this.Film_label.Size = new System.Drawing.Size(148, 24);
            this.Film_label.TabIndex = 16;
            this.Film_label.Text = "Uw gekozen film";
            // 
            // Film_naam
            // 
            this.Film_naam.AutoSize = true;
            this.Film_naam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(167)))), ((int)(((byte)(88)))));
            this.Film_naam.Location = new System.Drawing.Point(282, 133);
            this.Film_naam.Name = "Film_naam";
            this.Film_naam.Size = new System.Drawing.Size(271, 24);
            this.Film_naam.TabIndex = 17;
            this.Film_naam.Text = "Hier komt de film naam te staan";
            // 
            // Seats
            // 
            this.Seats.AutoSize = true;
            this.Seats.ForeColor = System.Drawing.SystemColors.Control;
            this.Seats.Location = new System.Drawing.Point(282, 191);
            this.Seats.Name = "Seats";
            this.Seats.Size = new System.Drawing.Size(103, 24);
            this.Seats.TabIndex = 18;
            this.Seats.Text = "Uw stoelen";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(34, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 286);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Payl
            // 
            this.Payl.AutoSize = true;
            this.Payl.ForeColor = System.Drawing.SystemColors.Control;
            this.Payl.Location = new System.Drawing.Point(40, 20);
            this.Payl.Name = "Payl";
            this.Payl.Size = new System.Drawing.Size(189, 24);
            this.Payl.TabIndex = 20;
            this.Payl.Text = "Betaal voor uw tickets";
            // 
            // Betaalscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(863, 412);
            this.Controls.Add(this.Payl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Seats);
            this.Controls.Add(this.Film_naam);
            this.Controls.Add(this.Film_label);
            this.Controls.Add(this.list_of_seats);
            this.Controls.Add(this.aantal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Betaalscherm";
            this.Text = "Betaalscherm";
            this.Load += new System.EventHandler(this.Betaalscherm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label aantal;
        private System.Windows.Forms.Label list_of_seats;
        private System.Windows.Forms.Label Film_label;
        private System.Windows.Forms.Label Film_naam;
        private System.Windows.Forms.Label Seats;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Payl;
    }
}

