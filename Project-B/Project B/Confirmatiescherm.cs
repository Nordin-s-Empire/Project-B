using System;
using System.Windows.Forms;

namespace Project_B
{
    public partial class Confirmatiescherm : Form
    {
        private Random gen = new Random();

        public Confirmatiescherm()
        {
            InitializeComponent();
            aantal.Text = "$" + (Reservatie.amount_of_reserved_seats * 11.0).ToString() + " ( $11.00 x " + Reservatie.amount_of_reserved_seats + " )";
            list_of_seats.Text = string.Join(", ", Reservatie.reserved_seats);
            lblAmountOfPeople2.Text = Reservatie.amount_of_reserved_seats.ToString();

            if (Programma.form == 1)
            {
                pictureBox1.Image = Programma.pic;
                Film_info.Text = Programma.movie;
                lblTime2.Text = Programma.date;
            }
            else if (Form1.Form == true)
            {
                pictureBox1.Image = Form1.pic;
                Film_info.Text = Form1.Movie;
                lblTime2.Text = Form1.Time;
            }
            else
            {
                pictureBox1.Image = FIlmInfo.pic;
                Film_info.Text = FIlmInfo.movie_title;
                lblTime2.Text = FIlmInfo.Date;
            }

            if(String.IsNullOrEmpty(lblTime2.Text))
            {
                lblTime2.Text = RandomDay().ToString();
            }

            DateTime RandomDay()
            {
                DateTime start = new DateTime(1995, 1, 1);
                int range = (DateTime.Today - start).Days;
                return start.AddDays(gen.Next(range));
            }

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
