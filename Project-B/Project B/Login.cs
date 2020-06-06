using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Project_B
{
    public partial class Login : Form
    {
        //maak hier global varibale
        public static string Username;
        public static string Email;
        public static string DOB;
        public static string Adres;
        public static bool LogedIn = false;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> Users = new Dictionary<string, string>();

            using (StreamReader r = new StreamReader(@"../../Users.json"))
            {
                string json = r.ReadToEnd();
                var output = JsonConvert.DeserializeObject<List<User>>(json);
                int count = output.Count;

                for (int i = 0; i < count; i++)
                {
                    if (output[i].Username == textBox1.Text)
                    {
                        Email = output[i].Email;
                        DOB = output[i].DOB;
                        Adres = output[i].Adres;
                    }
                }

                foreach (var item in output)
                {
                    Users.Add(item.Username, item.Password);
                }
            }

            string password = textBox2.Text;

            if (Users.TryGetValue(textBox1.Text, out password))
            {
                Username = textBox1.Text;
                LogedIn = true;
                Account account = new Account();

                account.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Verkeerde combinatie van gebruikersnaam en wachtwoord, probeer opnieuw");
            }
        }

        public class User
        {
            public string FirstName;
            public string LastName;
            public string Email;
            public string Username;
            public string Password;
            public string DOB;
            public string Adres;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            this.Hide();
            menu.Show();

        }
    }
}
