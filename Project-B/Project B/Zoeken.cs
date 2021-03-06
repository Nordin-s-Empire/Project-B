﻿using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Drawing.Printing;

namespace Project_B
{
    public partial class Zoeken : Form
    {
        public static Film[] filmlijst;
        public int page = 1;
        public Film[] display;
        public static string movie;
        public static bool flag = false;
        public static DateTime date;

        public Zoeken()
        {
            InitializeComponent();
            StreamReader r = new StreamReader(@"../../Films.json");
            string json = r.ReadToEnd();
            filmlijst = JsonConvert.DeserializeObject<Film[]>(json);
            Bitmap[] Posters = new Bitmap[]
            {
                Properties.Resources.avengers_endgame_original_movie_poster_15x21_in_2019_anthony_russo_robert_downey_jr,
                Properties.Resources._865580314a24d809e6fb0f12ce72e738,
                Properties.Resources._81kz06oSUeL__AC_SL1500_,
                Properties.Resources.MV5BNmU4NTc0ZTgtNjliOC00NTM2LWE3NDktNGJiNzc2YzY3ZjA2XkEyXkFqcGdeQXVyNDg4NjY5OTQ___V1_,
                Properties.Resources._268x0w,
                Properties.Resources.peter_rabbit_movie_2_novelisation,
                Properties.Resources._51Av5azGomL__AC_,
                Properties.Resources.MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM___V1_,
                Properties.Resources.baaf0f0f37c294c779ed9d52896e9d52,
                Properties.Resources._7e6b6743a7e45d096838abd67b2464e2,
                Properties.Resources.THE_LORD_OF_THE_RINGS_THE_TWO_TOWERS_Frodo_Reprint_2002_REPRINT_CINEMA_POSTER__74417_1534256853,
                Properties.Resources.MV5BOTNlZWY2ZGQtY2U1ZS00Mjc5LWExNjgtM2Q4YzQyYTlmNjZhXkEyXkFqcGdeQXVyODY3Nzc0OTk___V1_
            };
            for(int i = 0; i < filmlijst.Length; i++)
            {
                filmlijst[i].Poster = Posters[i];
            }
            display = filmlijst;
        }
        public void Visual(Film[] d)
        {
            if((d.Length >= 1) && (page == 1))
            {
                label2.Show();
                label12.Show();
                richTextBox1.Show();
                pictureBox1.Show();
                label2.Text = d[0].Titel;
                label12.Text = d[0].LeeftijdsCategorie;
                richTextBox1.Text = d[0].Samenvatting;
                pictureBox1.Image = d[0].Poster;
            }
            else
            {
                label2.Hide();
                label12.Hide();
                richTextBox1.Hide();
                pictureBox1.Hide();
            }
            if ((d.Length >= 2) && (page == 1))
            {
                label3.Show();
                label13.Show();
                richTextBox2.Show();
                pictureBox2.Show();
                label3.Text = d[1].Titel;
                label13.Text = d[1].LeeftijdsCategorie;
                richTextBox2.Text = d[1].Samenvatting;
                pictureBox2.Image = d[1].Poster;
            }
            else
            {
                label3.Hide();
                label13.Hide();
                richTextBox2.Hide();
                pictureBox2.Hide();
            }
            if ((d.Length >= 3) && (page == 1))
            {
                label4.Show();
                label14.Show();
                richTextBox11.Show();
                pictureBox3.Show();
                label4.Text = d[2].Titel;
                label14.Text = d[2].LeeftijdsCategorie;
                richTextBox11.Text = d[2].Samenvatting;
                pictureBox3.Image = d[2].Poster;
            }
            else
            {
                label4.Hide();
                label14.Hide();
                richTextBox11.Hide();
                pictureBox3.Hide();
            }
            if ((d.Length >= 4) && (page == 1))
            {
                label5.Show();
                label15.Show();
                richTextBox4.Show();
                pictureBox4.Show();
                label5.Text = d[3].Titel;
                label15.Text = d[3].LeeftijdsCategorie;
                richTextBox4.Text = d[3].Samenvatting;
                pictureBox4.Image = d[3].Poster;
            }
            else
            {
                label5.Hide();
                label15.Hide();
                richTextBox4.Hide();
                pictureBox4.Hide();
            }
            if ((d.Length >= 5) && (page == 1))
            {
                label6.Show();
                label16.Show();
                richTextBox5.Show();
                pictureBox5.Show();
                label6.Text = d[4].Titel;
                label16.Text = d[4].LeeftijdsCategorie;
                richTextBox5.Text = d[4].Samenvatting;
                pictureBox5.Image = d[4].Poster;
            }
            else
            {
                label6.Hide();
                label16.Hide();
                richTextBox5.Hide();
                pictureBox5.Hide();
            }
            if ((d.Length >= 6) && (page == 1))
            {
                label7.Show();
                label17.Show();
                richTextBox6.Show();
                pictureBox10.Show();
                label7.Text = d[5].Titel;
                label17.Text = d[5].LeeftijdsCategorie;
                richTextBox6.Text = d[5].Samenvatting;
                pictureBox10.Image = d[5].Poster;
            }
            else
            {
                label7.Hide();
                label17.Hide();
                richTextBox6.Hide();
                pictureBox10.Hide();
            }
            if ((d.Length >= 7) && (page == 1))
            {
                label8.Show();
                label18.Show();
                richTextBox7.Show();
                pictureBox6.Show();
                label8.Text = d[6].Titel;
                label18.Text = d[6].LeeftijdsCategorie;
                richTextBox7.Text = d[6].Samenvatting;
                pictureBox6.Image = d[6].Poster;
            }
            else
            {
                label8.Hide();
                label18.Hide();
                richTextBox7.Hide();
                pictureBox6.Hide();
            }
            if ((d.Length >= 8) && (page == 1))
            {
                label9.Show();
                label19.Show();
                richTextBox8.Show();
                pictureBox9.Show();
                label9.Text = d[7].Titel;
                label19.Text = d[7].LeeftijdsCategorie;
                richTextBox8.Text = d[7].Samenvatting;
                pictureBox9.Image = d[7].Poster;
            }
            else
            {
                label9.Hide();
                label19.Hide();
                richTextBox8.Hide();
                pictureBox9.Hide();
            }
            if ((d.Length >= 9) && (page == 1))
            {
                label10.Show();
                label20.Show();
                richTextBox9.Show();
                pictureBox8.Show();
                label10.Text = d[8].Titel;
                label20.Text = d[8].LeeftijdsCategorie;
                richTextBox9.Text = d[8].Samenvatting;
                pictureBox8.Image = d[8].Poster;
            }
            else
            {
                label10.Hide();
                label20.Hide();
                richTextBox9.Hide();
                pictureBox8.Hide();
            }
            if ((d.Length >= 10) && (page == 1))
            {
                label11.Show();
                label21.Show();
                richTextBox10.Show();
                pictureBox7.Show();
                label11.Text = d[9].Titel;
                label21.Text = d[9].LeeftijdsCategorie;
                richTextBox10.Text = d[9].Samenvatting;
                pictureBox7.Image = d[9].Poster;
            }
            else
            {
                label11.Hide();
                label21.Hide();
                richTextBox10.Hide();
                pictureBox7.Hide();
            }
            if ((d.Length >= 11) && (page == 2))
            {
                label2.Show();
                label12.Show();
                richTextBox1.Show();
                pictureBox1.Show();
                label2.Text = d[10].Titel;
                label12.Text = d[10].LeeftijdsCategorie;
                richTextBox1.Text = d[10].Samenvatting;
                pictureBox1.Image = d[10].Poster;
            }
            else if(page == 2)
            {
                label2.Hide();
                label12.Hide();
                richTextBox1.Hide();
                pictureBox1.Hide();
            }
            if ((d.Length >= 12) && (page == 2))
            {
                label3.Show();
                label13.Show();
                richTextBox2.Show();
                pictureBox2.Show();
                label3.Text = d[11].Titel;
                label13.Text = d[11].LeeftijdsCategorie;
                richTextBox2.Text = d[11].Samenvatting;
                pictureBox2.Image = d[11].Poster;
            }
            else if(page == 2)
            {
                label3.Hide();
                label13.Hide();
                richTextBox2.Hide();
                pictureBox2.Hide();
            }
            if(page == 2)
            {
                label4.Hide();
                label14.Hide();
                richTextBox11.Hide();
                pictureBox3.Hide();
                label5.Hide();
                label15.Hide();
                richTextBox4.Hide();
                pictureBox4.Hide();
                label6.Hide();
                label16.Hide();
                richTextBox5.Hide();
                pictureBox5.Hide();
                label7.Hide();
                label17.Hide();
                richTextBox6.Hide();
                pictureBox10.Hide();
                label8.Hide();
                label18.Hide();
                richTextBox7.Hide();
                pictureBox6.Hide();
                label9.Hide();
                label19.Hide();
                richTextBox8.Hide();
                pictureBox9.Hide();
                label10.Hide();
                label20.Hide();
                richTextBox9.Hide();
                pictureBox8.Hide();
            }

        }

        private void Zoeken_Load(object sender, EventArgs e)
        {
            Zoekfunctie(Form1.input, listBox1.Text);
            flag = false;
        }

        private void btnZoeken_Click(object sender, EventArgs e)
        {
            Zoekfunctie(textBox1.Text, listBox1.Text);
        }
        // 1 t/m 5 - 10 - 6 - 9 t/m 7
        public void Zoekfunctie(string input, string genre)
        {
            page = 1;
            if (input == "" && genre == "")
            {
                Visual(filmlijst);
            }
            else
            {
                int count = 0;
                for (int i = 0; i < filmlijst.Length; i++)
                {
                    filmlijst[i].Show = false;
                }
                for(int i = 0; i < filmlijst.Length; i++) 
                {
                    bool g = false;
                    for (int j = 0; j < filmlijst[i].Genre.Length; j++)
                    {
                        if (genre == filmlijst[i].Genre[j] || genre == "")
                        {
                            g = true;
                        }
                    }
                    string title = filmlijst[i].Titel;
                    if (title.Contains(input, StringComparison.OrdinalIgnoreCase) && g)
                    {
                        filmlijst[i].Show = true;
                        count++;
                    }
                }
                Film[] zoekresultaten = new Film[count];
                int x = 0;
                for (int i = 0; i < filmlijst.Length; i++)
                {
                    if (filmlijst[i].Show)
                    {
                        zoekresultaten[x] = filmlijst[i];
                        x++;
                    }
                }
                if(zoekresultaten.Length < 11)
                {
                    button1.Hide();
                    button2.Hide();
                }
                else
                {
                    button1.Show();
                    button2.Show();
                }
                display = zoekresultaten;
                Visual(zoekresultaten);
                
            }
           
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(252, 167, 88);
            button2.BackColor = Color.Gray;
            page = 1;
            Visual(display);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(252, 167, 88);
            button1.BackColor = Color.Gray;
            page = 2;
            Visual(display);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            flag = true;
            for(int i = 0; i < filmlijst.Length; i++)
            {
                if(pictureBox1.Image == filmlijst[i].Poster)
                {
                    movie = filmlijst[i].Titel;
                }
            }
            var pic = pictureBox1.Image;
            MessageBox.Show("Selecteer een tijd en datum:");

            this.Hide();
            FIlmInfo film = new FIlmInfo();
            film.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            flag = true;
            for (int i = 0; i < filmlijst.Length; i++)
            {
                if (pictureBox2.Image == filmlijst[i].Poster)
                {
                    movie = filmlijst[i].Titel;
                }
            }
            var pic = pictureBox2.Image;
            this.Hide();
            FIlmInfo film = new FIlmInfo();
            film.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            flag = true;
            for (int i = 0; i < filmlijst.Length; i++)
            {
                if (pictureBox3.Image == filmlijst[i].Poster)
                {
                    movie = filmlijst[i].Titel;
                }
            }
            var pic = pictureBox3.Image;
            this.Hide();
            FIlmInfo film = new FIlmInfo();
            film.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            flag = true;
            for (int i = 0; i < filmlijst.Length; i++)
            {
                if (pictureBox4.Image == filmlijst[i].Poster)
                {
                    movie = filmlijst[i].Titel;
                }
            }
            var pic = pictureBox4.Image;
            this.Hide();
            FIlmInfo film = new FIlmInfo();
            film.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            flag = true;
            for (int i = 0; i < filmlijst.Length; i++)
            {
                if (pictureBox5.Image == filmlijst[i].Poster)
                {
                    movie = filmlijst[i].Titel;
                }
            }
            var pic = pictureBox5.Image;
            this.Hide();
            FIlmInfo film = new FIlmInfo();
            film.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            flag = true;
            for (int i = 0; i < filmlijst.Length; i++)
            {
                if (pictureBox10.Image == filmlijst[i].Poster)
                {
                    movie = filmlijst[i].Titel;
                }
            }
            var pic = pictureBox10.Image;
            this.Hide();
            FIlmInfo film = new FIlmInfo();
            film.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            flag = true;
            for (int i = 0; i < filmlijst.Length; i++)
            {
                if (pictureBox6.Image == filmlijst[i].Poster)
                {
                    movie = filmlijst[i].Titel;
                }
            }
            var pic = pictureBox6.Image;
            this.Hide();
            FIlmInfo film = new FIlmInfo();
            film.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            flag = true;
            for (int i = 0; i < filmlijst.Length; i++)
            {
                if (pictureBox9.Image == filmlijst[i].Poster)
                {
                    movie = filmlijst[i].Titel;
                }
            }
            var pic = pictureBox9.Image;
            this.Hide();
            FIlmInfo film = new FIlmInfo();
            film.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            flag = true;
            for (int i = 0; i < filmlijst.Length; i++)
            {
                if (pictureBox8.Image == filmlijst[i].Poster)
                {
                    movie = filmlijst[i].Titel;
                }
            }
            var pic = pictureBox8.Image;
            this.Hide();
            FIlmInfo film = new FIlmInfo();
            film.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            flag = true;
            for (int i = 0; i < filmlijst.Length; i++)
            {
                if (pictureBox7.Image == filmlijst[i].Poster)
                {
                    movie = filmlijst[i].Titel;
                }
            }
            var pic = pictureBox7.Image;
            this.Hide();
            FIlmInfo film = new FIlmInfo();
            film.Show();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Zoekfunctie(textBox1.Text, listBox1.Text);
        }
    }

}
