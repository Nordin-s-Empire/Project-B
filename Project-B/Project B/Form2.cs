using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
            try
            {
                var filePath = @"../../Users.Json";
                var jsonData = System.IO.File.ReadAllText(filePath);
                var Users = JsonConvert.DeserializeObject<List<User>>(jsonData)
                                      ?? new List<User>();

                Users.Add(new User()
                {
                    FirstName = txbFNaam.Text,
                    LastName = txbLName.Text,
                    Email = txbEmail.Text,
                    Username = txbUsername.Text,
                    Password = txbPassword.Text,
                    DOB = txbDOB.Text,
                    Adres = txbAdres.Text
                });

                jsonData = JsonConvert.SerializeObject(Users);
                System.IO.File.WriteAllText(filePath, jsonData);
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
            MessageBox.Show("U bent geregistreerd");

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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            this.Hide();
            menu.ShowDialog();
            
        }
    }
}
