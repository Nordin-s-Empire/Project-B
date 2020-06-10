using Betaalscherm_versie_3;
using System;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Project_B
{
    public partial class Confirmatiescherm2 : Form
    {
        public static string email = "";
        

        public Confirmatiescherm2()
        {
            
            InitializeComponent();
            
            if (Login.loggedin == true)
            {
                accbtn.Visible = true;
                
                btnLogIn.Visible = false;
                label3.Text = "U bent ingelogd! Klik 'verder' om te betalen";
                label6.Visible = true;
                label7.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                txbEmail.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                btnRegister.Visible = false;

            }
            else
            {
                accbtn.Visible = false;
                label6.Visible = false;
                btnLogIn.Visible = true;
                label7.Visible = true;
            }
            
        }

        public static async Task<bool> Change()
        {
            return await Task.Run(() =>
            {
                return true;
            });
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form2 registratie = new Form2();
            registratie.Show();
        }

        private async void btnLogIn_Click(object sender, EventArgs e)
        {
            Login inloggen = new Login();
            inloggen.Show();
            bool result = await Change();
            if (result == true)
            {
                accbtn.Visible = true;          
            }
            else
            {
                accbtn.Visible = false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            email = txbEmail.Text;
            
            if (email == "" && Login.loggedin == false)
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

        private void accbtn_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.Show();
            this.Hide();
        }

        private void uitloggenbtn_Click(object sender, EventArgs e)
        {
            Login.loggedin = false;
            

        }

        
    }
}
