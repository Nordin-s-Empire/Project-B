using System.Windows.Forms;

namespace Project_B
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();

            MessageBox.Show("Welcome");
            
            label1.Text = "Welkom, " + Login.Username;
            textBox1.Text = Login.Email;
            textBox2.Text = Login.Adres;
            textBox3.Text = Login.DOB;

        }

        public void AcctoMain(object sender, MouseEventArgs e)
        { 
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
            menu.HideLoginbutton(false);    
        }
    }
}
