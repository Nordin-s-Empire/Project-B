using Project_B;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Betaalscherm_versie_3
{
    public partial class Betaalscherm : Form
    {
        public Betaalscherm()
        {
            InitializeComponent();
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label8.Text = "Bank";
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listbox2 = new ListBox();
            listbox2.Name = "ListBox1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbliDeal.ForeColor == Color.FromArgb(252, 167, 88))
            {
                if (listBox2.SelectedIndex >= 0)
                {
                    MessageBox.Show("Bedankt voor uw betaling met iDeal. Uw tickets worden verzonden naar uw e-mail adres: " + Confirmatiescherm2.email + ". Alvast een fijne voorstelling!");
                    this.Hide();
                    Form1 startscherm = new Form1();
                    startscherm.Show();
                }
                else
                {
                    MessageBox.Show("U heeft geen bank gekozen. Kies aub een bank.");
                }
            }

            else if (lblMastercard.ForeColor == Color.FromArgb(252, 167, 88))
            {
                MessageBox.Show("Bedankt voor uw betaling met Mastercard. Uw tickets worden verzonden naar uw e-mail adres: " + Confirmatiescherm2.email + ". Alvast een fijne voorstelling!");
                this.Hide();
                Form1 startscherm = new Form1();
                startscherm.Show();
            }
            
            else if (lblPayPal.ForeColor == Color.FromArgb(252, 167, 88))
            {
                MessageBox.Show("Bedankt voor uw betaling met PayPal. Uw tickets worden verzonden naar uw e-mail adres: " + Confirmatiescherm2.email + ". Alvast een fijne voorstelling!");
                this.Hide();
                Form1 startscherm = new Form1();
                startscherm.Show();
            }

            else
            {
                MessageBox.Show("U heeft geen betalingsmethode gekozen. Kies aub hoe u wilt betalen voor uw tickets.");

            }
            
            
        }

        private void Betaalscherm_Load(object sender, EventArgs e)
        {
            listBox2.Hide();
        }

        private void lblMastercard_Click(object sender, EventArgs e)
        {
            lblMastercard.ForeColor = Color.FromArgb(252, 167, 88);
            lblPayPal.ForeColor = Color.White;
            lbliDeal.ForeColor = Color.White;
            listBox2.Hide();
        }

        private void lblPayPal_Click(object sender, EventArgs e)
        {
            lblPayPal.ForeColor = Color.FromArgb(252, 167, 88);
            lblMastercard.ForeColor = Color.White;
            lbliDeal.ForeColor = Color.White;
            listBox2.Hide();
        }

        private void lbliDeal_Click(object sender, EventArgs e)
        {
            lbliDeal.ForeColor = Color.FromArgb(252, 167, 88);
            lblPayPal.ForeColor = Color.White;
            lblMastercard.ForeColor = Color.White;
            listBox2.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Confirmatiescherm2 confirmatiescherm2 = new Confirmatiescherm2();
            confirmatiescherm2.Show();
        }
    }
}
