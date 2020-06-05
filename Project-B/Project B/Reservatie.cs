using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Newtonsoft.Json;

namespace Project_B
{
    public partial class Reservatie : Form
    {
        List<Button> row_A = new List<Button>();
        List<Button> row_B = new List<Button>();
        List<Button> row_C = new List<Button>();
        List<Button> buttons = new List<Button>();
        public static string[] stoel = new string[24];
        Dictionary<string, string> seats = new Dictionary<string, string>();
        public static List<string> reserved_seats = new List<string>();
        public static int amount_of_reserved_seats = 0;

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
            var ch = b.Name.ToCharArray();

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
            string json = File.ReadAllText("../../Seats.json");
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            List<string> name = new List<string>(); 
            int i = 0;

            foreach (Button button in buttons)
            {
                if (button.BackColor == Color.Green)
                {
                    jsonObj[i]["Availability"] = "0";
                    reserved_seats.Add(button.Name);
                    amount_of_reserved_seats++;
                }
                i++;
            }

            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("../../Seats.json", output);

            this.Hide();
            Confirmatiescherm confirmatiescherm = new Confirmatiescherm();
            confirmatiescherm.Show();
        }

        public class Seats
        {
            public string Seat;
            public string Availability;
        }

        private void Reservatie_Load(object sender, EventArgs e)
        {
            reserved_seats.Clear();
            amount_of_reserved_seats = 0;

            using (StreamReader r = new StreamReader(@"../../Seats.json"))
            {
                string json = r.ReadToEnd();
                var output = JsonConvert.DeserializeObject<List<Seats>>(json);

                foreach (var item in output)
                {
                    seats.Add(item.Seat, item.Availability);
                }
            }

            foreach (Button button in buttons)
            {
                for (int i = 0; i < seats.Count; i++)
                {
                    if (seats[button.Name] == "0")
                    {
                        button.BackColor = Color.Red;
                    }
                }
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
            for (int i = 0; i < buttons.Count; i++)
            {
                string json = File.ReadAllText(@"../../Seats.json");
                dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
                jsonObj[i]["Availability"] = "1";
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(@"../../Seats.json", output);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            MessageBox.Show("U gaat nu terug naar het hoofdscherm");
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Show();
        }
    }
}