using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_B
{
    public partial class Form1 : Form
    {
        public static string Movie;
        public static bool Form = false;
        public static Image pic;
        public static string Time;

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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form = true;
            Movie = "The Lord of the rings the two towers";
            pic = this.pictureBox5.Image;
            Time = "Zaal 5: 10:30";
            this.Hide();
            Reservatie reservatie = new Reservatie();
            reservatie.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form = true;
            Movie = "Joker";
            pic = this.pictureBox1.Image;
            Time = "Zaal 9: 14:20";
            this.Hide();
            Reservatie reservatie = new Reservatie();
            reservatie.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form = true;
            Movie = "Fight Club";
            pic = this.pictureBox6.Image;
            Time = "Zaal 1: 13:00";
            this.Hide();
            Reservatie reservatie = new Reservatie();
            reservatie.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form = true;
            Movie = "Interstellar";
            pic = this.pictureBox2.Image;
            Time = "Zaal 3: 9:00";
            this.Hide();
            Reservatie reservatie = new Reservatie();
            reservatie.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form = true;
            Movie = "IO";
            pic = this.pictureBox7.Image;
            Time = "Zaal 6: 11:00";
            this.Hide();
            Reservatie reservatie = new Reservatie();
            reservatie.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form = true;
            Movie = "The Dark Kinght Rises";
            pic = this.pictureBox3.Image;
            Time = "Zaal 12: 15:00";
            this.Hide();
            Reservatie reservatie = new Reservatie();
            reservatie.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form = true;
            Movie = "Wildlife";
            pic = this.pictureBox8.Image;
            Time = "Zaal 10: 16:00";
            this.Hide();
            Reservatie reservatie = new Reservatie();
            reservatie.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form = true;
            Movie = "The Godfather";
            pic = this.pictureBox4.Image;
            Time = "Zaal 8: 20:00";
            this.Hide();
            Reservatie reservatie = new Reservatie();
            reservatie.Show();
        }
    }
}