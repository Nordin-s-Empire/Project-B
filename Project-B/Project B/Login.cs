using System;
using System.Data;
using MySql.Data;
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

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string connStr = "server=sql7.freemysqlhosting.net;user=sql7337554;database=sql7337554;port=3306;password=chz3lfHBcK";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "";
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
