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

        public void AcctoMain(object sender, MouseEventArgs e)
        {
            this.Hide();
            //Form1 menu = new Form1();
            //menu.Show();
            Confirmatiescherm2 con = new Confirmatiescherm2();
            con.Show();
            
        }

        private void uitloggen_Click(object sender, System.EventArgs e)
        {
            this.Close();
            Login.loggedin = false;
            MessageBox.Show("U bent uitgelogd!");
            Confirmatiescherm2 con = new Confirmatiescherm2();
            con.Show();

        }
    }
}
