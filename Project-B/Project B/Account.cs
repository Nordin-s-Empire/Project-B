using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_B
{
    public partial class Account : Form
    {
        public static Login log;
           
        public Account()
        {
            InitializeComponent();

            Account_Load("Welkom best klant", EventArgs.Empty);
        }

        public void AcctoMain(object sender, MouseEventArgs e)
        { 
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
            menu.HideLoginbutton(false);    
        }

        private void Account_Load(string txt, EventArgs e)
        {
            Login user = new Login();

            Class1 con = new Class1();
            con.Connection();
            con.con.Open();

            SqlCommand cmd = new SqlCommand("Select Email, Adres, Geboortedatum From LOGIN where Gebruikersnaam=@Gebruikersnaam", con.con);
            cmd.Parameters.AddWithValue("Gebruikersnaam", txt);
            SqlDataReader da = cmd.ExecuteReader();

            while (da.Read())
            {
                textBox1.Text = da.GetValue(0).ToString();
                textBox2.Text = da.GetValue(1).ToString();
                textBox3.Text = da.GetValue(2).ToString();
            }

            con.con.Close();
        }
    }
}
