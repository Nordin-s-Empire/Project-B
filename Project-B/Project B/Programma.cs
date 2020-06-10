using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_B
{
    public partial class Programma : Form
    {
        public static string movie;
        public static int form = 0;
        public static string date;
        public static Image pic;

        public Programma()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";

            if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Monday)
            {
                pictureBox1.Image = Properties.Resources._51Av5azGomL__AC_;
                richTextBox1.Text = "Title: The Dark Knight Rises \n Leeftijd: 16+ \nDuur 1:30:00 uur. \nStart tijd: zaal 3 15:00, zaal 8 16:00\nTaal: Engels (NL ondertiteling).\nZichtbaar: IMAX, 3D, 2D.";
                pictureBox2.Image = Properties.Resources._81kz06oSUeL__AC_SL1500_;
                richTextBox2.Text = "Title: Interstellar \nLeeftijd: 11+ \nDuur 1:25:00 uur. \nStart tijd: zaal 7 12:00, zaal 15 15:00\nTaal: Engels (NL ondertiteling).\nZichtbaar: IMAX, 3D, 2D.";
                pictureBox3.Image = Properties.Resources._268x0w;
                richTextBox3.Text = "Title: Joker \nLeeftijd: 18+ \nDuur 1:35:00 uur. \nStart tijd: zaal 1 10:00, zaal 2 11:00, zaal 3 12:00, zaal 4 13:00\nTaal: Engels (EN ondertiteling).\nZichtbaar: IMAX, 3D, 2D.";
                pictureBox4.Image = Properties.Resources.avengers_endgame_original_movie_poster_15x21_in_2019_anthony_russo_robert_downey_jr;
                richTextBox4.Text = "Title: Avengers: Endgame \nLeeftijd: 12+ \nDuur 2:05:00 uur. \nStart tijd: zaal 5 10:00, zaal 6 11:00, zaal 7 12:00, zaal 4 13:00\nTaal: Engels (EN ondertiteling).\nZichtbaar: IMAX, 3D, 2D.";
            }
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Tuesday)
            {
                pictureBox1.Image = Properties.Resources.MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM___V1_;
                richTextBox1.Text = "Title: The Godfather \nLeeftijd: 18+ \nDuur 1:25:00 uur. \nStart tijd: zaal 5 17:00, zaal 6 19:00, zaal 4 21:00\nTaal: Engels.\nZichtbaar: IMAX, 2D.";
                pictureBox2.Image = Properties.Resources.THE_LORD_OF_THE_RINGS_THE_TWO_TOWERS_Frodo_Reprint_2002_REPRINT_CINEMA_POSTER__74417_1534256853;
                richTextBox2.Text = "Title: The Lord of the Rings: The Two Towers  \nLeeftijd: 14+ \nDuur 3:25:00 uur. \nStart tijd: zaal 1 12:00, zaal 2 13:00, zaal 3 14:00\nTaal: Engels.\nZichtbaar: IMAX, 2D.";
                pictureBox3.Image = Properties.Resources.baaf0f0f37c294c779ed9d52896e9d52;
                richTextBox3.Text = "Title: The Lord of the Rings: Fellowship of the Ring  \nLeeftijd: 14+ \nDuur 3:25:00 uur. \nStart tijd: zaal 1 12:00, zaal 2 13:00, zaal 3 14:00\nTaal: Engels.\nZichtbaar: IMAX, 2D.";
                pictureBox4.Image = Properties.Resources._7e6b6743a7e45d096838abd67b2464e2;
                richTextBox4.Text = "Title: The Lord of the Rings: The Return of the King \nLeeftijd: 14+ \nDuur 3:25:00 uur. \nStart tijd: zaal 5 13:00, zaal 8 15:00, 11: 18:00 \nTaal: Engles.\nZichtbaar: IMAX, 2D.";
            }
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Wednesday)
            {
                pictureBox1.Image = Properties.Resources.peter_rabbit_movie_2_novelisation;
                richTextBox1.Text = "Title: Peter Rabbit 2: The Runaway \nLeeftijd: 6+. \nDuur 1:20:00 uur. \nStart tijd:  zaal 6: 9:00, zaal 8: 12:00, zaal 10: 15:00. \nTaal: Nederlands. \nZichtbaar: 3D, 2D.";
                pictureBox2.Image = Properties.Resources.MV5BNmU4NTc0ZTgtNjliOC00NTM2LWE3NDktNGJiNzc2YzY3ZjA2XkEyXkFqcGdeQXVyNDg4NjY5OTQ___V1_;
                richTextBox2.Text = "Title: IO \nleeftijd 12+. \nDuur: 1:30:00 uur \nStart tijd: zaal 12: 13:00, zaal 13: 14:00 \nTaal: Nederlands \nZichtbaar: 3D, 2D.";
                pictureBox3.Image = Properties.Resources.MV5BOTNlZWY2ZGQtY2U1ZS00Mjc5LWExNjgtM2Q4YzQyYTlmNjZhXkEyXkFqcGdeQXVyODY3Nzc0OTk___V1_;
                richTextBox3.Text = "Title: Wildlife \nLeeftijd 12+. \nDuur 1:35:00 uur \nStart tijd: zaal 1: 8:00, zaal 2: 9:00, zaal 3: 10:00. \nTaal: Engels (NL sub). \nZichtbaar: IMAX, 3D, 2D.";
                pictureBox4.Image = Properties.Resources._865580314a24d809e6fb0f12ce72e738;
                richTextBox4.Text = "Title: Fight Club \nLeeftijd 16+. \nDuur 1:25:00 uur. \nStart tijd: zaal 12: 16:00, zaal 14: 18:00, zaal 16: 20:00. \nTaal: Nederlands. \nZichtbaar: 2D.";
            }
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Thursday)
            {
                pictureBox1.Image = Properties.Resources._51Av5azGomL__AC_;
                richTextBox1.Text = "Title: The Dark Knight Rises \nLeeftijd: 16+ \nDuur 1:30:00 uur. \nStart tijd: zaal 3 15:00, zaal 8 16:00\nTaal: Engels (NL ondertiteling).\nZichtbaar: IMAX, 3D, 2D.";
                pictureBox2.Image = Properties.Resources.MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM___V1_;
                richTextBox2.Text = "Title: The Godfather \nLeeftijd: 18+ \nDuur 1:25:00 uur. \nStart tijd: zaal 5 17:00, zaal 6 19:00, zaal 4 21:00\nTaal: Engels.\nZichtbaar: IMAX, 2D.";
                pictureBox3.Image = Properties.Resources.peter_rabbit_movie_2_novelisation;
                richTextBox3.Text = "Title: Peter Rabbit 2: The Runaway \nLeeftijd: 6+. \nDuur 1:20:00 uur. \nStart tijd:  zaal 6: 9:00, zaal 8: 12:00, zaal 10: 15:00. \nTaal: Nederlands. \nZichtbaar: 3D, 2D.";
                pictureBox4.Image = Properties.Resources._865580314a24d809e6fb0f12ce72e738;
                richTextBox4.Text = "Title: Fight Club \nLeeftijd 16+. \nDuur 1:25:00 uur. \nStart tijd: zaal 12: 16:00, zaal 14: 18:00, zaal 16: 20:00. \nTaal: Nederlands. \nZichtbaar: 2D.";
            }
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Friday)
            {
                pictureBox1.Image = Properties.Resources._51Av5azGomL__AC_;
                richTextBox1.Text = "Title: The Dark Knight Rises \nLeeftijd: 16+ \nDuur 1:30:00 uur. \nStart tijd: zaal 3 15:00, zaal 8 16:00\nTaal: Engels (NL ondertiteling).\nZichtbaar: IMAX, 3D, 2D.";
                pictureBox2.Image = Properties.Resources._81kz06oSUeL__AC_SL1500_;
                richTextBox2.Text = "Title: Interstellar \nLeeftijd: 11+ \nDuur 1:25:00 uur. \nStart tijd: zaal 7 12:00, zaal 15 15:00\nTaal: Engels (NL ondertiteling).\nZichtbaar: IMAX, 3D, 2D.";
                pictureBox3.Image = Properties.Resources.MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM___V1_;
                richTextBox3.Text = "Title: The Godfather \nLeeftijd: 18+ \nDuur 1:25:00 uur. \nStart tijd: zaal 5 17:00, zaal 6 19:00, zaal 4 21:00\nTaal: Engels.\nZichtbaar: IMAX, 2D.";
                pictureBox4.Image = Properties.Resources.THE_LORD_OF_THE_RINGS_THE_TWO_TOWERS_Frodo_Reprint_2002_REPRINT_CINEMA_POSTER__74417_1534256853;
                richTextBox4.Text = "Title: The Lord of the Rings: The Two Towers  \nLeeftijd: 14+ \nDuur 3:25:00 uur. \nStart tijd: zaal 1 12:00, zaal 2 13:00, zaal 3 14:00\nTaal: Engels.\nZichtbaar: IMAX, 2D.";
            }
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Saturday)
            {
                pictureBox1.Image = Properties.Resources.peter_rabbit_movie_2_novelisation;
                richTextBox1.Text = "Title: Peter Rabbit 2: The Runaway \nLeeftijd: 6+. \nDuur 1:20:00 uur. \nStart tijd:  zaal 6: 9:00, zaal 8: 12:00, zaal 10: 15:00. \nTaal: Nederlands. \nZichtbaar: 3D, 2D.";
                pictureBox2.Image = Properties.Resources.MV5BNmU4NTc0ZTgtNjliOC00NTM2LWE3NDktNGJiNzc2YzY3ZjA2XkEyXkFqcGdeQXVyNDg4NjY5OTQ___V1_;
                richTextBox2.Text = "Title: IO \nleeftijd 12+. \nDuur: 1:30:00 uur \nStart tijd: zaal 12: 13:00, zaal 13: 14:00 \nTaal: Nederlands \nZichtbaar: 3D, 2D.";
                pictureBox3.Image = Properties.Resources.THE_LORD_OF_THE_RINGS_THE_TWO_TOWERS_Frodo_Reprint_2002_REPRINT_CINEMA_POSTER__74417_1534256853;
                richTextBox3.Text = "Title: The Lord of the Rings: The Two Towers  \nLeeftijd: 14+ \nDuur 3:25:00 uur. \nStart tijd: zaal 1 12:00, zaal 2 13:00, zaal 3 14:00\nTaal: Engels.\nZichtbaar: IMAX, 2D.";
                pictureBox4.Image = Properties.Resources._865580314a24d809e6fb0f12ce72e738;
                richTextBox4.Text = "Title: Fight Club \nLeeftijd 16+. \nDuur 1:25:00 uur. \nStart tijd: zaal 12: 16:00, zaal 14: 18:00, zaal 16: 20:00. \nTaal: Nederlands. \nZichtbaar: 2D.";
            }
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                pictureBox1.Image = Properties.Resources._51Av5azGomL__AC_;
                richTextBox1.Text = "Title: The Dark Knight Rises \nLeeftijd: 16+ \nDuur 1:30:00 uur. \nStart tijd: zaal 3 15:00, zaal 8 16:00\nTaal: Engels (NL ondertiteling).\nZichtbaar: IMAX, 3D, 2D.";
                pictureBox2.Image = Properties.Resources.THE_LORD_OF_THE_RINGS_THE_TWO_TOWERS_Frodo_Reprint_2002_REPRINT_CINEMA_POSTER__74417_1534256853;
                richTextBox2.Text = "Title: The Lord of the Rings: The Two Towers  \nLeeftijd: 14+ \nDuur 3:25:00 uur. \nStart tijd: zaal 1 12:00, zaal 2 13:00, zaal 3 14:00\nTaal: Engels.\nZichtbaar: IMAX, 2D.";
                pictureBox3.Image = Properties.Resources.MV5BOTNlZWY2ZGQtY2U1ZS00Mjc5LWExNjgtM2Q4YzQyYTlmNjZhXkEyXkFqcGdeQXVyODY3Nzc0OTk___V1_;
                richTextBox3.Text = "Title: Wildlife \nLeeftijd 12+. \nDuur 1:35:00 uur \nStart tijd: zaal 1: 8:00, zaal 2: 9:00, zaal 3: 10:00. \nTaal: Engels (NL sub). \nZichtbaar: IMAX, 3D, 2D.";
                pictureBox4.Image = Properties.Resources._865580314a24d809e6fb0f12ce72e738;
                richTextBox4.Text = "Title: Fight Club \nLeeftijd 16+. \nDuur 1:25:00 uur. \nStart tijd: zaal 12: 16:00, zaal 14: 18:00, zaal 16: 20:00. \nTaal: Nederlands. \nZichtbaar: 2D.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            movie = richTextBox1.Text;
            date = dateTimePicker1.Text + " Zaal 9: 10:00";
            pic = this.pictureBox1.Image;
            this.Hide();
            FIlmInfo film = new FIlmInfo();
            film.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            movie = richTextBox2.Text;
            date = dateTimePicker1.Text + " Zaal 3: 9:00";
            pic = this.pictureBox2.Image;
            this.Hide();
            FIlmInfo film = new FIlmInfo();
            film.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            movie = richTextBox3.Text;
            date = dateTimePicker1.Text + " Zaal 5: 15:00";
            pic = this.pictureBox3.Image;
            this.Hide();
            FIlmInfo film = new FIlmInfo();
            film.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            movie = richTextBox4.Text;
            date = dateTimePicker1.Text + " Zaal 12: 20:00";
            pic = this.pictureBox4.Image;
            this.Hide();
            FIlmInfo film = new FIlmInfo();
            film.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Monday)
            {
                pictureBox1.Image = Properties.Resources._51Av5azGomL__AC_;
                richTextBox1.Text = "Title: The Dark Knight Rises \n Leeftijd: 16+ \nDuur 1:30:00 uur. \nStart tijd: zaal 3 15:00, zaal 8 16:00\nTaal: Engels (NL ondertiteling).\nZichtbaar: IMAX, 3D, 2D.";
                pictureBox2.Image = Properties.Resources._81kz06oSUeL__AC_SL1500_;
                richTextBox2.Text = "Title: Interstellar \nLeeftijd: 11+ \nDuur 1:25:00 uur. \nStart tijd: zaal 7 12:00, zaal 15 15:00\nTaal: Engels (NL ondertiteling).\nZichtbaar: IMAX, 3D, 2D.";
                pictureBox3.Image = Properties.Resources._268x0w;
                richTextBox3.Text = "Title: Joker \nLeeftijd: 18+ \nDuur 1:35:00 uur. \nStart tijd: zaal 1 10:00, zaal 2 11:00, zaal 3 12:00, zaal 4 13:00\nTaal: Engels (EN ondertiteling).\nZichtbaar: IMAX, 3D, 2D.";
                pictureBox4.Image = Properties.Resources.avengers_endgame_original_movie_poster_15x21_in_2019_anthony_russo_robert_downey_jr;
                richTextBox4.Text = "Title: Avengers: Endgame \nLeeftijd: 12+ \nDuur 2:05:00 uur. \nStart tijd: zaal 5 10:00, zaal 6 11:00, zaal 7 12:00, zaal 4 13:00\nTaal: Engels (EN ondertiteling).\nZichtbaar: IMAX, 3D, 2D.";
            }
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Tuesday)
            {
                pictureBox1.Image = Properties.Resources.MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM___V1_;
                richTextBox1.Text = "Title: The Godfather \nLeeftijd: 18+ \nDuur 1:25:00 uur. \nStart tijd: zaal 5 17:00, zaal 6 19:00, zaal 4 21:00\nTaal: Engels.\nZichtbaar: IMAX, 2D.";
                pictureBox2.Image = Properties.Resources.THE_LORD_OF_THE_RINGS_THE_TWO_TOWERS_Frodo_Reprint_2002_REPRINT_CINEMA_POSTER__74417_1534256853;
                richTextBox2.Text = "Title: The Lord of the Rings: The Two Towers  \nLeeftijd: 14+ \nDuur 3:25:00 uur. \nStart tijd: zaal 1 12:00, zaal 2 13:00, zaal 3 14:00\nTaal: Engels.\nZichtbaar: IMAX, 2D.";
                pictureBox3.Image = Properties.Resources.baaf0f0f37c294c779ed9d52896e9d52;
                richTextBox3.Text = "Title: The Lord of the Rings: Fellowship of the Ring  \nLeeftijd: 14+ \nDuur 3:25:00 uur. \nStart tijd: zaal 1 12:00, zaal 2 13:00, zaal 3 14:00\nTaal: Engels.\nZichtbaar: IMAX, 2D.";
                pictureBox4.Image = Properties.Resources._7e6b6743a7e45d096838abd67b2464e2;
                richTextBox4.Text = "Title: The Lord of the Rings: The Return of the King. \nLeeftijd: 14+ \nDuur 3:25:00 uur. \nStart tijd: zaal 5 13:00, zaal 8 15:00, 11: 18:00 \nTaal: Engles.\nZichtbaar: IMAX, 2D.";
            }
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Wednesday)
            {
                pictureBox1.Image = Properties.Resources.peter_rabbit_movie_2_novelisation;
                richTextBox1.Text = "Title: Peter Rabbit 2: The Runaway \nLeeftijd: 6+. \nDuur 1:20:00 uur. \nStart tijd:  zaal 6: 9:00, zaal 8: 12:00, zaal 10: 15:00. \nTaal: Nederlands. \nZichtbaar: 3D, 2D.";
                pictureBox2.Image = Properties.Resources.MV5BNmU4NTc0ZTgtNjliOC00NTM2LWE3NDktNGJiNzc2YzY3ZjA2XkEyXkFqcGdeQXVyNDg4NjY5OTQ___V1_;
                richTextBox2.Text = "Title: IO \nleeftijd 12+. \nDuur: 1:30:00 uur \nStart tijd: zaal 12: 13:00, zaal 13: 14:00 \nTaal: Nederlands \nZichtbaar: 3D, 2D.";
                pictureBox3.Image = Properties.Resources.MV5BOTNlZWY2ZGQtY2U1ZS00Mjc5LWExNjgtM2Q4YzQyYTlmNjZhXkEyXkFqcGdeQXVyODY3Nzc0OTk___V1_;
                richTextBox3.Text = "Title: Wildlife \nLeeftijd 12+. \nDuur 1:35:00 uur \nStart tijd: zaal 1: 8:00, zaal 2: 9:00, zaal 3: 10:00. \nTaal: Engels (NL sub). \nZichtbaar: IMAX, 3D, 2D.";
                pictureBox4.Image = Properties.Resources._865580314a24d809e6fb0f12ce72e738;
                richTextBox4.Text = "Title: Fight Club \nLeeftijd 16+. \nDuur 1:25:00 uur. \nStart tijd: zaal 12: 16:00, zaal 14: 18:00, zaal 16: 20:00. \nTaal: Nederlands. \nZichtbaar: 2D.";
            }
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Thursday)
            {
                pictureBox1.Image = Properties.Resources._51Av5azGomL__AC_;
                richTextBox1.Text = "Title: The Dark Knight Rises \nLeeftijd: 16+ \nDuur 1:30:00 uur. \nStart tijd: zaal 3 15:00, zaal 8 16:00\nTaal: Engels (NL ondertiteling).\nZichtbaar: IMAX, 3D, 2D.";
                pictureBox2.Image = Properties.Resources.MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM___V1_;
                richTextBox2.Text = "Title: The Godfather \nLeeftijd: 18+ \nDuur 1:25:00 uur. \nStart tijd: zaal 5 17:00, zaal 6 19:00, zaal 4 21:00\nTaal: Engels.\nZichtbaar: IMAX, 2D.";
                pictureBox3.Image = Properties.Resources.peter_rabbit_movie_2_novelisation;
                richTextBox3.Text = "Title: Peter Rabbit 2: The Runaway \nLeeftijd: 6+. \nDuur 1:20:00 uur. \nStart tijd:  zaal 6: 9:00, zaal 8: 12:00, zaal 10: 15:00. \nTaal: Nederlands. \nZichtbaar: 3D, 2D.";
                pictureBox4.Image = Properties.Resources._865580314a24d809e6fb0f12ce72e738;
                richTextBox4.Text = "Title: Fight Club. \nLeeftijd 16+. \nDuur 1:25:00 uur. \nStart tijd: zaal 12: 16:00, zaal 14: 18:00, zaal 16: 20:00. \nTaal: Nederlands. \nZichtbaar: 2D.";
            }
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Friday)
            {
                pictureBox1.Image = Properties.Resources._51Av5azGomL__AC_;
                richTextBox1.Text = "Title: The Dark Knight Rises \nLeeftijd: 16+ \nDuur 1:30:00 uur. \nStart tijd: zaal 3 15:00, zaal 8 16:00\nTaal: Engels (NL ondertiteling).\nZichtbaar: IMAX, 3D, 2D.";
                pictureBox2.Image = Properties.Resources._81kz06oSUeL__AC_SL1500_;
                richTextBox2.Text = "Title: Interstellar \nLeeftijd: 11+ \nDuur 1:25:00 uur. \nStart tijd: zaal 7 12:00, zaal 15 15:00\nTaal: Engels (NL ondertiteling).\nZichtbaar: IMAX, 3D, 2D.";
                pictureBox3.Image = Properties.Resources.MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM___V1_;
                richTextBox3.Text = "Title: The Godfather \nLeeftijd: 18+ \nDuur 1:25:00 uur. \nStart tijd: zaal 5 17:00, zaal 6 19:00, zaal 4 21:00\nTaal: Engels.\nZichtbaar: IMAX, 2D.";
                pictureBox4.Image = Properties.Resources.THE_LORD_OF_THE_RINGS_THE_TWO_TOWERS_Frodo_Reprint_2002_REPRINT_CINEMA_POSTER__74417_1534256853;
                richTextBox4.Text = "Title: The Lord of the Rings: The Two Towers  \nLeeftijd: 14+ \nDuur 3:25:00 uur. \nStart tijd: zaal 1 12:00, zaal 2 13:00, zaal 3 14:00\nTaal: Engels.\nZichtbaar: IMAX, 2D.";
            }
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Saturday)
            {
                pictureBox1.Image = Properties.Resources.peter_rabbit_movie_2_novelisation;
                richTextBox1.Text = "Title: Peter Rabbit 2: The Runaway \nLeeftijd: 6+. \nDuur 1:20:00 uur. \nStart tijd:  zaal 6: 9:00, zaal 8: 12:00, zaal 10: 15:00. \nTaal: Nederlands. \nZichtbaar: 3D, 2D.";
                pictureBox2.Image = Properties.Resources.MV5BNmU4NTc0ZTgtNjliOC00NTM2LWE3NDktNGJiNzc2YzY3ZjA2XkEyXkFqcGdeQXVyNDg4NjY5OTQ___V1_;
                richTextBox2.Text = "Title: IO \nleeftijd 12+. \nDuur: 1:30:00 uur \nStart tijd: zaal 12: 13:00, zaal 13: 14:00 \nTaal: Nederlands \nZichtbaar: 3D, 2D.";
                pictureBox3.Image = Properties.Resources.THE_LORD_OF_THE_RINGS_THE_TWO_TOWERS_Frodo_Reprint_2002_REPRINT_CINEMA_POSTER__74417_1534256853;
                richTextBox3.Text = "Title: The Lord of the Rings: The Two Towers  \nLeeftijd: 14+ \nDuur 3:25:00 uur. \nStart tijd: zaal 1 12:00, zaal 2 13:00, zaal 3 14:00\nTaal: Engels.\nZichtbaar: IMAX, 2D.";
                pictureBox4.Image = Properties.Resources._865580314a24d809e6fb0f12ce72e738;
                richTextBox4.Text = "Title: Fight Club \nLeeftijd 16+. \nDuur 1:25:00 uur. \nStart tijd: zaal 12: 16:00, zaal 14: 18:00, zaal 16: 20:00. \nTaal: Nederlands. \nZichtbaar: 2D.";
            }
            else if (dateTimePicker1.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                pictureBox1.Image = Properties.Resources._51Av5azGomL__AC_;
                richTextBox1.Text = "Title: The Dark Knight Rises \nLeeftijd: 16+ \nDuur 1:30:00 uur. \nStart tijd: zaal 3 15:00, zaal 8 16:00\nTaal: Engels (NL ondertiteling).\nZichtbaar: IMAX, 3D, 2D.";
                pictureBox2.Image = Properties.Resources.THE_LORD_OF_THE_RINGS_THE_TWO_TOWERS_Frodo_Reprint_2002_REPRINT_CINEMA_POSTER__74417_1534256853;
                richTextBox2.Text = "Title: The Lord of the Rings: The Two Towers  \nLeeftijd: 14+ \nDuur 3:25:00 uur. \nStart tijd: zaal 1 12:00, zaal 2 13:00, zaal 3 14:00\nTaal: Engels.\nZichtbaar: IMAX, 2D.";
                pictureBox3.Image = Properties.Resources.MV5BOTNlZWY2ZGQtY2U1ZS00Mjc5LWExNjgtM2Q4YzQyYTlmNjZhXkEyXkFqcGdeQXVyODY3Nzc0OTk___V1_;
                richTextBox3.Text = "Title: Wildlife \nLeeftijd 12+. \nDuur 1:35:00 uur \nStart tijd: zaal 1: 8:00, zaal 2: 9:00, zaal 3: 10:00. \nTaal: Engels (NL sub). \nZichtbaar: IMAX, 3D, 2D.";
                pictureBox4.Image = Properties.Resources._865580314a24d809e6fb0f12ce72e738;
                richTextBox4.Text = "Title: Fight Club \nLeeftijd 16+. \nDuur 1:25:00 uur. \nStart tijd: zaal 12: 16:00, zaal 14: 18:00, zaal 16: 20:00. \nTaal: Nederlands. \nZichtbaar: 2D.";
            }
        }

        private void btnBestel1_Click(object sender, EventArgs e)
        {
            form = 1;
            date = dateTimePicker1.Text;
            MovieTitle(richTextBox1.Text);
            pic = this.pictureBox1.Image;
            this.Hide();
            Reservatie reservatie = new Reservatie();
            reservatie.Show();
        }

        private void btnBestel2_Click(object sender, EventArgs e)
        {
            form = 1;
            date = dateTimePicker1.Text;
            MovieTitle(richTextBox2.Text);
            pic = this.pictureBox2.Image;
            this.Hide();
            Reservatie reservatie = new Reservatie();
            reservatie.Show();
        }

        private void btnBestel3_Click(object sender, EventArgs e)
        {
            form = 1;
            date = dateTimePicker1.Text;
            MovieTitle(richTextBox3.Text);
            pic = this.pictureBox3.Image;
            this.Hide();
            Reservatie reservatie = new Reservatie();
            reservatie.Show();
        }

        private void btnBestel4_Click(object sender, EventArgs e)
        {
            form = 1;
            date = dateTimePicker1.Text;
            MovieTitle(richTextBox4.Text);
            pic = this.pictureBox4.Image;
            this.Hide();
            Reservatie reservatie = new Reservatie();
            reservatie.Show();
        }

        public string MovieTitle(string movietitle)
        {
            if(movietitle.Contains("Interstellar"))
            {
                return movie = "Interstellar";
            }
            else if(movietitle.Contains("The Dark Knight Rises"))
            {
                return movie = "The Dark Knight Rises";
            }
            else if (movietitle.Contains("Joker"))
            {
                return movie = "Joker";
            }
            else if (movietitle.Contains("Avengers Endgame"))
            {
                return movie = "Avengers: Endgame";
            }
            else if (movietitle.Contains("The Godfather"))
            {
                return movie = "The Godfather";
            }
            else if (movietitle.Contains("The Lord of the Rings: The Two Towers"))
            {
                return movie = "The Lord of the Rings: The Two Towers";
            }
            else if (movietitle.Contains("The Lord of the Rings Fellowship of the Ring"))
            {
                return movie = "The Lord of the Rings: Fellowship of the Ring";
            }
            else if (movietitle.Contains("The Lord of the Rings: The Return of the King"))
            {
                return movie = "The Lord of the Rings: The Return of the King";
            }
            else if (movietitle.Contains("Peter Rabbit 2: The Runaway"))
            {
                return movie = "Peter Rabbit 2: The Runaway";
            }
            else if (movietitle.Contains("IO"))
            {
                return movie = "IO";
            }
            else if (movietitle.Contains("Fight Club"))
            {
                return movie = "Fight Club";
            }
            else if (movietitle.Contains("Wildlife"))
            {
                return movie = "Wildlife";
            }

            return "";
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Programma_Load(object sender, EventArgs e)
        {
            Zoeken.flag = false;
        }
    }
}