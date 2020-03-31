using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_B
{
    public partial class Account : Form
    {

        private Login log;
        
        
        public Account()
        {
            InitializeComponent();
        }

        public void AcctoMain(object sender, MouseEventArgs e)
        {
            
            this.Hide();
            Form1 menu = new Form1();
            menu.ShowDialog();
            
        }

        private void Account_Load(object sender, EventArgs e)
        {
            log = new Login();
            
            textBox1.Text = log.textBox1.Text;
            
        }
    }
}
