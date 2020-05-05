using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace Project_B
{
    public partial class Reservatie : Form
    {
        List<Button> row_A = new List<Button>();
        List<Button> row_B = new List<Button>();
        List<Button> row_C = new List<Button>();
        List<Button> buttons = new List<Button>();
        List<Button> row_1 = new List<Button>();
        public static String stoel;


        public Reservatie()
        {
            InitializeComponent();

            //here I add A seats to row_A
            row_A.Add(A1);
            row_A.Add(A2);
            row_A.Add(A3);
            row_A.Add(A4);
            row_A.Add(A5);
            row_A.Add(A6);
            row_A.Add(A7);
            row_A.Add(A8);

            //here I add B seats to row_B
            row_B.Add(B1);
            row_B.Add(B2);
            row_B.Add(B3);
            row_B.Add(B4);
            row_B.Add(B5);
            row_B.Add(B6);
            row_B.Add(B7);
            row_B.Add(B8);

            //here I add C seats to row_C
            row_C.Add(C1);
            row_C.Add(C2);
            row_C.Add(C3);
            row_C.Add(C4);
            row_C.Add(C5);
            row_C.Add(C6);
            row_C.Add(C7);
            row_C.Add(C8);

            //here I add ALL BUTTONS to the buttons list
            buttons.Add(A1);
            buttons.Add(A2);
            buttons.Add(A3);
            buttons.Add(A4);
            buttons.Add(A5);
            buttons.Add(A6);
            buttons.Add(A7);
            buttons.Add(A8);

            buttons.Add(B1);
            buttons.Add(B2);
            buttons.Add(B3);
            buttons.Add(B4);
            buttons.Add(B5);
            buttons.Add(B6);
            buttons.Add(B7);
            buttons.Add(B8);

            buttons.Add(C1);
            buttons.Add(C2);
            buttons.Add(C3);
            buttons.Add(C4);
            buttons.Add(C5);
            buttons.Add(C6);
            buttons.Add(C7);
            buttons.Add(C8);

        }

        private void Enable_Row(List<Button> buttonlist)
        {
            foreach (Button button in buttonlist)
            {
                if (button.BackColor == Color.Red)
                {
                    button.BackColor = Color.Red;
                }
                else
                {
                    button.BackColor = Color.White;
                    button.Enabled = true;
                }


            }
        }

        private void Disable_Row(List<Button> buttonlist)

        {
            foreach (Button button in buttonlist)
            {
                if (button.BackColor == Color.Red)
                {
                    button.BackColor = Color.Red;

                }
                else
                {
                    button.BackColor = Color.Gray;
                }

                button.Enabled = false;

            }
        }

        private void Button_click(object sender, EventArgs e)
        {
            var b = (Button)sender;
            stoel = b.Name;

            var ch = b.Name.ToCharArray();

            int x = ch[1] + 1;
            int y = ch[1] - 1;

            if (b.BackColor == Color.Green)
            {

                if (ch[0] == 'A')
                {
                    Enable_Row(row_B);
                    Enable_Row(row_C);

                }

                if (ch[0] == 'B')
                {
                    Enable_Row(row_A);
                    Enable_Row(row_C);

                }

                if (ch[0] == 'C')
                {
                    Enable_Row(row_A);
                    Enable_Row(row_B);
                }

                b.BackColor = Color.White;
            }

            else
            {

                if (ch[0] == 'A')
                {
                    Disable_Row(row_B);
                    Disable_Row(row_C);

                }

                if (ch[0] == 'B')
                {
                    Disable_Row(row_A);
                    Disable_Row(row_C);

                }

                if (ch[0] == 'C')
                {
                    Disable_Row(row_A);
                    Disable_Row(row_B);
                }

                b.BackColor = Color.Green;
            }

        }

        private void OK_Click(object sender, EventArgs e)
        {
            string connStr = "server=sql7.freemysqlhosting.net;user=sql7337554;database=sql7337554;port=3306;password=chz3lfHBcK";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "UPDATE Seats SET Availability= @Available WHERE SeatID = @SeatID";
                comm.Parameters.AddWithValue("@Available", 0);
                comm.Parameters.AddWithValue("@SeatID", stoel);
                comm.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Reservatie_Load(object sender, EventArgs e)
        {
            string connStr = "server=sql7.freemysqlhosting.net;user=sql7337554;database=sql7337554;port=3306;password=chz3lfHBcK";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "Select * FROM Seats";
                comm.ExecuteNonQuery();

                MySqlDataReader rdr = comm.ExecuteReader();

                string Output = "";

                while (rdr.Read())
                {
                    foreach (Button button in buttons)
                    {
                        if (rdr.GetValue(0).ToString() == button.Name)
                        {
                            if (rdr.GetValue(1).ToString() == "False")
                            {

                                Output = Output + rdr.GetValue(0) + " - " + rdr.GetValue(1) + "\n";
                                button.BackColor = Color.Red;

                            }
                        }
                    }
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            foreach (Button button in buttons)
            {
                if (button.BackColor == Color.Red)
                {
                    button.Enabled = false;
                }
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            string connStr = "server=sql7.freemysqlhosting.net;user=sql7337554;database=sql7337554;port=3306;password=chz3lfHBcK";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "UPDATE Seats SET Availability = @Available";
                comm.Parameters.AddWithValue("@Available", 1);
                comm.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
