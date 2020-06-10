using System.Drawing;

namespace Project_B
{
    public class Film
    {
        public string Titel { get; set; }
        public string[] Genre { get; set; }
        public string LeeftijdsCategorie { get; set; }
        public string Samenvatting { get; set; }
        public Bitmap Poster;
        public bool Show;

        public Film(string titel, string[] genre, string leeftijdscategorie, string samenvatting)
        {
            Titel = titel;
            Genre = genre;
            LeeftijdsCategorie = leeftijdscategorie;
            Samenvatting = samenvatting;
            Show = true;
        }
    }
}
