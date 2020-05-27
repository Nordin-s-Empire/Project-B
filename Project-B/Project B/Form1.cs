using Betaalscherm_versie_3;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            Profiel.Visible = false;
        }

        public void HideLoginbutton(bool flag)
        {
            this.btnAcount.Visible = flag;
            Profiel.Visible = !flag;
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            this.Hide();
            Programma program = new Programma();
            program.Show();
        }

        private void btnZoeken_Click(object sender, EventArgs e)
        {
            this.Hide();
            Zoeken zoek = new Zoeken();
            zoek.Show();
        }

        private void btnAcount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
            btnAcount.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(252, 167, 88);
            button2.BackColor = Color.DarkGray;
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Show();
            pictureBox6.Show();
            pictureBox7.Show();
            pictureBox8.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(252, 167, 88);
            button1.BackColor = Color.DarkGray;
            pictureBox1.Show();
            pictureBox2.Show();
            pictureBox3.Show();
            pictureBox4.Show();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
        }

        private void Profiel_Click(object sender, EventArgs e)
        {
            Profiel.Visible = false;
            btnAcount.Visible = true;
            MessageBox.Show("U bent uitgelogd", "uitloggen");
            Login log = new Login();
        }

        private void brnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Show();
        }

    }
}