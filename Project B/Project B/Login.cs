using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\dvide\OneDrive\Documenten\Data.mdf; Integrated Security = True; Connect Timeout = 30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From LOGIN where Gebruikersnaam='" + textBox1.Text + "' and Wachtwoord='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Account acc = new Account();
                acc.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Error!");
            }






      
        }
    }
}
