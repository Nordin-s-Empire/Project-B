using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_B
{
    public partial class FIlmInfo : Form
    {
        public FIlmInfo()
        {
            InitializeComponent();
            string str = Programma.movie;
            lblTitle.Text = str;
            lblSummary.MaximumSize = new Size(300, 0);
            lblSummary.AutoSize = true;
            if (str.Contains("Peter rabit 2") == true)
            {
                pictureBox1.Image = Properties.Resources.peter_rabbit_movie_2_novelisation;
                lblSummary.Text = "Ondanks zijn inspanningen kan Peter zijn reputatie van kattenkwaad onder de andere konijnen niet van zich afschudden. Als hij eenmaal uit de tuin op avontuur is, bevindt Peter zich in een wereld waar kattenkwaad wordt gewaardeerd, maar al snel komt zijn familie hem thuisbrengen.";
            }
            else if(str.Contains("IO") == true)
            {
                pictureBox1.Image = Properties.Resources.MV5BNmU4NTc0ZTgtNjliOC00NTM2LWE3NDktNGJiNzc2YzY3ZjA2XkEyXkFqcGdeQXVyNDg4NjY5OTQ___V1_;
                lblSummary.Text = "In een post-apocalyptische tijd is de aarde giftig gemaakt en heeft het grootste deel van de mensheid de planeet verlaten en een van de manen van Jupiter, IO, gekoloniseerd. Maar de jonge wetenschapper Sam Walden is achtergebleven en heeft zich toegelegd op het vinden van een manier waarop mensen op aarde kunnen overleven. Nadat ze een radio-uitzending heeft uitgezonden om te zien of ze iemand anders kan vinden, arriveert een man genaamd Micah. Hij gelooft dat er geen hoop is om te overleven en is van plan om binnen 48 uur de laatste shuttle naar IO te nemen.";
            }
            else if(str.Contains("The Lord of the rings the two towers") == true)
            {
                pictureBox1.Image = Properties.Resources.THE_LORD_OF_THE_RINGS_THE_TWO_TOWERS_Frodo_Reprint_2002_REPRINT_CINEMA_POSTER__74417_1534256853;
                lblSummary.Text = "Frodo en Sam komen met hulp van Gollum aan in Mordor. Een aantal nieuwe bondgenoten voegt zich bij hun voormalige metgezellen om Isengard te verdedigen terwijl Saruman er een aanval op start.";
            }
            else if(str.Contains("Fight Club") == true)
            {
                pictureBox1.Image = Properties.Resources._865580314a24d809e6fb0f12ce72e738;
                lblSummary.Text = "Ontevreden met zijn kapitalistische levensstijl, vormt een slapeloosheid met een witte kraag een ondergrondse vechtclub met Tyler, een zorgeloze zeepverkoper. Het project verandert al snel in iets sinisters.";
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
            string str = Programma.movie;
            if (str.Contains("Peter rabit 2") == true)
            {
                var url = "https://www.youtube.com/embed/euGHcnyUo84";
                this.webBrowser1.DocumentText = string.Format(embed, url);
            }
            else if (str.Contains("IO") == true)
            {
                var url = "https://www.youtube.com/embed/y3GLhAumiec";
                this.webBrowser1.DocumentText = string.Format(embed, url);
            }
            else if (str.Contains("The Lord of the rings the two towers") == true)
            {
                var url = "https://www.youtube.com/embed/LbfMDwc4azU";
                this.webBrowser1.DocumentText = string.Format(embed, url);
            }
            else if (str.Contains("Fight Club") == true)
            {
                var url = "https://www.youtube.com/embed/SUXWAEX2jlg";
                this.webBrowser1.DocumentText = string.Format(embed, url);
            }
        }
    }
}
