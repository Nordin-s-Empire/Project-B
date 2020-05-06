using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Project_B
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "server=sql7.freemysqlhosting.net;user=sql7337554;database=sql7337554;port=3306;password=chz3lfHBcK";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "SELECT Voornaam FROM Gebruiker WHERE Email = '"+ textBox1 .Text+ "'";
                comm.ExecuteNonQuery();
                MySqlDataReader rdr = comm.ExecuteReader();

                while(rdr.Read())
                {
                    if(rdr.GetString("Voornaam") != null)
                    {
                        this.Hide();
                        Account account = new Account();
                        account.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();
        }
    }
}
