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
        List<Button> row_1 = new List<Button>();
        public static string[] stoel = new string[23];
        public static int l = 0;

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
            stoel[l++] = b.Name;

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
            int i = 0;

            for(int k = 0; k < stoel.Length; k++)
            {
                if(stoel[k] == "A1")
                {
                    i = 0;
                }
                else if(stoel[k] == "A2")
                {
                    i = 1;
                }
                else if (stoel[k] == "A3")
                {
                    i = 2;
                }
                else if (stoel[k] == "A4")
                {
                    i = 3;
                }
                else if (stoel[k] == "A5")
                {
                    i = 4;
                }
                else if (stoel[k] == "A6")
                {
                    i = 5;
                }
                else if (stoel[k] == "A7")
                {
                    i = 6;
                }
                else if (stoel[k] == "A8")
                {
                    i = 7;
                }
                else if (stoel[k] == "B1")
                {
                    i = 8;
                }
                else if (stoel[k] == "B2")
                {
                    i = 9;
                }
                else if (stoel[k] == "B3")
                {
                    i = 10;
                }
                else if (stoel[k] == "B4")
                {
                    i = 11;
                }
                else if (stoel[k] == "B5")
                {
                    i = 12;
                }
                else if (stoel[k] == "B6")
                {
                    i = 13;
                }
                else if (stoel[k] == "B7")
                {
                    i = 14;
                }
                else if (stoel[k] == "B8")
                {
                    i = 15;
                }
                else if (stoel[k] == "C1")
                {
                    i = 16;
                }
                else if (stoel[k] == "C2")
                {
                    i = 17;
                }
                else if (stoel[k] == "C3")
                {
                    i = 18;
                }
                else if (stoel[k] == "C4")
                {
                    i = 19;
                }
                else if (stoel[k] == "C5")
                {
                    i = 20;
                }
                else if (stoel[k] == "C6")
                {
                    i = 21;
                }
                else if (stoel[k] == "C7")
                {
                    i = 22;
                }
                else if (stoel[k] == "C8")
                {
                    i = 23;
                }

                string json = File.ReadAllText("../../Seats.json");
                dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
                jsonObj[i]["Availability"] = "0";
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("../../Seats.json", output);
            }
        }

        public class Seats
        {
            public string Seat;
            public string Availability;
        }

        private void Reservatie_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> Seats = new Dictionary<string, string>();
            using (StreamReader r = new StreamReader(@"../../Seats.json"))
            {
                string json = r.ReadToEnd();
                var output = JsonConvert.DeserializeObject<List<Seats>>(json);

                foreach (var item in output)
                {
                    Seats.Add(item.Seat, item.Availability);
                }
            }

            for (int i = 0; i < Seats.Count; i++)
            {
                if (Seats["A1"] == "0")
                {
                    A1.BackColor = Color.Red;
                }
                else if (Seats["A2"] == "0")
                {
                    A2.BackColor = Color.Red;
                }
                else if (Seats["A3"] == "0")
                {
                    A3.BackColor = Color.Red;
                }
                else if (Seats["A4"] == "0")
                {
                    A4.BackColor = Color.Red;
                }
                else if (Seats["A5"] == "0")
                {
                    A2.BackColor = Color.Red;
                }
                else if (Seats["A6"] == "0")
                {
                    A6.BackColor = Color.Red;
                }
                else if (Seats["A7"] == "0")
                {
                    A7.BackColor = Color.Red;
                }
                else if (Seats["A8"] == "0")
                {
                    A8.BackColor = Color.Red;
                }
                else if (Seats["B1"] == "0")
                {
                    B1.BackColor = Color.Red;
                }
                else if (Seats["B2"] == "0")
                {
                    B2.BackColor = Color.Red;
                }
                else if (Seats["B3"] == "0")
                {
                    B3.BackColor = Color.Red;
                }
                else if (Seats["B4"] == "0")
                {
                    B4.BackColor = Color.Red;
                }
                else if (Seats["B5"] == "0")
                {
                    B5.BackColor = Color.Red;
                }
                else if (Seats["B6"] == "0")
                {
                    B6.BackColor = Color.Red;
                }
                else if (Seats["B7"] == "0")
                {
                    B7.BackColor = Color.Red;
                }
                else if (Seats["B8"] == "0")
                {
                    B8.BackColor = Color.Red;
                }
                else if (Seats["C1"] == "0")
                {
                    C1.BackColor = Color.Red;
                }
                else if (Seats["C2"] == "0")
                {
                    C2.BackColor = Color.Red;
                }
                else if (Seats["C3"] == "0")
                {
                    C3.BackColor = Color.Red;
                }
                else if (Seats["C4"] == "0")
                {
                    C4.BackColor = Color.Red;
                }
                else if (Seats["C5"] == "0")
                {
                    C5.BackColor = Color.Red;
                }
                else if (Seats["C6"] == "0")
                {
                    C6.BackColor = Color.Red;
                }
                else if (Seats["C7"] == "0")
                {
                    C7.BackColor = Color.Red;
                }
                else if (Seats["C8"] == "0")
                {
                    C8.BackColor = Color.Red;
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
            for (int i = 0; i < 24; i++)
            {
                string json = File.ReadAllText(@"../../Seats.json");
                dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
                jsonObj[i]["Availability"] = "1";
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(@"../../Seats.json", output);
            }
        }
    }
}
