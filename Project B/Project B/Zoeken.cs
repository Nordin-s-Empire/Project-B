using System;
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
        public Zoeken()
        {
            InitializeComponent();
        }

        private void Zoeken_Load(object sender, EventArgs e)
        {

        }

        private void btnZoeken_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
    public class Film
    {
        public string Titel;
        public string[] Genre;
        public string LeeftijdsCategorie;
        public string Samenvatting;

    }

    public class Filmlijst
    {
        public Film[] filmlijst;
    }
}
