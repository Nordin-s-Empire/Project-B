using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_B
{
    public partial class Account : Form
    {
        public static Login log;
           
        public Account()
        {
            InitializeComponent();

            Account_Load("Welkom best klant", EventArgs.Empty);
        }

        public void AcctoMain(object sender, MouseEventArgs e)
        { 
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
            menu.HideLoginbutton(false);    
        }

        private void Account_Load(string txt, EventArgs e)
        {
            label1.Text = txt;
        }

        private void Label(object sender, EventArgs e)
        {

        }
    }
}
