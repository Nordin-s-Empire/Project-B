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
            
            aantal.Text = "$" + (Reservatie.amount_of_reserved_seats * 11.0).ToString() + " ( $11.00 x " + Reservatie.amount_of_reserved_seats + ")";
            list_of_seats.Text = string.Join(", ", Reservatie.reserved_seats);

            if(Programma.form == 1)
            {
                Film_naam.Text = Programma.movie;
            }
            else
            {
                Film_naam.Text = FIlmInfo.movie_title;
            }
            pictureBox1.Image = FIlmInfo.pic;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = "Aantal";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listbox1 = new ListBox();
            listbox1.Name = "ListBox1";
        }

    
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listbox2 = new ListBox();
            listbox2.Name = "ListBox1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kies aub een bank");

        }
                
               
         
        
           
      
           

           
            
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reservatie reservatie = new Reservatie();
            reservatie.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void Betaalscherm_Load(object sender, EventArgs e)
        {

        }

        private void list_of_seats_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ListBox listbox1 = new ListBox();
            listbox1.Name = "ListBox1";
        }

        private void listBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ListBox listbox2 = new ListBox();
            listbox2.Name = "ListBox2";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("U hebt betaald");

        }
    }
}
