using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_B
{
    public class Film
    {
        public string Titel { get; set; }
        public string[] Genre { get; set; }
        public string LeeftijdsCategorie { get; set; }
        public string Samenvatting { get; set; }
        public string[] Identifier { get; set; }

        public bool Show;

        public Film(string titel, string[] genre, string leeftijdscategorie, string samenvatting, string[] identifier)
        {
            Titel = titel;
            Genre = genre;
            LeeftijdsCategorie = leeftijdscategorie;
            Samenvatting = samenvatting;
            Identifier = identifier;
            Show = true;
        }
    }
}
