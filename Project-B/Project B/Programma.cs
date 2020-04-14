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
    public partial class Programma : Form
    {
        public Programma()
        {
            InitializeComponent();
            DateTime dt = DateTime.Today;

            if (dt.DayOfWeek == DayOfWeek.Monday)
            {
                pictureBox1.Image = Properties.Resources._51Av5azGomL__AC_;
                richTextBox1.Text = "Title: The Dark Kinght Rises \nLeeftijd: 16+ \nDuur 1:30:00 uur. \nStart tijd: zaal 3 15:00, zaal 8 16:00\nTaal: Engels (NL ondertiteling).\nzigtbaar: IMAX, 3D, 2D.";
            }
            else if (dt.DayOfWeek == DayOfWeek.Tuesday)
            {
                pictureBox1.Image = Properties.Resources._81kz06oSUeL__AC_SL1500_;
                richTextBox1.Text = "Title: Interstellar \nLeeftijd: 11+ \nDuur 1:25:00 uur. \nStart tijd: zaal 7 12:00, zaal 15 15:00\nTaal: Engels (NL ondertiteling).\nzigtbaar: IMAX, 3D, 2D.";
            }
            else if (dt.DayOfWeek == DayOfWeek.Wednesday)
            {
                pictureBox1.Image = Properties.Resources._268x0w;
                richTextBox1.Text = "Title: Joker \nLeeftijd: 18+ \nDuur 1:35:00 uur. \nStart tijd: zaal 1 10:00, zaal 2 11:00, zaal 3 12:00, zaal 4 13:00\nTaal: Engels (EN ondertiteling).\nzigtbaar: IMAX, 3D, 2D.";
            }
            else if (dt.DayOfWeek == DayOfWeek.Thursday)
            {
                pictureBox1.Image = Properties.Resources.avengers_endgame_original_movie_poster_15x21_in_2019_anthony_russo_robert_downey_jr;
                richTextBox1.Text = "Title: Avengers Endgame \nLeeftijd: 12+ \nDuur 2:05:00 uur. \nStart tijd: zaal 5 10:00, zaal 6 11:00, zaal 7 12:00, zaal 4 13:00\nTaal: Engels (EN ondertiteling).\nzigtbaar: IMAX, 3D, 2D.";
            }
            else if (dt.DayOfWeek == DayOfWeek.Friday)
            {
                pictureBox1.Image = Properties.Resources.MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM___V1_;
                richTextBox1.Text = "Title: The Godfather \nLeeftijd: 18+ \nDuur 1:25:00 uur. \nStart tijd: zaal 5 17:00, zaal 6 19:00, zaal 4 21:00\nTaal: Engels.\nzigtbaar: IMAX, 2D.";
            }
            else if (dt.DayOfWeek == DayOfWeek.Saturday)
            {
                pictureBox1.Image = Properties.Resources.THE_LORD_OF_THE_RINGS_THE_TWO_TOWERS_Frodo_Reprint_2002_REPRINT_CINEMA_POSTER__74417_1534256853;
                richTextBox1.Text = "Title: The Lord of the rings the two towers  \nLeeftijd: 14+ \nDuur 3:25:00 uur. \nStart tijd: zaal 1 12:00, zaal 2 13:00, zaal 3 14:00\nTaal: Engels.\nzigtbaar: IMAX, 2D.";
            }
            else if (dt.DayOfWeek == DayOfWeek.Sunday)
            {
                pictureBox1.Image = Properties.Resources.baaf0f0f37c294c779ed9d52896e9d52;
                richTextBox1.Text = "Title: The Lord of the rings fellowschip of the ring  \nLeeftijd: 14+ \nDuur 3:25:00 uur. \nStart tijd: zaal 1 12:00, zaal 2 13:00, zaal 3 14:00\nTaal: Engels.\nzigtbaar: IMAX, 2D.";
            }
        }

        private void btnMaandag_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._51Av5azGomL__AC_;
            richTextBox1.Text = "Title: The Dark Kinght Rises \nLeeftijd: 16+ \nDuur 1:30:00 uur. \nStart tijd: zaal 3 15:00, zaal 8 16:00\nTaal: Engels (NL ondertiteling).\nzigtbaar: IMAX, 3D, 2D.";
        }

        private void btnDinsdag_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._81kz06oSUeL__AC_SL1500_;
            richTextBox1.Text = "Title: Interstellar \nLeeftijd: 11+ \nDuur 1:25:00 uur. \nStart tijd: zaal 7 12:00, zaal 15 15:00\nTaal: Engels (NL ondertiteling).\nzigtbaar: IMAX, 3D, 2D.";
        }

        private void btnWoensdag_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._268x0w;
            richTextBox1.Text = "Title: Joker \nLeeftijd: 18+ \nDuur 1:35:00 uur. \nStart tijd: zaal 1 10:00, zaal 2 11:00, zaal 3 12:00, zaal 4 13:00\nTaal: Engels (EN ondertiteling).\nzigtbaar: IMAX, 3D, 2D.";
        }

        private void btnDonderdag_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.avengers_endgame_original_movie_poster_15x21_in_2019_anthony_russo_robert_downey_jr;
            richTextBox1.Text = "Title: Avengers Endgame \nLeeftijd: 12+ \nDuur 2:05:00 uur. \nStart tijd: zaal 5 10:00, zaal 6 11:00, zaal 7 12:00, zaal 4 13:00\nTaal: Engels (EN ondertiteling).\nzigtbaar: IMAX, 3D, 2D.";
        }

        private void btnVrijdag_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM___V1_;
            richTextBox1.Text = "Title: The Godfather \nLeeftijd: 18+ \nDuur 1:25:00 uur. \nStart tijd: zaal 5 17:00, zaal 6 19:00, zaal 4 21:00\nTaal: Engels.\nzigtbaar: IMAX, 2D.";
        }

        private void btnZaterdag_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.THE_LORD_OF_THE_RINGS_THE_TWO_TOWERS_Frodo_Reprint_2002_REPRINT_CINEMA_POSTER__74417_1534256853;
            richTextBox1.Text = "Title: The Lord of the rings the two towers  \nLeeftijd: 14+ \nDuur 3:25:00 uur. \nStart tijd: zaal 1 12:00, zaal 2 13:00, zaal 3 14:00\nTaal: Engels.\nzigtbaar: IMAX, 2D.";
        }

        private void btnZondag_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.baaf0f0f37c294c779ed9d52896e9d52;
            richTextBox1.Text = "Title: The Lord of the rings fellowschip of the ring  \nLeeftijd: 14+ \nDuur 3:25:00 uur. \nStart tijd: zaal 1 12:00, zaal 2 13:00, zaal 3 14:00\nTaal: Engels.\nzigtbaar: IMAX, 2D.";
        }
    }
}
