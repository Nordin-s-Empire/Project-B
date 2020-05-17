using System.Windows.Forms;

namespace Project_B
{
    public partial class Account : Form
    {
        public static Login log;
           
        public Account()
        {
            InitializeComponent();

            MessageBox.Show("Welcome");
            Login login = new Login();
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
