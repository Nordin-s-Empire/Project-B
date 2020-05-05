using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
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

            /*string connStr = "server=sql7.freemysqlhosting.net;user=sql7337554;database=sql7337554;port=3306;password=chz3lfHBcK";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "INSERT INTO Gebruiker(Voornaam, Achternaam, Telefoonnummer, Adres, Email, Wachtwoord) VALUES(@firstname, @lastname, @phone, @adres, @email, PASSWORD(@password))";
                comm.Parameters.AddWithValue("@firstname", txbFNaam.Text);
                comm.Parameters.AddWithValue("@lastname", txbLName.Text);
                comm.Parameters.AddWithValue("@phone", txbPhone.Text);
                comm.Parameters.AddWithValue("@adres", txbAdres.Text);
                comm.Parameters.AddWithValue("@email", txbEmail.Text);
                comm.Parameters.AddWithValue("@password", txbPassword.Text);
                comm.ExecuteNonQuery();
                MessageBox.Show("success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();*/
        }
    }
}
