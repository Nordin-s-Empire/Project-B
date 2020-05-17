﻿using System;
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

                foreach (var item in output)
                {
                    Users.Add(item.Username, item.Password);
                    Email = item.Email;
                    DOB = item.DOB;
                    Adres = item.Adres;
                }
            }

            string password = textBox2.Text;

            if (Users.TryGetValue(textBox1.Text, out password))
            {
                Username = textBox1.Text;
                this.Hide();
                Account account = new Account();
                account.Show();

            }
            else
            {
                MessageBox.Show("NO");
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
    }
}
