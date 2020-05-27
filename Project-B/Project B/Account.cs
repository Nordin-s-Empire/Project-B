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
        }

        public void AcctoMain(object sender, MouseEventArgs e)
        { 
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
            menu.HideLoginbutton(false);    
        }

        private void Account_Load(object sender, System.EventArgs e)
        {

        }
    }
}
