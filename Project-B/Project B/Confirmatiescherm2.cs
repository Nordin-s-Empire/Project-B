using Betaalscherm_versie_3;
using System;
using System.Windows.Forms;

namespace Project_B
{
    public partial class Confirmatiescherm2 : Form
    {
        public static string email = "";

        public Confirmatiescherm2()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form2 registratie = new Form2();
            registratie.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Login inloggen = new Login();
            inloggen.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            email = txbEmail.Text;

            if (email == "")
            {
                MessageBox.Show("Voor u doorgaat moet of inloggen, registreren of uw e-mail adres invullen.");
            }
            else
            {
                this.Hide();
                Betaalscherm betaalscherm = new Betaalscherm();
                betaalscherm.Show();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Confirmatiescherm confirmatiescherm = new Confirmatiescherm();
            confirmatiescherm.Show();
        }
    }
}
