﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            this.Hide();
            Programma program = new Programma();
            program.Show();
        }

        private void btnZoeken_Click(object sender, EventArgs e)
        {
            Zoeken zoek = new Zoeken();
            zoek.Show();
        }

        private void btnAcount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
