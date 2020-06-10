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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Betaalscherm));
            this.lblBank = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Payl = new System.Windows.Forms.Label();
            this.lbliDeal = new System.Windows.Forms.Label();
            this.lblMastercard = new System.Windows.Forms.Label();
            this.lblPayPal = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pbxIDeal = new System.Windows.Forms.PictureBox();
            this.pbxMastercard = new System.Windows.Forms.PictureBox();
            this.pbxPayPal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIDeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMastercard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPayPal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBank.Location = new System.Drawing.Point(349, 101);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(52, 24);
            this.lblBank.TabIndex = 8;
            this.lblBank.Text = "Bank";
            this.lblBank.Click += new System.EventHandler(this.label8_Click);
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
            this.listBox2.Location = new System.Drawing.Point(353, 145);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(140, 116);
            this.listBox2.TabIndex = 9;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(373, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Afrekenen";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // lbliDeal
            // 
            this.lbliDeal.AutoSize = true;
            this.lbliDeal.ForeColor = System.Drawing.SystemColors.Control;
            this.lbliDeal.Location = new System.Drawing.Point(128, 112);
            this.lbliDeal.Name = "lbliDeal";
            this.lbliDeal.Size = new System.Drawing.Size(52, 24);
            this.lbliDeal.TabIndex = 21;
            this.lbliDeal.Text = "iDeal";
            this.lbliDeal.Click += new System.EventHandler(this.lbliDeal_Click);
            // 
            // lblMastercard
            // 
            this.lblMastercard.AutoSize = true;
            this.lblMastercard.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMastercard.Location = new System.Drawing.Point(128, 179);
            this.lblMastercard.Name = "lblMastercard";
            this.lblMastercard.Size = new System.Drawing.Size(103, 24);
            this.lblMastercard.TabIndex = 22;
            this.lblMastercard.Text = "Mastercard";
            this.lblMastercard.Click += new System.EventHandler(this.lblMastercard_Click);
            // 
            // lblPayPal
            // 
            this.lblPayPal.AutoSize = true;
            this.lblPayPal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPayPal.Location = new System.Drawing.Point(128, 249);
            this.lblPayPal.Name = "lblPayPal";
            this.lblPayPal.Size = new System.Drawing.Size(67, 24);
            this.lblPayPal.TabIndex = 23;
            this.lblPayPal.Text = "PayPal";
            this.lblPayPal.Click += new System.EventHandler(this.lblPayPal_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Gray;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(41, 368);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 38);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pbxIDeal
            // 
            this.pbxIDeal.Image = ((System.Drawing.Image)(resources.GetObject("pbxIDeal.Image")));
            this.pbxIDeal.Location = new System.Drawing.Point(45, 89);
            this.pbxIDeal.Name = "pbxIDeal";
            this.pbxIDeal.Size = new System.Drawing.Size(64, 56);
            this.pbxIDeal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxIDeal.TabIndex = 25;
            this.pbxIDeal.TabStop = false;
            this.pbxIDeal.Click += new System.EventHandler(this.pbxIDeal_Click);
            // 
            // pbxMastercard
            // 
            this.pbxMastercard.Image = ((System.Drawing.Image)(resources.GetObject("pbxMastercard.Image")));
            this.pbxMastercard.Location = new System.Drawing.Point(45, 160);
            this.pbxMastercard.Name = "pbxMastercard";
            this.pbxMastercard.Size = new System.Drawing.Size(64, 54);
            this.pbxMastercard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMastercard.TabIndex = 26;
            this.pbxMastercard.TabStop = false;
            this.pbxMastercard.Click += new System.EventHandler(this.pbxMastercard_Click);
            // 
            // pbxPayPal
            // 
            this.pbxPayPal.Image = ((System.Drawing.Image)(resources.GetObject("pbxPayPal.Image")));
            this.pbxPayPal.Location = new System.Drawing.Point(46, 231);
            this.pbxPayPal.Name = "pbxPayPal";
            this.pbxPayPal.Size = new System.Drawing.Size(63, 54);
            this.pbxPayPal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPayPal.TabIndex = 27;
            this.pbxPayPal.TabStop = false;
            this.pbxPayPal.Click += new System.EventHandler(this.pbxPayPal_Click);
            // 
            // Betaalscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(523, 432);
            this.Controls.Add(this.pbxPayPal);
            this.Controls.Add(this.pbxMastercard);
            this.Controls.Add(this.pbxIDeal);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPayPal);
            this.Controls.Add(this.lblMastercard);
            this.Controls.Add(this.lbliDeal);
            this.Controls.Add(this.Payl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.lblBank);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Betaalscherm";
            this.Text = "Betaalscherm";
            this.Load += new System.EventHandler(this.Betaalscherm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxIDeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMastercard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPayPal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Payl;
        private System.Windows.Forms.Label lbliDeal;
        private System.Windows.Forms.Label lblMastercard;
        private System.Windows.Forms.Label lblPayPal;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pbxIDeal;
        private System.Windows.Forms.PictureBox pbxMastercard;
        private System.Windows.Forms.PictureBox pbxPayPal;
    }
}

