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
    public partial class StoelenReservatie : Form
    {
        public StoelenReservatie()
        {
            InitializeComponent();

            Seats seats = new Seats()
            {
                SeatName = "A1",
                SeatAvailability = true
            };

        }

        private bool clickedA1, clickedA2, clickedA3;

        private void seatA1_Click(object sender, EventArgs e)
        {
            seatA1.BackColor = Color.Red;
            Seats seat_A1 = new Seats();
            seat_A1.SeatAvailability = false;
            clickedA1 = true;

        }

        private void seatA2_Click(object sender, EventArgs e)
        {
            seatA2.BackColor = Color.Red;
            Seats seat_A2 = new Seats();
            seat_A2.SeatAvailability = false;
            clickedA2 = true;


        }

        private void seatA3_Click(object sender, EventArgs e)
        {
            seatA3.BackColor = Color.Red;
            Seats seat_A3 = new Seats();
            seat_A3.SeatAvailability = false;
            clickedA3 = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> seats = new List<string>();
            for(int i = 0; i < 1; i++)
            {
                if (clickedA1)
                {
                    seats.Add("A1");
                }
                
                if (clickedA2)
                {
                    seats.Add("A2");
                }

                if (clickedA3)
                {
                    seats.Add("A3");
                }
            }

            MessageBox.Show(textBox1.Text + " " + String.Join(", ", seats), "Uw reservatie");
        }
    }
}
