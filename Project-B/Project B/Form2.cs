using System;
using System.Windows.Forms;

namespace Project_B
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnregistreer_Click(object sender, EventArgs e)
        {
            MySqlClass mySql = new MySqlClass();
            mySql.Connection("INSERT INTO Gebruiker(Voornaam, Achternaam, Telefoonnummer, Adres, Email, Wachtwoord) VALUES('"+txbFNaam.Text+"', '"+txbLName.Text+"', '"+txbPhone.Text+"', '"+txbAdres.Text+"', '"+txbEmail.Text+"', PASSWORD('"+txbPassword.Text+"'))");
        }
    }
}
