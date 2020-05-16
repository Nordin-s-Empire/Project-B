using System.Windows.Forms;

namespace Project_B
{
    public partial class Account : Form
    {
        public static Login log;
           
        public Account(string txt)
        {
            InitializeComponent();

            MessageBox.Show("Welcome");
            label1.Text = "Welkom, " + txt;
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
