using System;
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

namespace Project_B
{
    public partial class Zoeken : Form
    {
        public static List<Film> filmlijst;

        public Zoeken()
        {
            InitializeComponent();
            StreamReader r = new StreamReader(@"../../Films.json");
            string json = r.ReadToEnd();
            filmlijst = JsonConvert.DeserializeObject<List<Film>>(json);
            string input = textBox1.Text;

            label2.Text = filmlijst[0].Titel;
            label12.Text = filmlijst[0].LeeftijdsCategorie;
            richTextBox1.Text = filmlijst[0].Samenvatting;
                                  
            label3.Text = filmlijst[1].Titel;
            label13.Text = filmlijst[1].LeeftijdsCategorie;
            richTextBox2.Text = filmlijst[1].Samenvatting;

            label4.Text = filmlijst[2].Titel;
            label14.Text = filmlijst[2].LeeftijdsCategorie;
            richTextBox11.Text = filmlijst[2].Samenvatting;
            
            label5.Text = filmlijst[3].Titel;
            label15.Text = filmlijst[3].LeeftijdsCategorie;
            richTextBox4.Text = filmlijst[3].Samenvatting;
                        
            label6.Text = filmlijst[4].Titel;
            label16.Text = filmlijst[4].LeeftijdsCategorie;
            richTextBox5.Text = filmlijst[4].Samenvatting;
                        
            label7.Text = filmlijst[5].Titel;
            label17.Text = filmlijst[5].LeeftijdsCategorie;
            richTextBox6.Text = filmlijst[5].Samenvatting;
            
            label8.Text = filmlijst[6].Titel;
            label18.Text = filmlijst[6].LeeftijdsCategorie;
            richTextBox7.Text = filmlijst[6].Samenvatting;
            
            label9.Text = filmlijst[7].Titel;
            label19.Text = filmlijst[7].LeeftijdsCategorie;
            richTextBox8.Text = filmlijst[7].Samenvatting;
            
            label10.Text = filmlijst[8].Titel;
            label20.Text = filmlijst[8].LeeftijdsCategorie;
            richTextBox9.Text = filmlijst[8].Samenvatting;
            
            label11.Text = filmlijst[9].Titel;
            label21.Text = filmlijst[9].LeeftijdsCategorie;
            richTextBox10.Text = filmlijst[9].Samenvatting;
        }

        private void btnZoeken_Click(object sender, EventArgs e)
        {
            Zoekfunctie(textBox1.Text);
        }
        // 1 t/m 5 - 10 - 6 - 9 t/m 7
        public void Zoekfunctie(string input)
        {
            if (input == "")
            {
                for (int i = 0; i < 10; i++)
                {
                    filmlijst[i].Show = true;
                }
                pictureBox1.Show();
                label2.Show();
                label12.Show();
                richTextBox1.Show();

                pictureBox2.Show();
                label3.Show();
                label13.Show();
                richTextBox2.Show();

                pictureBox3.Show();
                label4.Show();
                label14.Show();
                richTextBox11.Show();

                pictureBox4.Show();
                label5.Show();
                label15.Show();
                richTextBox4.Show();

                pictureBox5.Show();
                label6.Show();
                label16.Show();
                richTextBox5.Show();

                pictureBox10.Show();
                label7.Show();
                label17.Show();
                richTextBox6.Show();
                pictureBox6.Show();
                label8.Show();
                label18.Show();
                richTextBox7.Show();
                pictureBox9.Show();
                label9.Show();
                label19.Show();
                richTextBox8.Show();
                pictureBox8.Show();
                label10.Show();
                label20.Show();
                richTextBox9.Show();
                pictureBox7.Show();
                label11.Show();
                label21.Show();
                richTextBox10.Show();

                pictureBox1.Image = Properties.Resources.MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM___V1_;
                pictureBox2.Image = Properties.Resources.The_Godfather__Part_II;
                pictureBox3.Image = Properties.Resources.The_Godfather_Part_III;
                pictureBox4.Image = Properties.Resources.Jumanji;
                pictureBox5.Image = Properties.Resources.Fast___Furious;
            }
            else
            {
                int count = 0;
                for (int i = 0; i < 10; i++)
                {
                    filmlijst[i].Show = false;
                }
                for(int i = 0; i < 10; i++) 
                { 
                    for (int j = 0; j < filmlijst[i].Identifier.Length; j++)
                    {
                        if (input == filmlijst[i].Identifier[j] || input == filmlijst[i].Titel)
                        {
                            filmlijst[i].Show = true;
                            count++;
                        }
                    }
                }
                Film[] zoekresultaten = new Film[count];
                int x = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (filmlijst[i].Show)
                    {
                        zoekresultaten[x] = filmlijst[i];
                        x++;
                    }
                }
                if (zoekresultaten.Length == 0)
                {
                    pictureBox1.Hide();
                    label2.Hide();
                    label12.Hide();
                    richTextBox1.Hide();
                    pictureBox2.Hide();
                    label3.Hide();
                    label13.Hide();
                    richTextBox2.Hide();
                    pictureBox3.Hide();
                    label4.Hide();
                    label14.Hide();
                    richTextBox11.Hide();
                    pictureBox4.Hide();
                    label5.Hide();
                    label15.Hide();
                    richTextBox4.Hide();
                    pictureBox5.Hide();
                    label6.Hide();
                    label16.Hide();
                    richTextBox5.Hide();
                    pictureBox10.Hide();
                    label7.Hide();
                    label17.Hide();
                    richTextBox6.Hide();
                    pictureBox6.Hide();
                    label8.Hide();
                    label18.Hide();
                    richTextBox7.Hide();
                    pictureBox9.Hide();
                    label9.Hide();
                    label19.Hide();
                    richTextBox8.Hide();
                    pictureBox8.Hide();
                    label10.Hide();
                    label20.Hide();
                    richTextBox9.Hide();
                    pictureBox7.Hide();
                    label11.Hide();
                    label21.Hide();
                    richTextBox10.Hide();
                }
                else if (zoekresultaten.Length == 1)
                {
                    if (zoekresultaten[0].Titel == "The Godfather")
                    {
                        pictureBox1.Image = Properties.Resources.MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM___V1_;
                    }
                    else if (zoekresultaten[0].Titel == "The Godfather Part II")
                    {
                        pictureBox1.Image = Properties.Resources.The_Godfather__Part_II;
                    }
                    else if (zoekresultaten[0].Titel == "The Godfather Part III")
                    {
                        pictureBox1.Image = Properties.Resources.The_Godfather_Part_III;
                    }
                    else if (zoekresultaten[0].Titel == "Jumanji: The Next Level")
                    {
                        pictureBox1.Image = Properties.Resources.Jumanji;
                    }
                    else if (zoekresultaten[0].Titel == "Fast and Furious: Hobbs and Shaw")
                    {
                        pictureBox1.Image = Properties.Resources.Fast___Furious;
                    }
                    else if (zoekresultaten[0].Titel == "April, May en June")
                    {
                        pictureBox1.Image = Properties.Resources.April;
                    }
                    else if (zoekresultaten[0].Titel == "The Gentlemen")
                    {
                        pictureBox1.Image = Properties.Resources.Gentlemen;
                    }
                    else if (zoekresultaten[0].Titel == "Bloodshot")
                    {
                        pictureBox1.Image = Properties.Resources.Bloodshot;
                    }
                    else if (zoekresultaten[0].Titel == "Joker")
                    {
                        pictureBox1.Image = Properties.Resources._268x0w;
                    }
                    else if (zoekresultaten[0].Titel == "Avengers: Endgame")
                    {
                        pictureBox1.Image = Properties.Resources.avengers_endgame_original_movie_poster_15x21_in_2019_anthony_russo_robert_downey_jr;
                    }

                    label2.Text = zoekresultaten[0].Titel;
                    label12.Text = zoekresultaten[0].LeeftijdsCategorie;
                    richTextBox1.Text = zoekresultaten[0].Samenvatting;

                    pictureBox1.Show();
                    label2.Show();
                    label12.Show();
                    richTextBox1.Show();

                    pictureBox2.Hide();
                    label3.Hide();
                    label13.Hide();
                    richTextBox2.Hide();
                    pictureBox3.Hide();
                    label4.Hide();
                    label14.Hide();
                    richTextBox11.Hide();
                    pictureBox4.Hide();
                    label5.Hide();
                    label15.Hide();
                    richTextBox4.Hide();
                    pictureBox5.Hide();
                    label6.Hide();
                    label16.Hide();
                    richTextBox5.Hide();
                    pictureBox10.Hide();
                    label7.Hide();
                    label17.Hide();
                    richTextBox6.Hide();
                    pictureBox6.Hide();
                    label8.Hide();
                    label18.Hide();
                    richTextBox7.Hide();
                    pictureBox9.Hide();
                    label9.Hide();
                    label19.Hide();
                    richTextBox8.Hide();
                    pictureBox8.Hide();
                    label10.Hide();
                    label20.Hide();
                    richTextBox9.Hide();
                    pictureBox7.Hide();
                    label11.Hide();
                    label21.Hide();
                    richTextBox10.Hide();
                }
                else if (zoekresultaten.Length == 2)
                {
                    if (zoekresultaten[0].Titel == "The Godfather")
                    {
                        pictureBox1.Image = Properties.Resources.MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM___V1_;
                    }
                    else if (zoekresultaten[0].Titel == "The Godfather Part II")
                    {
                        pictureBox1.Image = Properties.Resources.The_Godfather__Part_II;
                    }
                    else if (zoekresultaten[0].Titel == "The Godfather Part III")
                    {
                        pictureBox1.Image = Properties.Resources.The_Godfather_Part_III;
                    }
                    else if (zoekresultaten[0].Titel == "Jumanji: The Next Level")
                    {
                        pictureBox1.Image = Properties.Resources.Jumanji;
                    }
                    else if (zoekresultaten[0].Titel == "Fast and Furious: Hobbs and Shaw")
                    {
                        pictureBox1.Image = Properties.Resources.Fast___Furious;
                    }
                    else if (zoekresultaten[0].Titel == "April, May en June")
                    {
                        pictureBox1.Image = Properties.Resources.April;
                    }
                    else if (zoekresultaten[0].Titel == "The Gentlemen")
                    {
                        pictureBox1.Image = Properties.Resources.Gentlemen;
                    }
                    else if (zoekresultaten[0].Titel == "Bloodshot")
                    {
                        pictureBox1.Image = Properties.Resources.Bloodshot;
                    }
                    else if (zoekresultaten[0].Titel == "Joker")
                    {
                        pictureBox1.Image = Properties.Resources._268x0w;
                    }
                    else if (zoekresultaten[0].Titel == "Avengers: Endgame")
                    {
                        pictureBox1.Image = Properties.Resources.avengers_endgame_original_movie_poster_15x21_in_2019_anthony_russo_robert_downey_jr;
                    }
                    if (zoekresultaten[1].Titel == "The Godfather")
                    {
                        pictureBox2.Image = Properties.Resources.MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM___V1_;
                    }
                    else if (zoekresultaten[1].Titel == "The Godfather Part II")
                    {
                        pictureBox2.Image = Properties.Resources.The_Godfather__Part_II;
                    }
                    else if (zoekresultaten[1].Titel == "The Godfather Part III")
                    {
                        pictureBox2.Image = Properties.Resources.The_Godfather_Part_III;
                    }
                    else if (zoekresultaten[1].Titel == "Jumanji: The Next Level")
                    {
                        pictureBox2.Image = Properties.Resources.Jumanji;
                    }
                    else if (zoekresultaten[1].Titel == "Fast and Furious: Hobbs and Shaw")
                    {
                        pictureBox2.Image = Properties.Resources.Fast___Furious;
                    }
                    else if (zoekresultaten[1].Titel == "April, May en June")
                    {
                        pictureBox2.Image = Properties.Resources.April;
                    }
                    else if (zoekresultaten[1].Titel == "The Gentlemen")
                    {
                        pictureBox2.Image = Properties.Resources.Gentlemen;
                    }
                    else if (zoekresultaten[1].Titel == "Bloodshot")
                    {
                        pictureBox2.Image = Properties.Resources.Bloodshot;
                    }
                    else if (zoekresultaten[1].Titel == "Joker")
                    {
                        pictureBox2.Image = Properties.Resources._268x0w;
                    }
                    else if (zoekresultaten[1].Titel == "Avengers: Endgame")
                    {
                        pictureBox2.Image = Properties.Resources.avengers_endgame_original_movie_poster_15x21_in_2019_anthony_russo_robert_downey_jr;
                    }

                    label2.Text = zoekresultaten[0].Titel;
                    label12.Text = zoekresultaten[0].LeeftijdsCategorie;
                    richTextBox1.Text = zoekresultaten[0].Samenvatting;

                    label3.Text = zoekresultaten[1].Titel;
                    label13.Text = zoekresultaten[1].LeeftijdsCategorie;
                    richTextBox2.Text = zoekresultaten[1].Samenvatting;

                    pictureBox1.Show();
                    label2.Show();
                    label12.Show();
                    richTextBox1.Show();

                    pictureBox2.Show();
                    label3.Show();
                    label13.Show();
                    richTextBox2.Show();

                    pictureBox3.Hide();
                    label4.Hide();
                    label14.Hide();
                    richTextBox11.Hide();
                    pictureBox4.Hide();
                    label5.Hide();
                    label15.Hide();
                    richTextBox4.Hide();
                    pictureBox5.Hide();
                    label6.Hide();
                    label16.Hide();
                    richTextBox5.Hide();
                    pictureBox10.Hide();
                    label7.Hide();
                    label17.Hide();
                    richTextBox6.Hide();
                    pictureBox6.Hide();
                    label8.Hide();
                    label18.Hide();
                    richTextBox7.Hide();
                    pictureBox9.Hide();
                    label9.Hide();
                    label19.Hide();
                    richTextBox8.Hide();
                    pictureBox8.Hide();
                    label10.Hide();
                    label20.Hide();
                    richTextBox9.Hide();
                    pictureBox7.Hide();
                    label11.Hide();
                    label21.Hide();
                    richTextBox10.Hide();
                }
                else if (zoekresultaten.Length == 3)
                {
                    if (zoekresultaten[0].Titel == "The Godfather")
                    {
                        pictureBox1.Image = Properties.Resources.MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM___V1_;
                    }
                    else if (zoekresultaten[0].Titel == "The Godfather Part II")
                    {
                        pictureBox1.Image = Properties.Resources.The_Godfather__Part_II;
                    }
                    else if (zoekresultaten[0].Titel == "The Godfather Part III")
                    {
                        pictureBox1.Image = Properties.Resources.The_Godfather_Part_III;
                    }
                    else if (zoekresultaten[0].Titel == "Jumanji: The Next Level")
                    {
                        pictureBox1.Image = Properties.Resources.Jumanji;
                    }
                    else if (zoekresultaten[0].Titel == "Fast and Furious: Hobbs and Shaw")
                    {
                        pictureBox1.Image = Properties.Resources.Fast___Furious;
                    }
                    else if (zoekresultaten[0].Titel == "April, May en June")
                    {
                        pictureBox1.Image = Properties.Resources.April;
                    }
                    else if (zoekresultaten[0].Titel == "The Gentlemen")
                    {
                        pictureBox1.Image = Properties.Resources.Gentlemen;
                    }
                    else if (zoekresultaten[0].Titel == "Bloodshot")
                    {
                        pictureBox1.Image = Properties.Resources.Bloodshot;
                    }
                    else if (zoekresultaten[0].Titel == "Joker")
                    {
                        pictureBox1.Image = Properties.Resources._268x0w;
                    }
                    else if (zoekresultaten[0].Titel == "Avengers: Endgame")
                    {
                        pictureBox1.Image = Properties.Resources.avengers_endgame_original_movie_poster_15x21_in_2019_anthony_russo_robert_downey_jr;
                    }
                    if (zoekresultaten[1].Titel == "The Godfather")
                    {
                        pictureBox2.Image = Properties.Resources.MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM___V1_;
                    }
                    else if (zoekresultaten[1].Titel == "The Godfather Part II")
                    {
                        pictureBox2.Image = Properties.Resources.The_Godfather__Part_II;
                    }
                    else if (zoekresultaten[1].Titel == "The Godfather Part III")
                    {
                        pictureBox2.Image = Properties.Resources.The_Godfather_Part_III;
                    }
                    else if (zoekresultaten[1].Titel == "Jumanji: The Next Level")
                    {
                        pictureBox2.Image = Properties.Resources.Jumanji;
                    }
                    else if (zoekresultaten[1].Titel == "Fast and Furious: Hobbs and Shaw")
                    {
                        pictureBox2.Image = Properties.Resources.Fast___Furious;
                    }
                    else if (zoekresultaten[1].Titel == "April, May en June")
                    {
                        pictureBox2.Image = Properties.Resources.April;
                    }
                    else if (zoekresultaten[1].Titel == "The Gentlemen")
                    {
                        pictureBox2.Image = Properties.Resources.Gentlemen;
                    }
                    else if (zoekresultaten[1].Titel == "Bloodshot")
                    {
                        pictureBox2.Image = Properties.Resources.Bloodshot;
                    }
                    else if (zoekresultaten[1].Titel == "Joker")
                    {
                        pictureBox2.Image = Properties.Resources._268x0w;
                    }
                    else if (zoekresultaten[1].Titel == "Avengers: Endgame")
                    {
                        pictureBox2.Image = Properties.Resources.avengers_endgame_original_movie_poster_15x21_in_2019_anthony_russo_robert_downey_jr;
                    }
                    if (zoekresultaten[2].Titel == "The Godfather")
                    {
                        pictureBox3.Image = Properties.Resources.MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM___V1_;
                    }
                    else if (zoekresultaten[2].Titel == "The Godfather Part II")
                    {
                        pictureBox3.Image = Properties.Resources.The_Godfather__Part_II;
                    }
                    else if (zoekresultaten[2].Titel == "The Godfather Part III")
                    {
                        pictureBox3.Image = Properties.Resources.The_Godfather_Part_III;
                    }
                    else if (zoekresultaten[2].Titel == "Jumanji: The Next Level")
                    {
                        pictureBox3.Image = Properties.Resources.Jumanji;
                    }
                    else if (zoekresultaten[2].Titel == "Fast and Furious: Hobbs and Shaw")
                    {
                        pictureBox3.Image = Properties.Resources.Fast___Furious;
                    }
                    else if (zoekresultaten[2].Titel == "April, May en June")
                    {
                        pictureBox3.Image = Properties.Resources.April;
                    }
                    else if (zoekresultaten[2].Titel == "The Gentlemen")
                    {
                        pictureBox3.Image = Properties.Resources.Gentlemen;
                    }
                    else if (zoekresultaten[2].Titel == "Bloodshot")
                    {
                        pictureBox3.Image = Properties.Resources.Bloodshot;
                    }
                    else if (zoekresultaten[2].Titel == "Joker")
                    {
                        pictureBox3.Image = Properties.Resources._268x0w;
                    }
                    else if (zoekresultaten[2].Titel == "Avengers: Endgame")
                    {
                        pictureBox3.Image = Properties.Resources.avengers_endgame_original_movie_poster_15x21_in_2019_anthony_russo_robert_downey_jr;
                    }
                    label2.Text = zoekresultaten[0].Titel;
                    label12.Text = zoekresultaten[0].LeeftijdsCategorie;
                    richTextBox1.Text = zoekresultaten[0].Samenvatting;

                    label3.Text = zoekresultaten[1].Titel;
                    label13.Text = zoekresultaten[1].LeeftijdsCategorie;
                    richTextBox2.Text = zoekresultaten[1].Samenvatting;

                    label4.Text = zoekresultaten[2].Titel;
                    label14.Text = zoekresultaten[2].LeeftijdsCategorie;
                    richTextBox11.Text = zoekresultaten[2].Samenvatting;

                    pictureBox1.Show();
                    label2.Show();
                    label12.Show();
                    richTextBox1.Show();

                    pictureBox2.Show();
                    label3.Show();
                    label13.Show();
                    richTextBox2.Show();

                    pictureBox3.Show();
                    label4.Show();
                    label14.Show();
                    richTextBox11.Show();

                    pictureBox4.Hide();
                    label5.Hide();
                    label15.Hide();
                    richTextBox4.Hide();
                    pictureBox5.Hide();
                    label6.Hide();
                    label16.Hide();
                    richTextBox5.Hide();
                    pictureBox10.Hide();
                    label7.Hide();
                    label17.Hide();
                    richTextBox6.Hide();
                    pictureBox6.Hide();
                    label8.Hide();
                    label18.Hide();
                    richTextBox7.Hide();
                    pictureBox9.Hide();
                    label9.Hide();
                    label19.Hide();
                    richTextBox8.Hide();
                    pictureBox8.Hide();
                    label10.Hide();
                    label20.Hide();
                    richTextBox9.Hide();
                    pictureBox7.Hide();
                    label11.Hide();
                    label21.Hide();
                    richTextBox10.Hide();
                }
                else if (zoekresultaten.Length == 4)
                {
                    if (zoekresultaten[0].Titel == "The Godfather")
                    {
                        pictureBox1.Image = Properties.Resources.MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM___V1_;
                    }
                    else if (zoekresultaten[0].Titel == "The Godfather Part II")
                    {
                        pictureBox1.Image = Properties.Resources.The_Godfather__Part_II;
                    }
                    else if (zoekresultaten[0].Titel == "The Godfather Part III")
                    {
                        pictureBox1.Image = Properties.Resources.The_Godfather_Part_III;
                    }
                    else if (zoekresultaten[0].Titel == "Jumanji: The Next Level")
                    {
                        pictureBox1.Image = Properties.Resources.Jumanji;
                    }
                    else if (zoekresultaten[0].Titel == "Fast and Furious: Hobbs and Shaw")
                    {
                        pictureBox1.Image = Properties.Resources.Fast___Furious;
                    }
                    else if (zoekresultaten[0].Titel == "April, May en June")
                    {
                        pictureBox1.Image = Properties.Resources.April;
                    }
                    else if (zoekresultaten[0].Titel == "The Gentlemen")
                    {
                        pictureBox1.Image = Properties.Resources.Gentlemen;
                    }
                    else if (zoekresultaten[0].Titel == "Bloodshot")
                    {
                        pictureBox1.Image = Properties.Resources.Bloodshot;
                    }
                    else if (zoekresultaten[0].Titel == "Joker")
                    {
                        pictureBox1.Image = Properties.Resources._268x0w;
                    }
                    else if (zoekresultaten[0].Titel == "Avengers: Endgame")
                    {
                        pictureBox1.Image = Properties.Resources.avengers_endgame_original_movie_poster_15x21_in_2019_anthony_russo_robert_downey_jr;
                    }
                    if (zoekresultaten[1].Titel == "The Godfather")
                    {
                        pictureBox2.Image = Properties.Resources.MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM___V1_;
                    }
                    else if (zoekresultaten[1].Titel == "The Godfather Part II")
                    {
                        pictureBox2.Image = Properties.Resources.The_Godfather__Part_II;
                    }
                    else if (zoekresultaten[1].Titel == "The Godfather Part III")
                    {
                        pictureBox2.Image = Properties.Resources.The_Godfather_Part_III;
                    }
                    else if (zoekresultaten[1].Titel == "Jumanji: The Next Level")
                    {
                        pictureBox2.Image = Properties.Resources.Jumanji;
                    }
                    else if (zoekresultaten[1].Titel == "Fast and Furious: Hobbs and Shaw")
                    {
                        pictureBox2.Image = Properties.Resources.Fast___Furious;
                    }
                    else if (zoekresultaten[1].Titel == "April, May en June")
                    {
                        pictureBox2.Image = Properties.Resources.April;
                    }
                    else if (zoekresultaten[1].Titel == "The Gentlemen")
                    {
                        pictureBox2.Image = Properties.Resources.Gentlemen;
                    }
                    else if (zoekresultaten[1].Titel == "Bloodshot")
                    {
                        pictureBox2.Image = Properties.Resources.Bloodshot;
                    }
                    else if (zoekresultaten[1].Titel == "Joker")
                    {
                        pictureBox2.Image = Properties.Resources._268x0w;
                    }
                    else if (zoekresultaten[1].Titel == "Avengers: Endgame")
                    {
                        pictureBox2.Image = Properties.Resources.avengers_endgame_original_movie_poster_15x21_in_2019_anthony_russo_robert_downey_jr;
                    }
                    if (zoekresultaten[2].Titel == "The Godfather")
                    {
                        pictureBox3.Image = Properties.Resources.MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM___V1_;
                    }
                    else if (zoekresultaten[2].Titel == "The Godfather Part II")
                    {
                        pictureBox3.Image = Properties.Resources.The_Godfather__Part_II;
                    }
                    else if (zoekresultaten[2].Titel == "The Godfather Part III")
                    {
                        pictureBox3.Image = Properties.Resources.The_Godfather_Part_III;
                    }
                    else if (zoekresultaten[2].Titel == "Jumanji: The Next Level")
                    {
                        pictureBox3.Image = Properties.Resources.Jumanji;
                    }
                    else if (zoekresultaten[2].Titel == "Fast and Furious: Hobbs and Shaw")
                    {
                        pictureBox3.Image = Properties.Resources.Fast___Furious;
                    }
                    else if (zoekresultaten[2].Titel == "April, May en June")
                    {
                        pictureBox3.Image = Properties.Resources.April;
                    }
                    else if (zoekresultaten[2].Titel == "The Gentlemen")
                    {
                        pictureBox3.Image = Properties.Resources.Gentlemen;
                    }
                    else if (zoekresultaten[2].Titel == "Bloodshot")
                    {
                        pictureBox3.Image = Properties.Resources.Bloodshot;
                    }
                    else if (zoekresultaten[2].Titel == "Joker")
                    {
                        pictureBox3.Image = Properties.Resources._268x0w;
                    }
                    else if (zoekresultaten[2].Titel == "Avengers: Endgame")
                    {
                        pictureBox3.Image = Properties.Resources.avengers_endgame_original_movie_poster_15x21_in_2019_anthony_russo_robert_downey_jr;
                    }
                    if (zoekresultaten[3].Titel == "The Godfather")
                    {
                        pictureBox4.Image = Properties.Resources.MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM___V1_;
                    }
                    else if (zoekresultaten[3].Titel == "The Godfather Part II")
                    {
                        pictureBox4.Image = Properties.Resources.The_Godfather__Part_II;
                    }
                    else if (zoekresultaten[3].Titel == "The Godfather Part III")
                    {
                        pictureBox4.Image = Properties.Resources.The_Godfather_Part_III;
                    }
                    else if (zoekresultaten[3].Titel == "Jumanji: The Next Level")
                    {
                        pictureBox4.Image = Properties.Resources.Jumanji;
                    }
                    else if (zoekresultaten[3].Titel == "Fast and Furious: Hobbs and Shaw")
                    {
                        pictureBox4.Image = Properties.Resources.Fast___Furious;
                    }
                    else if (zoekresultaten[3].Titel == "April, May en June")
                    {
                        pictureBox4.Image = Properties.Resources.April;
                    }
                    else if (zoekresultaten[3].Titel == "The Gentlemen")
                    {
                        pictureBox4.Image = Properties.Resources.Gentlemen;
                    }
                    else if (zoekresultaten[3].Titel == "Bloodshot")
                    {
                        pictureBox4.Image = Properties.Resources.Bloodshot;
                    }
                    else if (zoekresultaten[3].Titel == "Joker")
                    {
                        pictureBox4.Image = Properties.Resources._268x0w;
                    }
                    else if (zoekresultaten[3].Titel == "Avengers: Endgame")
                    {
                        pictureBox4.Image = Properties.Resources.avengers_endgame_original_movie_poster_15x21_in_2019_anthony_russo_robert_downey_jr;
                    }

                    label2.Text = zoekresultaten[0].Titel;
                    label12.Text = zoekresultaten[0].LeeftijdsCategorie;
                    richTextBox1.Text = zoekresultaten[0].Samenvatting;

                    label3.Text = zoekresultaten[1].Titel;
                    label13.Text = zoekresultaten[1].LeeftijdsCategorie;
                    richTextBox2.Text = zoekresultaten[1].Samenvatting;

                    label4.Text = zoekresultaten[2].Titel;
                    label14.Text = zoekresultaten[2].LeeftijdsCategorie;
                    richTextBox11.Text = zoekresultaten[2].Samenvatting;

                    label5.Text = zoekresultaten[3].Titel;
                    label15.Text = zoekresultaten[3].LeeftijdsCategorie;
                    richTextBox4.Text = zoekresultaten[3].Samenvatting;

                    pictureBox1.Show();
                    label2.Show();
                    label12.Show();
                    richTextBox1.Show();

                    pictureBox2.Show();
                    label3.Show();
                    label13.Show();
                    richTextBox2.Show();

                    pictureBox3.Show();
                    label4.Show();
                    label14.Show();
                    richTextBox11.Show();

                    pictureBox4.Show();
                    label5.Show();
                    label15.Show();
                    richTextBox4.Show();

                    pictureBox5.Hide();
                    label6.Hide();
                    label16.Hide();
                    richTextBox5.Hide();
                    pictureBox10.Hide();
                    label7.Hide();
                    label17.Hide();
                    richTextBox6.Hide();
                    pictureBox6.Hide();
                    label8.Hide();
                    label18.Hide();
                    richTextBox7.Hide();
                    pictureBox9.Hide();
                    label9.Hide();
                    label19.Hide();
                    richTextBox8.Hide();
                    pictureBox8.Hide();
                    label10.Hide();
                    label20.Hide();
                    richTextBox9.Hide();
                    pictureBox7.Hide();
                    label11.Hide();
                    label21.Hide();
                    richTextBox10.Hide();
                }
                else if (zoekresultaten.Length == 5)
                {
                    if (zoekresultaten[0].Titel == "The Godfather")
                    {
                        pictureBox1.Image = Properties.Resources.MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM___V1_;
                    }
                    else if (zoekresultaten[0].Titel == "The Godfather Part II")
                    {
                        pictureBox1.Image = Properties.Resources.The_Godfather__Part_II;
                    }
                    else if (zoekresultaten[0].Titel == "The Godfather Part III")
                    {
                        pictureBox1.Image = Properties.Resources.The_Godfather_Part_III;
                    }
                    else if (zoekresultaten[0].Titel == "Jumanji: The Next Level")
                    {
                        pictureBox1.Image = Properties.Resources.Jumanji;
                    }
                    else if (zoekresultaten[0].Titel == "Fast and Furious: Hobbs and Shaw")
                    {
                        pictureBox1.Image = Properties.Resources.Fast___Furious;
                    }
                    else if (zoekresultaten[0].Titel == "April, May en June")
                    {
                        pictureBox1.Image = Properties.Resources.April;
                    }
                    else if (zoekresultaten[0].Titel == "The Gentlemen")
                    {
                        pictureBox1.Image = Properties.Resources.Gentlemen;
                    }
                    else if (zoekresultaten[0].Titel == "Bloodshot")
                    {
                        pictureBox1.Image = Properties.Resources.Bloodshot;
                    }
                    else if (zoekresultaten[0].Titel == "Joker")
                    {
                        pictureBox1.Image = Properties.Resources._268x0w;
                    }
                    else if (zoekresultaten[0].Titel == "Avengers: Endgame")
                    {
                        pictureBox1.Image = Properties.Resources.avengers_endgame_original_movie_poster_15x21_in_2019_anthony_russo_robert_downey_jr;
                    }
                    if (zoekresultaten[1].Titel == "The Godfather")
                    {
                        pictureBox2.Image = Properties.Resources.MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM___V1_;
                    }
                    else if (zoekresultaten[1].Titel == "The Godfather Part II")
                    {
                        pictureBox2.Image = Properties.Resources.The_Godfather__Part_II;
                    }
                    else if (zoekresultaten[1].Titel == "The Godfather Part III")
                    {
                        pictureBox2.Image = Properties.Resources.The_Godfather_Part_III;
                    }
                    else if (zoekresultaten[1].Titel == "Jumanji: The Next Level")
                    {
                        pictureBox2.Image = Properties.Resources.Jumanji;
                    }
                    else if (zoekresultaten[1].Titel == "Fast and Furious: Hobbs and Shaw")
                    {
                        pictureBox2.Image = Properties.Resources.Fast___Furious;
                    }
                    else if (zoekresultaten[1].Titel == "April, May en June")
                    {
                        pictureBox2.Image = Properties.Resources.April;
                    }
                    else if (zoekresultaten[1].Titel == "The Gentlemen")
                    {
                        pictureBox2.Image = Properties.Resources.Gentlemen;
                    }
                    else if (zoekresultaten[1].Titel == "Bloodshot")
                    {
                        pictureBox2.Image = Properties.Resources.Bloodshot;
                    }
                    else if (zoekresultaten[1].Titel == "Joker")
                    {
                        pictureBox2.Image = Properties.Resources._268x0w;
                    }
                    else if (zoekresultaten[1].Titel == "Avengers: Endgame")
                    {
                        pictureBox2.Image = Properties.Resources.avengers_endgame_original_movie_poster_15x21_in_2019_anthony_russo_robert_downey_jr;
                    }
                    if (zoekresultaten[2].Titel == "The Godfather")
                    {
                        pictureBox3.Image = Properties.Resources.MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM___V1_;
                    }
                    else if (zoekresultaten[2].Titel == "The Godfather Part II")
                    {
                        pictureBox3.Image = Properties.Resources.The_Godfather__Part_II;
                    }
                    else if (zoekresultaten[2].Titel == "The Godfather Part III")
                    {
                        pictureBox3.Image = Properties.Resources.The_Godfather_Part_III;
                    }
                    else if (zoekresultaten[2].Titel == "Jumanji: The Next Level")
                    {
                        pictureBox3.Image = Properties.Resources.Jumanji;
                    }
                    else if (zoekresultaten[2].Titel == "Fast and Furious: Hobbs and Shaw")
                    {
                        pictureBox3.Image = Properties.Resources.Fast___Furious;
                    }
                    else if (zoekresultaten[2].Titel == "April, May en June")
                    {
                        pictureBox3.Image = Properties.Resources.April;
                    }
                    else if (zoekresultaten[2].Titel == "The Gentlemen")
                    {
                        pictureBox3.Image = Properties.Resources.Gentlemen;
                    }
                    else if (zoekresultaten[2].Titel == "Bloodshot")
                    {
                        pictureBox3.Image = Properties.Resources.Bloodshot;
                    }
                    else if (zoekresultaten[2].Titel == "Joker")
                    {
                        pictureBox3.Image = Properties.Resources._268x0w;
                    }
                    else if (zoekresultaten[2].Titel == "Avengers: Endgame")
                    {
                        pictureBox3.Image = Properties.Resources.avengers_endgame_original_movie_poster_15x21_in_2019_anthony_russo_robert_downey_jr;
                    }
                    else if (zoekresultaten[3].Titel == "The Godfather")
                    {
                        pictureBox4.Image = Properties.Resources.MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM___V1_;
                    }
                    if (zoekresultaten[3].Titel == "The Godfather Part II")
                    {
                        pictureBox4.Image = Properties.Resources.The_Godfather__Part_II;
                    }
                    else if (zoekresultaten[3].Titel == "The Godfather Part III")
                    {
                        pictureBox4.Image = Properties.Resources.The_Godfather_Part_III;
                    }
                    else if (zoekresultaten[3].Titel == "Jumanji: The Next Level")
                    {
                        pictureBox4.Image = Properties.Resources.Jumanji;
                    }
                    else if (zoekresultaten[3].Titel == "Fast and Furious: Hobbs and Shaw")
                    {
                        pictureBox4.Image = Properties.Resources.Fast___Furious;
                    }
                    else if (zoekresultaten[3].Titel == "April, May en June")
                    {
                        pictureBox4.Image = Properties.Resources.April;
                    }
                    else if (zoekresultaten[3].Titel == "The Gentlemen")
                    {
                        pictureBox4.Image = Properties.Resources.Gentlemen;
                    }
                    else if (zoekresultaten[3].Titel == "Bloodshot")
                    {
                        pictureBox4.Image = Properties.Resources.Bloodshot;
                    }
                    else if (zoekresultaten[3].Titel == "Joker")
                    {
                        pictureBox4.Image = Properties.Resources._268x0w;
                    }
                    else if (zoekresultaten[3].Titel == "Avengers: Endgame")
                    {
                        pictureBox4.Image = Properties.Resources.avengers_endgame_original_movie_poster_15x21_in_2019_anthony_russo_robert_downey_jr;
                    }
                    if (zoekresultaten[4].Titel == "The Godfather")
                    {
                        pictureBox5.Image = Properties.Resources.MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM___V1_;
                    }
                    else if (zoekresultaten[4].Titel == "The Godfather Part II")
                    {
                        pictureBox5.Image = Properties.Resources.The_Godfather__Part_II;
                    }
                    else if (zoekresultaten[4].Titel == "The Godfather Part III")
                    {
                        pictureBox5.Image = Properties.Resources.The_Godfather_Part_III;
                    }
                    else if (zoekresultaten[4].Titel == "Jumanji: The Next Level")
                    {
                        pictureBox5.Image = Properties.Resources.Jumanji;
                    }
                    else if (zoekresultaten[4].Titel == "Fast and Furious: Hobbs and Shaw")
                    {
                        pictureBox5.Image = Properties.Resources.Fast___Furious;
                    }
                    else if (zoekresultaten[4].Titel == "April, May en June")
                    {
                        pictureBox5.Image = Properties.Resources.April;
                    }
                    else if (zoekresultaten[4].Titel == "The Gentlemen")
                    {
                        pictureBox5.Image = Properties.Resources.Gentlemen;
                    }
                    else if (zoekresultaten[4].Titel == "Bloodshot")
                    {
                        pictureBox5.Image = Properties.Resources.Bloodshot;
                    }
                    else if (zoekresultaten[4].Titel == "Joker")
                    {
                        pictureBox5.Image = Properties.Resources._268x0w;
                    }
                    else if (zoekresultaten[4].Titel == "Avengers: Endgame")
                    {
                        pictureBox5.Image = Properties.Resources.avengers_endgame_original_movie_poster_15x21_in_2019_anthony_russo_robert_downey_jr;
                    }

                    label2.Text = zoekresultaten[0].Titel;
                    label12.Text = zoekresultaten[0].LeeftijdsCategorie;
                    richTextBox1.Text = zoekresultaten[0].Samenvatting;

                    label3.Text = zoekresultaten[1].Titel;
                    label13.Text = zoekresultaten[1].LeeftijdsCategorie;
                    richTextBox2.Text = zoekresultaten[1].Samenvatting;

                    label4.Text = zoekresultaten[2].Titel;
                    label14.Text = zoekresultaten[2].LeeftijdsCategorie;
                    richTextBox11.Text = zoekresultaten[2].Samenvatting;

                    label5.Text = zoekresultaten[3].Titel;
                    label15.Text = zoekresultaten[3].LeeftijdsCategorie;
                    richTextBox4.Text = zoekresultaten[3].Samenvatting;

                    label6.Text = zoekresultaten[4].Titel;
                    label16.Text = zoekresultaten[4].LeeftijdsCategorie;
                    richTextBox5.Text = zoekresultaten[4].Samenvatting;

                    pictureBox1.Show();
                    label2.Show();
                    label12.Show();
                    richTextBox1.Show();

                    pictureBox2.Show();
                    label3.Show();
                    label13.Show();
                    richTextBox2.Show();

                    pictureBox3.Show();
                    label4.Show();
                    label14.Show();
                    richTextBox11.Show();

                    pictureBox4.Show();
                    label5.Show();
                    label15.Show();
                    richTextBox4.Show();

                    pictureBox5.Show();
                    label6.Show();
                    label16.Show();
                    richTextBox5.Show();

                    pictureBox10.Hide();
                    label7.Hide();
                    label17.Hide();
                    richTextBox6.Hide();
                    pictureBox6.Hide();
                    label8.Hide();
                    label18.Hide();
                    richTextBox7.Hide();
                    pictureBox9.Hide();
                    label9.Hide();
                    label19.Hide();
                    richTextBox8.Hide();
                    pictureBox8.Hide();
                    label10.Hide();
                    label20.Hide();
                    richTextBox9.Hide();
                    pictureBox7.Hide();
                    label11.Hide();
                    label21.Hide();
                    richTextBox10.Hide();
                }
                else if (zoekresultaten.Length == 6)
                {
                    label2.Text = zoekresultaten[0].Titel;
                    label12.Text = zoekresultaten[0].LeeftijdsCategorie;
                    richTextBox1.Text = zoekresultaten[0].Samenvatting;

                    label3.Text = zoekresultaten[1].Titel;
                    label13.Text = zoekresultaten[1].LeeftijdsCategorie;
                    richTextBox2.Text = zoekresultaten[1].Samenvatting;

                    label4.Text = zoekresultaten[2].Titel;
                    label14.Text = zoekresultaten[2].LeeftijdsCategorie;
                    richTextBox11.Text = zoekresultaten[2].Samenvatting;

                    label5.Text = zoekresultaten[3].Titel;
                    label15.Text = zoekresultaten[3].LeeftijdsCategorie;
                    richTextBox4.Text = zoekresultaten[3].Samenvatting;

                    label6.Text = zoekresultaten[4].Titel;
                    label16.Text = zoekresultaten[4].LeeftijdsCategorie;
                    richTextBox5.Text = zoekresultaten[4].Samenvatting;

                    label7.Text = zoekresultaten[5].Titel;
                    label17.Text = zoekresultaten[5].LeeftijdsCategorie;
                    richTextBox6.Text = zoekresultaten[5].Samenvatting;

                    pictureBox6.Hide();
                    label8.Hide();
                    label18.Hide();
                    richTextBox7.Hide();
                    pictureBox9.Hide();
                    label9.Hide();
                    label19.Hide();
                    richTextBox8.Hide();
                    pictureBox8.Hide();
                    label10.Hide();
                    label20.Hide();
                    richTextBox9.Hide();
                    pictureBox7.Hide();
                    label11.Hide();
                    label21.Hide();
                    richTextBox10.Hide();
                }
                else if (zoekresultaten.Length == 7)
                {
                    pictureBox9.Hide();
                    label9.Hide();
                    label19.Hide();
                    richTextBox8.Hide();
                    pictureBox8.Hide();
                    label10.Hide();
                    label20.Hide();
                    richTextBox9.Hide();
                    pictureBox7.Hide();
                    label11.Hide();
                    label21.Hide();
                    richTextBox10.Hide();
                }
                else if (zoekresultaten.Length == 8)
                {
                    pictureBox8.Hide();
                    label10.Hide();
                    label20.Hide();
                    richTextBox9.Hide();
                    pictureBox7.Hide();
                    label11.Hide();
                    label21.Hide();
                    richTextBox10.Hide();
                }
                else if (zoekresultaten.Length == 9)
                {
                    pictureBox7.Hide();
                    label11.Hide();
                    label21.Hide();
                    richTextBox10.Hide();
                }
                
            }
        }
    }
}