using System.Windows.Forms;

namespace Project_B
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();

            label1.Text = Login.Username;
            label2.Text = Login.Email;
            label3.Text = Login.Adres;
            label4.Text = Login.DOB;

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
