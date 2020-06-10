using System.Windows.Forms;

namespace Project_B
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();

            label1.Text = "Welkom, " + Login.Username;
            lblEmail.Text = Login.Email;
            lblAddress.Text = Login.Adres;
            lblDOB.Text = Login.DOB;
        }

        private void uitloggen_Click(object sender, System.EventArgs e)
        {
            this.Close();
            Login.loggedin = false;
            MessageBox.Show("U bent uitgelogd!");
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Menuknopacc_Click(object sender, System.EventArgs e)
        {

        }

        private void Menuknopacc_Click_1(object sender, System.EventArgs e)
        {
            this.Hide();
            MessageBox.Show("U gaat nu terug naar het hoofdscherm.");
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void lblDOB_Click(object sender, System.EventArgs e)
        {

        }
    }
}
