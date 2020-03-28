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
    public partial class Inlogscherm : Form
    {
        public Inlogscherm()
        {
            InitializeComponent();
        }

        private void Terugklik(object sender, MouseEventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.ShowDialog();
        }
    }
}
