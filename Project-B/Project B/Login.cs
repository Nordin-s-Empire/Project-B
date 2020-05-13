using System;
using System.Data;
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
<<<<<<< Updated upstream
=======
            try
            {
                Dictionary<string, string> Users = new Dictionary<string, string>();
                using (StreamReader r = new StreamReader(@"../../Users.json"))
                {
                    string json = r.ReadToEnd();
                    var output = JsonConvert.DeserializeObject<List<User>>(json);
>>>>>>> Stashed changes

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();

            Class1 con = new Class1();
            con.Connection();
            con.con.Open();
            if (textBox1.Text != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From LOGIN where Gebruikersnaam='" + textBox1.Text + "' and Wachtwoord='" + textBox2.Text + "'", con.con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Account acc = new Account(textBox1.Text);
                    acc.ShowDialog();
                }
            }
        }
    }
}
