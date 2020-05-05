using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_B
{
    public partial class Programma : Form
    {
        public static string movie;
        public Programma()
        {
            InitializeComponent();
            DateTime dt = DateTime.Today;

            if (dt.DayOfWeek == DayOfWeek.Monday)
            {
                btnMaandag.BackColor = Color.FromArgb(252, 167, 88);
                btnDinsdag.BackColor = Color.DarkGray;
                btnWoensdag.BackColor = Color.DarkGray;
                btnDonderdag.BackColor = Color.DarkGray;
                btnVrijdag.BackColor = Color.DarkGray;
                btnZaterdag.BackColor = Color.DarkGray;
                btnZondag.BackColor = Color.DarkGray;

                pictureBox1.Image = Properties.Resources._51Av5azGomL__AC_;
                richTextBox1.Text = "Title: The Dark Kinght Rises \nLeeftijd: 16+ \nDuur 1:30:00 uur. \nStart tijd: zaal 3 15:00, zaal 8 16:00\nTaal: Engels (NL ondertiteling).\nzigtbaar: IMAX, 3D, 2D.";
                pictureBox2.Image = Properties.Resources._81kz06oSUeL__AC_SL1500_;
                richTextBox2.Text = "Title: Interstellar \nLeeftijd: 11+ \nDuur 1:25:00 uur. \nStart tijd: zaal 7 12:00, zaal 15 15:00\nTaal: Engels (NL ondertiteling).\nzigtbaar: IMAX, 3D, 2D.";
                pictureBox3.Image = Properties.Resources._268x0w;
                richTextBox3.Text = "Title: Joker \nLeeftijd: 18+ \nDuur 1:35:00 uur. \nStart tijd: zaal 1 10:00, zaal 2 11:00, zaal 3 12:00, zaal 4 13:00\nTaal: Engels (EN ondertiteling).\nzigtbaar: IMAX, 3D, 2D.";
                pictureBox4.Image = Properties.Resources.avengers_endgame_original_movie_poster_15x21_in_2019_anthony_russo_robert_downey_jr;
                richTextBox4.Text = "Title: Avengers Endgame \nLeeftijd: 12+ \nDuur 2:05:00 uur. \nStart tijd: zaal 5 10:00, zaal 6 11:00, zaal 7 12:00, zaal 4 13:00\nTaal: Engels (EN ondertiteling).\nzigtbaar: IMAX, 3D, 2D.";
            }
            else if (dt.DayOfWeek == DayOfWeek.Tuesday)
            {
                btnMaandag.BackColor = Color.DarkGray;
                btnDinsdag.BackColor = Color.FromArgb(252, 167, 88);
                btnWoensdag.BackColor = Color.DarkGray;
                btnDonderdag.BackColor = Color.DarkGray;
                btnVrijdag.BackColor = Color.DarkGray;
                btnZaterdag.BackColor = Color.DarkGray;
                btnZondag.BackColor = Color.DarkGray;

                pictureBox1.Image = Properties.Resources.MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM___V1_;
                richTextBox1.Text = "Title: The Godfather \nLeeftijd: 18+ \nDuur 1:25:00 uur. \nStart tijd: zaal 5 17:00, zaal 6 19:00, zaal 4 21:00\nTaal: Engels.\nzigtbaar: IMAX, 2D.";
                pictureBox2.Image = Properties.Resources.THE_LORD_OF_THE_RINGS_THE_TWO_TOWERS_Frodo_Reprint_2002_REPRINT_CINEMA_POSTER__74417_1534256853;
                richTextBox2.Text = "Title: The Lord of the rings the two towers  \nLeeftijd: 14+ \nDuur 3:25:00 uur. \nStart tijd: zaal 1 12:00, zaal 2 13:00, zaal 3 14:00\nTaal: Engels.\nzigtbaar: IMAX, 2D.";
                pictureBox3.Image = Properties.Resources.baaf0f0f37c294c779ed9d52896e9d52;
                richTextBox3.Text = "Title: The Lord of the rings fellowschip of the ring  \nLeeftijd: 14+ \nDuur 3:25:00 uur. \nStart tijd: zaal 1 12:00, zaal 2 13:00, zaal 3 14:00\nTaal: Engels.\nzigtbaar: IMAX, 2D.";
                pictureBox4.Image = Properties.Resources._7e6b6743a7e45d096838abd67b2464e2;
                richTextBox4.Text = "Title: The Lord of the Rings The return of the king. \nLeeftijd: 14+ \nDuur 3:25:00 uur. \nStart tijd: zaal 5 13:00, zaal 8 15:00, 11: 18:00 \nTaal: Engles.\nZigtbaar: IMAX, 2D.";
            }
            else if (dt.DayOfWeek == DayOfWeek.Wednesday)
            {
                btnMaandag.BackColor = Color.DarkGray;
                btnDinsdag.BackColor = Color.DarkGray;
                btnWoensdag.BackColor = Color.FromArgb(252, 167, 88);
                btnDonderdag.BackColor = Color.DarkGray;
                btnVrijdag.BackColor = Color.DarkGray;
                btnZaterdag.BackColor = Color.DarkGray;
                btnZondag.BackColor = Color.DarkGray;

                pictureBox1.Image = Properties.Resources.peter_rabbit_movie_2_novelisation;
                richTextBox1.Text = "Title: Peter rabit 2. \nLeeftijd: 6+. \nDuur 1:20:00 uur. \nStart tijd:  zaal 6: 9:00, zaal 8: 12:00, zaal 10: 15:00. \nTaal: Nederlands. \nZigtbaar: 3D, 2D.";
                pictureBox2.Image = Properties.Resources.MV5BNmU4NTc0ZTgtNjliOC00NTM2LWE3NDktNGJiNzc2YzY3ZjA2XkEyXkFqcGdeQXVyNDg4NjY5OTQ___V1_;
                richTextBox2.Text = "Title: IO. \nleeftijd 12+. \nDuur: 1:30:00 uur \nStart tijd: zaal 12: 13:00, zaal 13: 14:00 \nTaal: Nederlands \nZigtbaar: 3D, 2D.";
                pictureBox3.Image = Properties.Resources.MV5BOTNlZWY2ZGQtY2U1ZS00Mjc5LWExNjgtM2Q4YzQyYTlmNjZhXkEyXkFqcGdeQXVyODY3Nzc0OTk___V1_;
                richTextBox3.Text = "Title: Wildlife. \nLeeftijd 12+. \nDuur 1:35:00 uur \nStart tijd: zaal 1: 8:00, zaal 2: 9:00, zaal 3: 10:00. \nTaal: Engels (NL sub). \nZightBaar: IMAX, 3D, 2D.";
                pictureBox4.Image = Properties.Resources._865580314a24d809e6fb0f12ce72e738;
                richTextBox4.Text = "Title: Fight Club. \nLeeftijd 16+. \nDuur 1:25:00 uur. \nStart tijd: zaal 12: 16:00, zaal 14: 18:00, zaal 16: 20:00. \nTaal: Nederlands. \nZightbaar: 2D.";
            }
            else if (dt.DayOfWeek == DayOfWeek.Thursday)
            {
                btnMaandag.BackColor = Color.DarkGray;
                btnDinsdag.BackColor = Color.DarkGray;
                btnWoensdag.BackColor = Color.DarkGray;
                btnDonderdag.BackColor = Color.FromArgb(252, 167, 88);
                btnVrijdag.BackColor = Color.DarkGray;
                btnZaterdag.BackColor = Color.DarkGray;
                btnZondag.BackColor = Color.DarkGray;

                pictureBox1.Image = Properties.Resources._51Av5azGomL__AC_;
                richTextBox1.Text = "Title: The Dark Kinght Rises \nLeeftijd: 16+ \nDuur 1:30:00 uur. \nStart tijd: zaal 3 15:00, zaal 8 16:00\nTaal: Engels (NL ondertiteling).\nzigtbaar: IMAX, 3D, 2D.";
                pictureBox2.Image = Properties.Resources.MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM___V1_;
                richTextBox2.Text = "Title: The Godfather \nLeeftijd: 18+ \nDuur 1:25:00 uur. \nStart tijd: zaal 5 17:00, zaal 6 19:00, zaal 4 21:00\nTaal: Engels.\nzigtbaar: IMAX, 2D.";
                pictureBox3.Image = Properties.Resources.peter_rabbit_movie_2_novelisation;
                richTextBox3.Text = "Title: Peter rabiit 2. \nLeeftijd: 6+. \nDuur 1:20:00 uur. \nStart tijd:  zaal 6: 9:00, zaal 8: 12:00, zaal 10: 15:00. \nTaal: Nederlands. \nZigtbaar: 3D, 2D.";
                pictureBox4.Image = Properties.Resources._865580314a24d809e6fb0f12ce72e738;
                richTextBox4.Text = "Title: Fight Club. \nLeeftijd 16+. \nDuur 1:25:00 uur. \nStart tijd: zaal 12: 16:00, zaal 14: 18:00, zaal 16: 20:00. \nTaal: Nederlands. \nZightbaar: 2D.";
            }
            else if (dt.DayOfWeek == DayOfWeek.Friday)
            {
                btnMaandag.BackColor = Color.DarkGray;
                btnDinsdag.BackColor = Color.DarkGray;
                btnWoensdag.BackColor = Color.DarkGray;
                btnDonderdag.BackColor = Color.DarkGray;
                btnVrijdag.BackColor = Color.FromArgb(252, 167, 88);
                btnZaterdag.BackColor = Color.DarkGray;
                btnZondag.BackColor = Color.DarkGray;

                pictureBox1.Image = Properties.Resources._51Av5azGomL__AC_;
                richTextBox1.Text = "Title: The Dark Kinght Rises \nLeeftijd: 16+ \nDuur 1:30:00 uur. \nStart tijd: zaal 3 15:00, zaal 8 16:00\nTaal: Engels (NL ondertiteling).\nzigtbaar: IMAX, 3D, 2D.";
                pictureBox2.Image = Properties.Resources._81kz06oSUeL__AC_SL1500_;
                richTextBox2.Text = "Title: Interstellar \nLeeftijd: 11+ \nDuur 1:25:00 uur. \nStart tijd: zaal 7 12:00, zaal 15 15:00\nTaal: Engels (NL ondertiteling).\nzigtbaar: IMAX, 3D, 2D.";
                pictureBox3.Image = Properties.Resources.MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM___V1_;
                richTextBox3.Text = "Title: The Godfather \nLeeftijd: 18+ \nDuur 1:25:00 uur. \nStart tijd: zaal 5 17:00, zaal 6 19:00, zaal 4 21:00\nTaal: Engels.\nzigtbaar: IMAX, 2D.";
                pictureBox4.Image = Properties.Resources.THE_LORD_OF_THE_RINGS_THE_TWO_TOWERS_Frodo_Reprint_2002_REPRINT_CINEMA_POSTER__74417_1534256853;
                richTextBox4.Text = "Title: The Lord of the rings the two towers  \nLeeftijd: 14+ \nDuur 3:25:00 uur. \nStart tijd: zaal 1 12:00, zaal 2 13:00, zaal 3 14:00\nTaal: Engels.\nzigtbaar: IMAX, 2D.";
            }
            else if (dt.DayOfWeek == DayOfWeek.Saturday)
            {
                btnMaandag.BackColor = Color.DarkGray;
                btnDinsdag.BackColor = Color.DarkGray;
                btnWoensdag.BackColor = Color.DarkGray;
                btnDonderdag.BackColor = Color.DarkGray;
                btnVrijdag.BackColor = Color.DarkGray;
                btnZaterdag.BackColor = Color.FromArgb(252, 167, 88);
                btnZondag.BackColor = Color.DarkGray;

                pictureBox1.Image = Properties.Resources.peter_rabbit_movie_2_novelisation;
                richTextBox1.Text = "Title: Peter rabit 2. \nLeeftijd: 6+. \nDuur 1:20:00 uur. \nStart tijd:  zaal 6: 9:00, zaal 8: 12:00, zaal 10: 15:00. \nTaal: Nederlands. \nZigtbaar: 3D, 2D.";
                pictureBox2.Image = Properties.Resources.MV5BNmU4NTc0ZTgtNjliOC00NTM2LWE3NDktNGJiNzc2YzY3ZjA2XkEyXkFqcGdeQXVyNDg4NjY5OTQ___V1_;
                richTextBox2.Text = "Title: IO. \nleeftijd 12+. \nDuur: 1:30:00 uur \nStart tijd: zaal 12: 13:00, zaal 13: 14:00 \nTaal: Nederlands \nZigtbaar: 3D, 2D.";
                pictureBox3.Image = Properties.Resources.THE_LORD_OF_THE_RINGS_THE_TWO_TOWERS_Frodo_Reprint_2002_REPRINT_CINEMA_POSTER__74417_1534256853;
                richTextBox3.Text = "Title: The Lord of the rings the two towers  \nLeeftijd: 14+ \nDuur 3:25:00 uur. \nStart tijd: zaal 1 12:00, zaal 2 13:00, zaal 3 14:00\nTaal: Engels.\nzigtbaar: IMAX, 2D.";
                pictureBox4.Image = Properties.Resources._865580314a24d809e6fb0f12ce72e738;
                richTextBox4.Text = "Title: Fight Club. \nLeeftijd 16+. \nDuur 1:25:00 uur. \nStart tijd: zaal 12: 16:00, zaal 14: 18:00, zaal 16: 20:00. \nTaal: Nederlands. \nZightbaar: 2D.";
            }
            else if (dt.DayOfWeek == DayOfWeek.Sunday)
            {
                btnMaandag.BackColor = Color.DarkGray;
                btnDinsdag.BackColor = Color.DarkGray;
                btnWoensdag.BackColor = Color.DarkGray;
                btnDonderdag.BackColor = Color.DarkGray;
                btnVrijdag.BackColor = Color.DarkGray;
                btnZaterdag.BackColor = Color.DarkGray;
                btnZondag.BackColor = Color.FromArgb(252, 167, 88);

                pictureBox1.Image = Properties.Resources._51Av5azGomL__AC_;
                richTextBox1.Text = "Title: The Dark Kinght Rises \nLeeftijd: 16+ \nDuur 1:30:00 uur. \nStart tijd: zaal 3 15:00, zaal 8 16:00\nTaal: Engels (NL ondertiteling).\nzigtbaar: IMAX, 3D, 2D.";
                pictureBox2.Image = Properties.Resources.THE_LORD_OF_THE_RINGS_THE_TWO_TOWERS_Frodo_Reprint_2002_REPRINT_CINEMA_POSTER__74417_1534256853;
                richTextBox2.Text = "Title: The Lord of the rings the two towers  \nLeeftijd: 14+ \nDuur 3:25:00 uur. \nStart tijd: zaal 1 12:00, zaal 2 13:00, zaal 3 14:00\nTaal: Engels.\nzigtbaar: IMAX, 2D.";
                pictureBox3.Image = Properties.Resources.MV5BOTNlZWY2ZGQtY2U1ZS00Mjc5LWExNjgtM2Q4YzQyYTlmNjZhXkEyXkFqcGdeQXVyODY3Nzc0OTk___V1_;
                richTextBox3.Text = "Title: Wildlife. \nLeeftijd 12+. \nDuur 1:35:00 uur \nStart tijd: zaal 1: 8:00, zaal 2: 9:00, zaal 3: 10:00. \nTaal: Engels (NL sub). \nZightBaar: IMAX, 3D, 2D.";
                pictureBox4.Image = Properties.Resources._865580314a24d809e6fb0f12ce72e738;
                richTextBox4.Text = "Title: Fight Club. \nLeeftijd 16+. \nDuur 1:25:00 uur. \nStart tijd: zaal 12: 16:00, zaal 14: 18:00, zaal 16: 20:00. \nTaal: Nederlands. \nZightbaar: 2D.";
            }
        }

        private void btnMaandag_Click(object sender, EventArgs e)
        {
            btnMaandag.BackColor = Color.FromArgb(252, 167, 88);
            btnDinsdag.BackColor = Color.DarkGray;
            btnWoensdag.BackColor = Color.DarkGray;
            btnDonderdag.BackColor = Color.DarkGray;
            btnVrijdag.BackColor = Color.DarkGray;
            btnZaterdag.BackColor = Color.DarkGray;
            btnZondag.BackColor = Color.DarkGray;

            pictureBox1.Image = Properties.Resources._51Av5azGomL__AC_;
            richTextBox1.Text = "Title: The Dark Kinght Rises \nLeeftijd: 16+ \nDuur 1:30:00 uur. \nStart tijd: zaal 3 15:00, zaal 8 16:00\nTaal: Engels (NL ondertiteling).\nzigtbaar: IMAX, 3D, 2D.";
            pictureBox2.Image = Properties.Resources._81kz06oSUeL__AC_SL1500_;
            richTextBox2.Text = "Title: Interstellar \nLeeftijd: 11+ \nDuur 1:25:00 uur. \nStart tijd: zaal 7 12:00, zaal 15 15:00\nTaal: Engels (NL ondertiteling).\nzigtbaar: IMAX, 3D, 2D.";
            pictureBox3.Image = Properties.Resources._268x0w;
            richTextBox3.Text = "Title: Joker \nLeeftijd: 18+ \nDuur 1:35:00 uur. \nStart tijd: zaal 1 10:00, zaal 2 11:00, zaal 3 12:00, zaal 4 13:00\nTaal: Engels (EN ondertiteling).\nzigtbaar: IMAX, 3D, 2D.";
            pictureBox4.Image = Properties.Resources.avengers_endgame_original_movie_poster_15x21_in_2019_anthony_russo_robert_downey_jr;
            richTextBox4.Text = "Title: Avengers Endgame \nLeeftijd: 12+ \nDuur 2:05:00 uur. \nStart tijd: zaal 5 10:00, zaal 6 11:00, zaal 7 12:00, zaal 4 13:00\nTaal: Engels (EN ondertiteling).\nzigtbaar: IMAX, 3D, 2D.";
        }

        private void btnDinsdag_Click(object sender, EventArgs e)
        {
            btnMaandag.BackColor = Color.DarkGray;
            btnDinsdag.BackColor = Color.FromArgb(252, 167, 88);
            btnWoensdag.BackColor = Color.DarkGray;
            btnDonderdag.BackColor = Color.DarkGray;
            btnVrijdag.BackColor = Color.DarkGray;
            btnZaterdag.BackColor = Color.DarkGray;
            btnZondag.BackColor = Color.DarkGray;

            pictureBox1.Image = Properties.Resources.MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM___V1_;
            richTextBox1.Text = "Title: The Godfather \nLeeftijd: 18+ \nDuur 1:25:00 uur. \nStart tijd: zaal 5 17:00, zaal 6 19:00, zaal 4 21:00\nTaal: Engels.\nzigtbaar: IMAX, 2D.";
            pictureBox2.Image = Properties.Resources.THE_LORD_OF_THE_RINGS_THE_TWO_TOWERS_Frodo_Reprint_2002_REPRINT_CINEMA_POSTER__74417_1534256853;
            richTextBox2.Text = "Title: The Lord of the rings the two towers  \nLeeftijd: 14+ \nDuur 3:25:00 uur. \nStart tijd: zaal 1 12:00, zaal 2 13:00, zaal 3 14:00\nTaal: Engels.\nzigtbaar: IMAX, 2D.";
            pictureBox3.Image = Properties.Resources.baaf0f0f37c294c779ed9d52896e9d52;
            richTextBox3.Text = "Title: The Lord of the rings fellowschip of the ring  \nLeeftijd: 14+ \nDuur 3:25:00 uur. \nStart tijd: zaal 1 12:00, zaal 2 13:00, zaal 3 14:00\nTaal: Engels.\nzigtbaar: IMAX, 2D.";
            pictureBox4.Image = Properties.Resources._7e6b6743a7e45d096838abd67b2464e2;
            richTextBox4.Text = "Title: The Lord of the Rings The return of the king. \nLeeftijd: 14+ \nDuur 3:25:00 uur. \nStart tijd: zaal 5 13:00, zaal 8 15:00, 11: 18:00 \nTaal: Engles.\nZigtbaar: IMAX, 2D.";
        }

        private void btnWoensdag_Click(object sender, EventArgs e)
        {
            btnMaandag.BackColor = Color.DarkGray;
            btnDinsdag.BackColor = Color.DarkGray;
            btnWoensdag.BackColor = Color.FromArgb(252, 167, 88);
            btnDonderdag.BackColor = Color.DarkGray;
            btnVrijdag.BackColor = Color.DarkGray;
            btnZaterdag.BackColor = Color.DarkGray;
            btnZondag.BackColor = Color.DarkGray;

            pictureBox1.Image = Properties.Resources.peter_rabbit_movie_2_novelisation;
            richTextBox1.Text = "Title: Peter rabit 2. \nLeeftijd: 6+. \nDuur 1:20:00 uur. \nStart tijd:  zaal 6: 9:00, zaal 8: 12:00, zaal 10: 15:00. \nTaal: Nederlands. \nZigtbaar: 3D, 2D.";
            pictureBox2.Image = Properties.Resources.MV5BNmU4NTc0ZTgtNjliOC00NTM2LWE3NDktNGJiNzc2YzY3ZjA2XkEyXkFqcGdeQXVyNDg4NjY5OTQ___V1_;
            richTextBox2.Text = "Title: IO. \nleeftijd 12+. \nDuur: 1:30:00 uur \nStart tijd: zaal 12: 13:00, zaal 13: 14:00 \nTaal: Nederlands \nZigtbaar: 3D, 2D.";
            pictureBox3.Image = Properties.Resources.MV5BOTNlZWY2ZGQtY2U1ZS00Mjc5LWExNjgtM2Q4YzQyYTlmNjZhXkEyXkFqcGdeQXVyODY3Nzc0OTk___V1_;
            richTextBox3.Text = "Title: Wildlife. \nLeeftijd 12+. \nDuur 1:35:00 uur \nStart tijd: zaal 1: 8:00, zaal 2: 9:00, zaal 3: 10:00. \nTaal: Engels (NL sub). \nZightBaar: IMAX, 3D, 2D.";
            pictureBox4.Image = Properties.Resources._865580314a24d809e6fb0f12ce72e738;
            richTextBox4.Text = "Title: Fight Club. \nLeeftijd 16+. \nDuur 1:25:00 uur. \nStart tijd: zaal 12: 16:00, zaal 14: 18:00, zaal 16: 20:00. \nTaal: Nederlands. \nZightbaar: 2D.";
        }

        private void btnDonderdag_Click(object sender, EventArgs e)
        {
            btnMaandag.BackColor = Color.DarkGray;
            btnDinsdag.BackColor = Color.DarkGray;
            btnWoensdag.BackColor = Color.DarkGray;
            btnDonderdag.BackColor = Color.FromArgb(252, 167, 88);
            btnVrijdag.BackColor = Color.DarkGray;
            btnZaterdag.BackColor = Color.DarkGray;
            btnZondag.BackColor = Color.DarkGray;

            pictureBox1.Image = Properties.Resources._51Av5azGomL__AC_;
            richTextBox1.Text = "Title: The Dark Kinght Rises \nLeeftijd: 16+ \nDuur 1:30:00 uur. \nStart tijd: zaal 3 15:00, zaal 8 16:00\nTaal: Engels (NL ondertiteling).\nzigtbaar: IMAX, 3D, 2D.";
            pictureBox2.Image = Properties.Resources.MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM___V1_;
            richTextBox2.Text = "Title: The Godfather \nLeeftijd: 18+ \nDuur 1:25:00 uur. \nStart tijd: zaal 5 17:00, zaal 6 19:00, zaal 4 21:00\nTaal: Engels.\nzigtbaar: IMAX, 2D.";
            pictureBox3.Image = Properties.Resources.peter_rabbit_movie_2_novelisation;
            richTextBox3.Text = "Title: Peter rabiit 2. \nLeeftijd: 6+. \nDuur 1:20:00 uur. \nStart tijd:  zaal 6: 9:00, zaal 8: 12:00, zaal 10: 15:00. \nTaal: Nederlands. \nZigtbaar: 3D, 2D.";
            pictureBox4.Image = Properties.Resources._865580314a24d809e6fb0f12ce72e738;
            richTextBox4.Text = "Title: Fight Club. \nLeeftijd 16+. \nDuur 1:25:00 uur. \nStart tijd: zaal 12: 16:00, zaal 14: 18:00, zaal 16: 20:00. \nTaal: Nederlands. \nZightbaar: 2D.";
        }

        private void btnVrijdag_Click(object sender, EventArgs e)
        {
            btnMaandag.BackColor = Color.DarkGray;
            btnDinsdag.BackColor = Color.DarkGray;
            btnWoensdag.BackColor = Color.DarkGray;
            btnDonderdag.BackColor = Color.DarkGray;
            btnVrijdag.BackColor = Color.FromArgb(252, 167, 88);
            btnZaterdag.BackColor = Color.DarkGray;
            btnZondag.BackColor = Color.DarkGray;

            pictureBox1.Image = Properties.Resources._51Av5azGomL__AC_;
            richTextBox1.Text = "Title: The Dark Kinght Rises \nLeeftijd: 16+ \nDuur 1:30:00 uur. \nStart tijd: zaal 3 15:00, zaal 8 16:00\nTaal: Engels (NL ondertiteling).\nzigtbaar: IMAX, 3D, 2D.";
            pictureBox2.Image = Properties.Resources._81kz06oSUeL__AC_SL1500_;
            richTextBox2.Text = "Title: Interstellar \nLeeftijd: 11+ \nDuur 1:25:00 uur. \nStart tijd: zaal 7 12:00, zaal 15 15:00\nTaal: Engels (NL ondertiteling).\nzigtbaar: IMAX, 3D, 2D.";
            pictureBox3.Image = Properties.Resources.MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM___V1_;
            richTextBox3.Text = "Title: The Godfather \nLeeftijd: 18+ \nDuur 1:25:00 uur. \nStart tijd: zaal 5 17:00, zaal 6 19:00, zaal 4 21:00\nTaal: Engels.\nzigtbaar: IMAX, 2D.";
            pictureBox4.Image = Properties.Resources.THE_LORD_OF_THE_RINGS_THE_TWO_TOWERS_Frodo_Reprint_2002_REPRINT_CINEMA_POSTER__74417_1534256853;
            richTextBox4.Text = "Title: The Lord of the rings the two towers  \nLeeftijd: 14+ \nDuur 3:25:00 uur. \nStart tijd: zaal 1 12:00, zaal 2 13:00, zaal 3 14:00\nTaal: Engels.\nzigtbaar: IMAX, 2D.";
        }

        private void btnZaterdag_Click(object sender, EventArgs e)
        {
            btnMaandag.BackColor = Color.DarkGray;
            btnDinsdag.BackColor = Color.DarkGray;
            btnWoensdag.BackColor = Color.DarkGray;
            btnDonderdag.BackColor = Color.DarkGray;
            btnVrijdag.BackColor = Color.DarkGray;
            btnZaterdag.BackColor = Color.FromArgb(252, 167, 88);
            btnZondag.BackColor = Color.DarkGray;

            pictureBox1.Image = Properties.Resources.peter_rabbit_movie_2_novelisation;
            richTextBox1.Text = "Title: Peter rabit 2. \nLeeftijd: 6+. \nDuur 1:20:00 uur. \nStart tijd:  zaal 6: 9:00, zaal 8: 12:00, zaal 10: 15:00. \nTaal: Nederlands. \nZigtbaar: 3D, 2D.";
            pictureBox2.Image = Properties.Resources.MV5BNmU4NTc0ZTgtNjliOC00NTM2LWE3NDktNGJiNzc2YzY3ZjA2XkEyXkFqcGdeQXVyNDg4NjY5OTQ___V1_;
            richTextBox2.Text = "Title: IO. \nleeftijd 12+. \nDuur: 1:30:00 uur \nStart tijd: zaal 12: 13:00, zaal 13: 14:00 \nTaal: Nederlands \nZigtbaar: 3D, 2D.";
            pictureBox3.Image = Properties.Resources.THE_LORD_OF_THE_RINGS_THE_TWO_TOWERS_Frodo_Reprint_2002_REPRINT_CINEMA_POSTER__74417_1534256853;
            richTextBox3.Text = "Title: The Lord of the rings the two towers  \nLeeftijd: 14+ \nDuur 3:25:00 uur. \nStart tijd: zaal 1 12:00, zaal 2 13:00, zaal 3 14:00\nTaal: Engels.\nzigtbaar: IMAX, 2D.";
            pictureBox4.Image = Properties.Resources._865580314a24d809e6fb0f12ce72e738;
            richTextBox4.Text = "Title: Fight Club. \nLeeftijd 16+. \nDuur 1:25:00 uur. \nStart tijd: zaal 12: 16:00, zaal 14: 18:00, zaal 16: 20:00. \nTaal: Nederlands. \nZightbaar: 2D.";
        }

        private void btnZondag_Click(object sender, EventArgs e)
        {
            btnMaandag.BackColor = Color.DarkGray;
            btnDinsdag.BackColor = Color.DarkGray;
            btnWoensdag.BackColor = Color.DarkGray;
            btnDonderdag.BackColor = Color.DarkGray;
            btnVrijdag.BackColor = Color.DarkGray;
            btnZaterdag.BackColor = Color.DarkGray;
            btnZondag.BackColor = Color.FromArgb(252, 167, 88);

            pictureBox1.Image = Properties.Resources._51Av5azGomL__AC_;
            richTextBox1.Text = "Title: The Dark Kinght Rises \nLeeftijd: 16+ \nDuur 1:30:00 uur. \nStart tijd: zaal 3 15:00, zaal 8 16:00\nTaal: Engels (NL ondertiteling).\nzigtbaar: IMAX, 3D, 2D.";
            pictureBox2.Image = Properties.Resources.THE_LORD_OF_THE_RINGS_THE_TWO_TOWERS_Frodo_Reprint_2002_REPRINT_CINEMA_POSTER__74417_1534256853;
            richTextBox2.Text = "Title: The Lord of the rings the two towers  \nLeeftijd: 14+ \nDuur 3:25:00 uur. \nStart tijd: zaal 1 12:00, zaal 2 13:00, zaal 3 14:00\nTaal: Engels.\nzigtbaar: IMAX, 2D.";
            pictureBox3.Image = Properties.Resources.MV5BOTNlZWY2ZGQtY2U1ZS00Mjc5LWExNjgtM2Q4YzQyYTlmNjZhXkEyXkFqcGdeQXVyODY3Nzc0OTk___V1_;
            richTextBox3.Text = "Title: Wildlife. \nLeeftijd 12+. \nDuur 1:35:00 uur \nStart tijd: zaal 1: 8:00, zaal 2: 9:00, zaal 3: 10:00. \nTaal: Engels (NL sub). \nZightBaar: IMAX, 3D, 2D.";
            pictureBox4.Image = Properties.Resources._865580314a24d809e6fb0f12ce72e738;
            richTextBox4.Text = "Title: Fight Club. \nLeeftijd 16+. \nDuur 1:25:00 uur. \nStart tijd: zaal 12: 16:00, zaal 14: 18:00, zaal 16: 20:00. \nTaal: Nederlands. \nZightbaar: 2D.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            movie = richTextBox1.Text;
            this.Hide();
            FIlmInfo film = new FIlmInfo();
            film.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            movie = richTextBox2.Text;
            this.Hide();
            FIlmInfo film = new FIlmInfo();
            film.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            movie = richTextBox3.Text;
            this.Hide();
            FIlmInfo film = new FIlmInfo();
            film.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            movie = richTextBox4.Text;
            this.Hide();
            FIlmInfo film = new FIlmInfo();
            film.Show();
        }
    }
}