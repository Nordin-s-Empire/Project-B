using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

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
            Dictionary<string, string> Users = new Dictionary<string, string>();
            using (StreamReader r = new StreamReader(@"Users.json"))
            {
                string json = r.ReadToEnd();
                var output = JsonConvert.DeserializeObject<List<User>>(json);

                foreach (var item in output)
                {
                    Users.Add(item.Username, item.Password);
                }
            }

            string password = textBox2.Text;

            if (Users.TryGetValue(textBox1.Text, out password))
            {
                
                Account acc = new Account();
                acc.Show();
                
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
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
