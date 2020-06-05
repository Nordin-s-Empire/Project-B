using Betaalscherm_versie_3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_B
{
    public partial class Confirmatiescherm : Form
    {
        public Confirmatiescherm()
        {
            InitializeComponent();
            aantal.Text = "$" + (Reservatie.amount_of_reserved_seats * 11.0).ToString() + " ( $11.00 x " + Reservatie.amount_of_reserved_seats + " )";
            list_of_seats.Text = string.Join(", ", Reservatie.reserved_seats);

            if (Programma.form == 1)
            {
                pictureBox1.Image = Programma.pic;
                Film_info.Text = Programma.movie;
                lblTime2.Text = Programma.date;
            }
            else if(Form1.Form == true)
            {
                pictureBox1.Image = Form1.pic;
                Film_info.Text = Form1.Movie;
                lblTime2.Text = Form1.Time;
            }
            else
            {
                pictureBox1.Image = FIlmInfo.pic;
                Film_info.Text = FIlmInfo.movie_title;
            }

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reservatie reservatie = new Reservatie();
            reservatie.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Confirmatiescherm2 confirmatiescherm2 = new Confirmatiescherm2();
            confirmatiescherm2.Show();
        }
    }
}
