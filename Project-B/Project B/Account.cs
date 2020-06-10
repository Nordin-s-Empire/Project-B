using System.Windows.Forms;

namespace Project_B
{
    public partial class Account : Form
    {


        public Account()
        {
            InitializeComponent();

            //MessageBox.Show("Welcome");

            label1.Text = "Welkom, " + Login.Username;
            textBox1.Text = Login.Email;
            textBox2.Text = Login.Adres;
            textBox3.Text = Login.DOB;
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
            this.Hide();
            MessageBox.Show("U gaat nu terug naar het hoofdscherm.");
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
