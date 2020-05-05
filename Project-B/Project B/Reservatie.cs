using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_B
{
    public partial class Reservatie : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nikol\Documents\Seats_Data.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand command;
        SqlDataReader dataReader;
        String sql, Output = "";


        List<Button> row_A = new List<Button>();
        List<Button> row_B = new List<Button>();
        List<Button> row_C = new List<Button>();
        List<Button> buttons = new List<Button>();
        List<Button> row_1 = new List<Button>();


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

            Button b = (Button)sender;

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

        private void Reset_Seats()
        {
            con.Open();

            SqlCommand command_reset;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql_reset = "";

            command_reset = new SqlCommand(sql_reset, con);

            sql_reset = "UPDATE Seats SET Availability = @Available";
            adapter.UpdateCommand = new SqlCommand(sql_reset, con);
            adapter.UpdateCommand.Parameters.AddWithValue("@Available", true);
            adapter.UpdateCommand.ExecuteNonQuery();

            command_reset.Dispose();
            con.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand command1;
            SqlCommand command2;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql1 = "";
            String sql2 = "";

            command1 = new SqlCommand(sql1, con);
            command2 = new SqlCommand(sql2, con);

            foreach (Button button in buttons)
            {

                if (button.BackColor == Color.Green)
                {

                    sql1 = "UPDATE Seats SET Availability= @Available WHERE SeatID = @SeatID";
                    adapter.UpdateCommand = new SqlCommand(sql1, con);
                    adapter.UpdateCommand.Parameters.AddWithValue("@Available", false);
                    adapter.UpdateCommand.Parameters.AddWithValue("@SeatID", button.Name);
                    adapter.UpdateCommand.ExecuteNonQuery();

                    sql2 = "INSERT INTO Reservations (SeatID) VALUES (@SeatID)";
                    adapter.InsertCommand = new SqlCommand(sql2, con);
                    adapter.InsertCommand.Parameters.AddWithValue("SeatID", button.Name);
                    adapter.InsertCommand.ExecuteNonQuery();

                }
            }

            command1.Dispose();
            command2.Dispose();
            con.Close();

        }

        private void Reservatie_Load(object sender, EventArgs e)
        {
            //Reset_Seats();

            con.Open();

            sql = "Select * FROM Seats";
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                foreach (Button button in buttons)
                {
                    if (dataReader.GetValue(0).ToString() == button.Name)
                    {
                        if (dataReader.GetValue(1).ToString() == "False")
                        {

                            Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n";
                            button.BackColor = Color.Red;

                        }
                    }
                }

            }

            dataReader.Close();
            command.Dispose();
            con.Close();

            foreach (Button button in buttons)
            {
                if (button.BackColor == Color.Red)
                {
                    button.Enabled = false;
                }
            }

        }
    }
}
