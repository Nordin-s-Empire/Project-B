using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Project_B
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            txbDOB.Text = "dd-mm-yyyy";
            txbDOB.ForeColor = Color.Gray;
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
                    Adres = txbDOB.Text,
                    DOB = txbDOB.Text,
                    Username = txbUsername.Text,
                    Password = txbPassword.Text
                }) ;

                jsonData = JsonConvert.SerializeObject(Users);
                System.IO.File.WriteAllText(filePath, jsonData);

                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
                MessageBox.Show("U bent succesvol geregistreerd.");
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        public class User
        {
            public string FirstName;
            public string LastName;
            public string Email;
            public string Adres;
            public string DOB;
            public string Username;
            public string Password;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void lblAdres_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 startscherm = new Form1();
            startscherm.Show();
        }

        private void txbDOB_Enter(object sender, EventArgs e)
        {
            if (txbDOB.Text == "dd-mm-yyyy")
            {
                txbDOB.Text = "";
                txbDOB.ForeColor = Color.Black;
            }
        }

        private void txbDOB_Leave(object sender, EventArgs e)
        {
            if (txbDOB.Text == "")
            {
                txbDOB.Text = "dd-mm-yyyy";
                txbDOB.ForeColor = Color.Gray;
            }
        }
    }
}
