using Project_B;
using System;
using System.Windows.Forms;

namespace Betaalscherm_versie_3
{
    public partial class Betaalscherm : Form
    {
        public Betaalscherm()
        {
            InitializeComponent();
        }

        private void Type_Click(object sender, EventArgs e)
        {
            label1.Text = "Type";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = "Prijs";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = "Aantal";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = "Normaal";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Text = "Korting";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label7.Text = "9,00";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Text = "11,00";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listbox1 = new ListBox();
            listbox1.Name = "ListBox1";
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label8.Text = "Bank";
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listbox2 = new ListBox();
            listbox2.Name = "ListBox1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedItem.ToString());
            MessageBox.Show(listBox2.SelectedItem.ToString());
            MessageBox.Show("Je hebt betaald!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reservatie reservatie = new Reservatie();
            reservatie.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            label9.Text = "Kinderticket";
        }

        private void label10_Click(object sender, EventArgs e)
        {
            label10.Text = "6,00";
        }
    }
}
