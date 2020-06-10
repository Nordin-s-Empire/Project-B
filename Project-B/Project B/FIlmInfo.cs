using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_B
{
    public partial class FIlmInfo : Form
    {
        public static string movie_title = "";
        public static Image pic;
        public static string Date;

        public FIlmInfo()
        {
            InitializeComponent();
            string str =  "";
            if (Zoeken.flag)
            {
                str = Zoeken.movie;
            }
            else
            {
                str = Programma.movie;
            }

            lblSummary.MaximumSize = new Size(300, 0);
            lblSummary.AutoSize = true;

            if ((str.Contains("Peter rabit 2") == true) || (str.Contains("Peter Rabbit 2: The Runaway")))
            {
                lblTitle.Text = "Peter Rabbit 2: The Runaway";
                pictureBox1.Image = Properties.Resources.peter_rabbit_movie_2_novelisation;
                lblSummary.Text = "Ondanks zijn inspanningen kan Peter zijn reputatie van kattenkwaad onder de andere konijnen niet van zich afschudden. Als hij eenmaal uit de tuin op avontuur is, bevindt Peter zich in een wereld waar kattenkwaad wordt gewaardeerd, maar al snel komt zijn familie hem thuisbrengen.";
            }
            else if(str.Contains("IO") == true)
            {
                lblTitle.Text = "IO";
                pictureBox1.Image = Properties.Resources.MV5BNmU4NTc0ZTgtNjliOC00NTM2LWE3NDktNGJiNzc2YzY3ZjA2XkEyXkFqcGdeQXVyNDg4NjY5OTQ___V1_;
                lblSummary.Text = "In een post-apocalyptische tijd is de aarde giftig gemaakt en heeft het grootste deel van de mensheid de planeet verlaten en een van de manen van Jupiter, IO, gekoloniseerd. Maar de jonge wetenschapper Sam Walden is achtergebleven en heeft zich toegelegd op het vinden van een manier waarop mensen op aarde kunnen overleven. Nadat ze een radio-uitzending heeft uitgezonden om te zien of ze iemand anders kan vinden, arriveert een man genaamd Micah. Hij gelooft dat er geen hoop is om te overleven en is van plan om binnen 48 uur de laatste shuttle naar IO te nemen.";
            }
            else if((str.Contains("The Lord of the rings the two towers") == true) || (str.Contains("The Lord of the Rings: The Two Towers")))
            {
                lblTitle.Text = "The Lord of the Rings: The Two Towers";
                pictureBox1.Image = Properties.Resources.THE_LORD_OF_THE_RINGS_THE_TWO_TOWERS_Frodo_Reprint_2002_REPRINT_CINEMA_POSTER__74417_1534256853;
                lblSummary.Text = "Frodo en Sam komen met hulp van Gollum aan in Mordor. Een aantal nieuwe bondgenoten voegt zich bij hun voormalige metgezellen om Isengard te verdedigen terwijl Saruman er een aanval op start.";
            }
            else if(str.Contains("Fight Club") == true)
            {
                lblTitle.Text = "Fight Club";
                pictureBox1.Image = Properties.Resources._865580314a24d809e6fb0f12ce72e738;
                lblSummary.Text = "Ontevreden met zijn kapitalistische levensstijl, vormt een slapeloosheid met een witte kraag een ondergrondse vechtclub met Tyler, een zorgeloze zeepverkoper. Het project verandert al snel in iets sinisters.";
            }
            else if((str.Contains("The Dark Kinght Rises") == true) || (str.Contains("The Dark Knight Rises")))
            {
                lblTitle.Text = "The Dark Knight Rises";
                pictureBox1.Image = Properties.Resources._51Av5azGomL__AC_;
                lblSummary.Text = "Bane, een imposante terrorist, valt Gotham City aan en verstoort de achtjarige vredesperiode. Dit dwingt Bruce Wayne om uit de onderduik te komen en de cape en kap van Batman opnieuw aan te trekken.";
            }
            else if(str.Contains("Interstellar") == true)
            {
                lblTitle.Text = "Interstellar";
                pictureBox1.Image = Properties.Resources._81kz06oSUeL__AC_SL1500_;
                lblSummary.Text = "In de toekomst van de aarde maken een wereldwijde gewasziekte en een tweede stofbak de planeet langzaam onbewoonbaar. Professor Brand (Michael Caine), een briljante natuurkundige van de NASA, werkt aan plannen om de mensheid te redden door de bevolking van de aarde via een wormgat naar een nieuw huis te vervoeren. Maar eerst moet Brand de voormalige NASA-piloot Cooper (Matthew McConaughey) en een team van onderzoekers door het wormgat en het heelal sturen om erachter te komen welke van de drie planeten het nieuwe thuis van de mensheid zou kunnen zijn.";
            }
            else if (str.Contains("Joker") == true)
            {
                lblTitle.Text = "Joker";
                pictureBox1.Image = Properties.Resources._268x0w;
                lblSummary.Text = "Voor altijd alleen in een menigte zoekt de mislukte komiek Arthur Fleck verbinding terwijl hij door de straten van Gotham City loopt. Arthur draagt twee maskers - het masker dat hij schildert voor zijn dagelijkse werk als clown, en het mom dat hij projecteert in een vergeefse poging om het gevoel te krijgen dat hij deel uitmaakt van de wereld om hem heen. Geïsoleerd, gepest en genegeerd door de samenleving, begint Fleck aan een langzame afdaling in waanzin terwijl hij verandert in het criminele meesterbrein dat bekend staat als de Joker.";
            }
            else if ((str.Contains("Avengers Endgame") == true) || (str.Contains("Avengers: Endgame")))
            {
                lblTitle.Text = "Avengers: Endgame";
                pictureBox1.Image = Properties.Resources.avengers_endgame_original_movie_poster_15x21_in_2019_anthony_russo_robert_downey_jr;
                lblSummary.Text = "Nadat Thanos, een intergalactische krijgsheer, de helft van het universum uit elkaar heeft gedreven, moeten de Avengers zich herenigen en weer bijeenkomen om hun getroffen bondgenoten nieuw leven in te blazen en het evenwicht te herstellen.";
            }
            else if (str.Contains("The Godfather") == true)
            {
                lblTitle.Text = "The Godfather";
                pictureBox1.Image = Properties.Resources.MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM___V1_;
                lblSummary.Text = "Don Vito Corleone, hoofd van een maffiafamilie, besluit zijn rijk over te dragen aan zijn jongste zoon Michael. Zijn beslissing brengt echter onbedoeld het leven van zijn dierbaren in groot gevaar.";
            }
            else if ((str.Contains("The Lord of the rings fellowschip of the ring") == true) || (str.Contains("The Lord of the Rings: The Fellowship of the Ring")))
            {
                lblTitle.Text = "The Lord of the Rings: The Fellowship of the Ring";
                pictureBox1.Image = Properties.Resources.baaf0f0f37c294c779ed9d52896e9d52;
                lblSummary.Text = "Een jonge hobbit, Frodo, die de One Ring heeft gevonden die van de Dark Lord Sauron is, begint zijn reis met acht metgezellen naar Mount Doom, de enige plek waar het kan worden vernietigd.";
            }
            else if ((str.Contains("the Lord of the Rings The return of the king.") == true) || (str.Contains("The Lord of the Rings: The Return of the King.")))
            {
                lblTitle.Text = "The Lord of the Rings The Return of the King.";
                pictureBox1.Image = Properties.Resources._7e6b6743a7e45d096838abd67b2464e2;
                lblSummary.Text = "De voormalige Fellowshipleden bereiden zich voor op de eindstrijd. Terwijl Frodo en Sam Mount Doom naderen om de One Ring te vernietigen, volgen ze Gollum zonder zich bewust te zijn van het pad waarheen ze hen leiden.";
            }
            else if (str.Contains("Wildlife") == true)
            {
                lblTitle.Text = "Wildlife";
                pictureBox1.Image = Properties.Resources.MV5BOTNlZWY2ZGQtY2U1ZS00Mjc5LWExNjgtM2Q4YzQyYTlmNjZhXkEyXkFqcGdeQXVyODY3Nzc0OTk___V1_;
                lblSummary.Text = "Nadat Jerry is ontslagen uit zijn baan, vervult hij een rol onder hem. Zijn vrouw, Jeanette, vertrouwt hun zoon toe dat hun huwelijk niet werkt.";
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var embed = "<html><head>" +
            "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
            "</head><body>" +
            "<iframe width=\"550\" height=\"360\" src=\"{0}\"" +
            "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
            "</body></html>";

            string str = "";
            if (Zoeken.flag)
            {
                str = Zoeken.movie;
            }
            else
            {
                str = Programma.movie;
            }

            if ((str.Contains("Peter rabit 2") == true) || (str.Contains("Peter Rabbit 2: The Runaway")))
            {
                var url = "https://www.youtube.com/embed/euGHcnyUo84";
                this.webBrowser1.DocumentText = string.Format(embed, url);
            }
            else if (str.Contains("IO") == true)
            {
                var url = "https://www.youtube.com/embed/y3GLhAumiec";
                this.webBrowser1.DocumentText = string.Format(embed, url);
            }
            else if ((str.Contains("The Lord of the rings the two towers") == true) || (str.Contains("The Lord of the Rings: The Two Towers")))
            {
                var url = "https://www.youtube.com/embed/LbfMDwc4azU";
                this.webBrowser1.DocumentText = string.Format(embed, url);
            }
            else if (str.Contains("Fight Club") == true)
            {
                var url = "https://www.youtube.com/embed/SUXWAEX2jlg";
                this.webBrowser1.DocumentText = string.Format(embed, url);
            }
            else if ((str.Contains("The Dark Kinght Rises") == true) || (str.Contains("The Dark Knight Rises")))
            {
                var url = "https://www.youtube.com/embed/g8evyE9TuYk";
                this.webBrowser1.DocumentText = string.Format(embed, url);
            }
            else if (str.Contains("Interstellar") == true)
            {
                var url = "https://www.youtube.com/embed/0vxOhd4qlnA";
                this.webBrowser1.DocumentText = string.Format(embed, url);
            }
            else if (str.Contains("Joker") == true)
            {
                var url = "https://www.youtube.com/embed/zAGVQLHvwOY";
                this.webBrowser1.DocumentText = string.Format(embed, url);
            }
            else if ((str.Contains("Avengers Endgame") == true) || (str.Contains("Avengers: Endgame")))
            {
                var url = "https://www.youtube.com/embed/TcMBFSGVi1c";
                this.webBrowser1.DocumentText = string.Format(embed, url);
            }
            else if (str.Contains("The Godfather") == true)
            {
                var url = "https://www.youtube.com/embed/5DO-nDW43Ik";
                this.webBrowser1.DocumentText = string.Format(embed, url);
            }
            else if ((str.Contains("The Lord of the rings fellowschip of the ring") == true) || (str.Contains("The Lord of the Rings: The Fellowship of the Ring")))
            {
                var url = "https://www.youtube.com/embed/V75dMMIW2B4";
                this.webBrowser1.DocumentText = string.Format(embed, url);
            }
            else if ((str.Contains("the Lord of the Rings The return of the king.") == true) || (str.Contains("The Lord of the Rings: The Return of the King.")))
            {
                var url = "https://www.youtube.com/embed/r5X-hFf6Bwo";
                this.webBrowser1.DocumentText = string.Format(embed, url);
            }
            else if (str.Contains("Wildlife") == true)
            {
                var url = "https://www.youtube.com/embed/q77YXl_ujBM";
                this.webBrowser1.DocumentText = string.Format(embed, url);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Programma pg = new Programma();
            pg.Show();
        }

        private void btnReserveer_Click(object sender, EventArgs e)
        {
            movie_title = this.lblTitle.Text;
            pic = this.pictureBox1.Image;
            Date = Programma.date;
            this.Hide();
            Reservatie res = new Reservatie();
            res.Show();
        }
    }
}