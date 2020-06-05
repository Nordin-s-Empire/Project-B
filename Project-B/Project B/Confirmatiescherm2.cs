using Betaalscherm_versie_3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Confirmatiescherm confirmatiescherm = new Confirmatiescherm();
            confirmatiescherm.Show();
        }
    }
}
