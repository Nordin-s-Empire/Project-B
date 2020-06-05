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
                Film_info.Text = Programma.movie;
            }
            else
            {
                Film_info.Text = FIlmInfo.movie_title;
            }
            pictureBox1.Image = FIlmInfo.pic;
            lblTime2.Text = Programma.date;
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
