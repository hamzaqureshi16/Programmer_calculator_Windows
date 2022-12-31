using System;
using System.Runtime.CompilerServices;

namespace ProgCalc1
{
    public partial class Form1 : Form
    {
        private bool replace = false;
        private int PrevRes;
        private String PrevOp = "";
        private bool criticalSection = false;



        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            Decradio.Checked = true;
            DecLabel.Text = "0";
            HexLabel.Text = "0";
            BinaryLabel.Text = "0";
            Octlabel.Text = "0";
        }

        void AddtoMainEQ(string letter)
        {
            if (!replace)
            {
                if (MainEqBox.Text == "0")
                {
                    if (letter != "0")
                    {
                        MainEqBox.Text = letter;
                    }
                }
                else
                {
                    MainEqBox.Text += letter;
                }
            }
            else
            {
                MainEqBox.Text = letter;
                replace = false;
            }
        }

     
        private void Backspace(object sender, EventArgs e)
        {
            if (MainEqBox.Text.Length > 0 && MainEqBox.Text != "0")
            {
                MainEqBox.Text = MainEqBox.Text.Substring(0, MainEqBox.Text.Length - 1);
                if (MainEqBox.Text.Length == 0)
                {
                    MainEqBox.Text = "0";
                }
            }
           
            
        }

        private bool countOperators()
        {
            int count = 0;
            foreach (char h in SecondaryEqBox.Text)
            {
                if (h == '+' || h == '-' || h == '*' || h == '/')
                {
                    count++;
                    if(count > 1)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            OperatorClicked("=");
            MainEqBox.Text = PrevRes.ToString();
        }
        private void OperatorClicked(string op)
        {

            //adds the current text of maineqbox and the op to the secondary eqbox
            if(SecondaryEqBox.Text == "")
            {
                PrevRes = int.Parse(MainEqBox.Text);
            }

            if (SecondaryEqBox.Text.Contains("="))
            {
                SecondaryEqBox.Text = PrevRes.ToString() + op;
                PrevOp = "";
            }
            else
            {
                SecondaryEqBox.Text += MainEqBox.Text + op;
            }

                
            
            
            if(PrevOp == "" && op != "=")
            {
                PrevOp = op;
            }
            else
            {
                switch (PrevOp)
                {
                    case "+":
                        PrevRes += int.Parse(MainEqBox.Text);
                        break;
                    case "-":
                        PrevRes += int.Parse(MainEqBox.Text);
                        break;
                    case "*":
                        PrevRes *= int.Parse(MainEqBox.Text);
                        break;
                    case "/":
                        PrevRes /= int.Parse(MainEqBox.Text);
                        break;
                    case "%":
                        PrevRes %= int.Parse(MainEqBox.Text);
                        break;
                }

                if (op != "=")
                {
                    PrevOp = op;
                }
              
                MainEqBox.Text = PrevRes.ToString();
            }
            //this flag lets the number stay in the MainEqBox and doesn't clear it. The next time any digit is added to the MainEqBox it'll first 
            //clear the box and then do its thing
            replace = true;

           



        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            OperatorClicked("+");

        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            OperatorClicked("-");
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            OperatorClicked("*");
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            OperatorClicked("/");
        }

        private void ModuloButton_Click(object sender, EventArgs e)
        {
            OperatorClicked("%");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            MainEqBox.Text = "0";
            SecondaryEqBox.Text = "";
        }
        

        
        private void DecToBinary()
        {
            if (MainEqBox.Text != "" && MainEqBox.Text != "0")
            {
                int num = Convert.ToInt32(MainEqBox.Text);
                string binary = "";
                while (num > 0)
                {
                    int rem = num % 2;
                    binary = rem.ToString() + binary;
                    num = num / 2;
                }
                BinaryLabel.Text = binary;
            }
            else
            {
                BinaryLabel.Text = "0";
            }
        }

        private void DecToOctal()
        {
            if (MainEqBox.Text != "" && MainEqBox.Text != "0")
            {
                int num = Convert.ToInt32(MainEqBox.Text);
                string octal = "";
                while (num > 0)
                {
                    int rem = num % 8;
                    octal = rem.ToString() + octal;
                    num = num / 8;
                }
                Octlabel.Text = octal;
            }
            else
            {
                Octlabel.Text = "0";
            }
            
        }

        //for converting decimal values to hexadecimal
        private void DecToHexa()
        {
            if (MainEqBox.Text != "" && MainEqBox.Text != "0")
            {
                string deciaml = MainEqBox.Text;
                string hex = "";
                while (deciaml != "0")
                {
                    int temp = int.Parse(deciaml) % 16;


                    hex += temp < 10 ? (char)(48 + temp) : (char)(55 + temp);
                    deciaml = (int.Parse(deciaml) / 16).ToString();
                }

                //reverse the string hex
                char[] arr = hex.ToCharArray();
                Array.Reverse(arr);
                hex = new string(arr);
                HexLabel.Text = hex;
            }
            else
            {
                HexLabel.Text = "0";
            }
        }





        private void BinaryToDec()
        {
            if (MainEqBox.Text != "" && MainEqBox.Text != "0")
            {
                int num = Convert.ToInt32(MainEqBox.Text);
                int dec = 0;
                int base1 = 1;
                int temp = num;
                while (temp > 0)
                {
                    int lastdigit = temp % 10;
                    temp = temp / 10;
                    dec += lastdigit * base1;
                    base1 = base1 * 2;
                }
                DecLabel.Text = dec.ToString();
            }
            else
            {
                DecLabel.Text = "0";
            }
           



        }


        private void OctalToDec()
        {
            if (MainEqBox.Text != "" && MainEqBox.Text != "0")
            {
                int num = Convert.ToInt32(MainEqBox.Text);
                int dec = 0;
                int base1 = 1;
                int temp = num;
                while (temp > 0)
                {
                    int lastdigit = temp % 10;
                    temp = temp / 10;
                    dec += lastdigit * base1;
                    base1 = base1 * 8;
                }
                DecLabel.Text = dec.ToString();
            }
            else
            {
                DecLabel.Text = "0";
            }
        }


        private void HexToDec()
        {
            if (MainEqBox.Text != "" && MainEqBox.Text != "0")
            {
                string hex = MainEqBox.Text;
                int dec = 0;
                int base1 = 1;
                for (int i = hex.Length - 1; i >= 0; i--)
                {
                    if (hex[i] >= '0' && hex[i] <= '9')
                    {
                        dec += (hex[i] - 48) * base1;
                        base1 = base1 * 16;
                    }
                    else if (hex[i] >= 'A' && hex[i] <= 'F')
                    {
                        dec += (hex[i] - 55) * base1;
                        base1 = base1 * 16;
                    }
                }
                DecLabel.Text = dec.ToString();
            }
            else
            {
                DecLabel.Text = "0";
            }
        }




        
            //handles changes of user input
            private void MainEqOnChange(object sender, EventArgs e)
        {
            if (Decradio.Checked)
            {
                DecToHexa();
                DecToOctal();
                DecToBinary();
                DecLabel.Text = MainEqBox.Text;
            }
            else if (Binradio.Checked)
            {
                BinaryToDec();
                BinaryLabel.Text = MainEqBox.Text;

                //criticalsection code
                if (!criticalSection)
                {
                    criticalSection = true;
                    string temp = MainEqBox.Text;
                    MainEqBox.Text = DecLabel.Text;
                    DecToHexa();
                    DecToOctal();

                    MainEqBox.Text = temp;
                    criticalSection = false;
                }

            }
            else if (HexRadio.Checked)
            {
                HexToDec();
                HexLabel.Text = MainEqBox.Text;
                if (!criticalSection)
                {
                    criticalSection = true;
                    string temp = MainEqBox.Text;
                    MainEqBox.Text = DecLabel.Text;
                    DecToBinary();
                    DecToOctal();
                    MainEqBox.Text = temp;
                    criticalSection = false;
                    
                }
            }
            else if (Octradio.Checked)
            {
                OctalToDec();
                Octlabel.Text = MainEqBox.Text;
                if (!criticalSection)
                {
                    criticalSection = true;
                    string temp = MainEqBox.Text;
                    MainEqBox.Text = DecLabel.Text;
                    DecToHexa();
                    DecToBinary();
                    MainEqBox.Text = temp;
                    criticalSection = false;
                }
            }
        }

        private void DecMode(object sender, EventArgs e)
        {
            if (Decradio.Checked)
            {
                this.AButton.Enabled = false;
                this.BButton.Enabled = false;
                this.CButton.Enabled = false;
                this.DButton.Enabled = false;
                this.EButton.Enabled = false;
                this.FButton.Enabled = false;
            }
            else
            {
                this.AButton.Enabled = true;
                this.BButton.Enabled = true;
                this.CButton.Enabled = true;
                this.DButton.Enabled = true;
                this.EButton.Enabled = true;
                this.FButton.Enabled = true;
            }
        }

     
        private void EnableChange(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (!button.Enabled)
            {
                button.BackColor = Color.Gray;
            }
            else 
            {
                button.BackColor = Color.DarkCyan;    
            }
            
        }

        private void OctMode(object sender, EventArgs e)
        {
            if (Octradio.Checked)
            {
                this.NineButton.Enabled = false;
                this.EightButton.Enabled = false;
                this.AButton.Enabled = false;
                this.BButton.Enabled = false;
                this.CButton.Enabled = false;
                this.DButton.Enabled = false;
                this.EButton.Enabled = false;
                this.FButton.Enabled = false;
            }
            else
            {
                this.NineButton.Enabled = true;
                this.EightButton.Enabled = true;
                this.AButton.Enabled = true;
                this.BButton.Enabled = true;
                this.CButton.Enabled = true;
                this.DButton.Enabled = true;
                this.EButton.Enabled = true;
                this.FButton.Enabled = true;
            }
        }

        private void BinMode(object sender, EventArgs e)
        {
            if (Binradio.Checked)
            {
                this.TwoButton.Enabled = false;
                this.ThreeButton.Enabled = false;
                this.FourButton.Enabled = false;
                this.FiveButton.Enabled = false;
                this.SixButton.Enabled = false;
                this.SevenButton.Enabled = false;
                this.EightButton.Enabled = false;
                this.NineButton.Enabled = false;
                this.AButton.Enabled = false;
                this.BButton.Enabled = false;
                this.CButton.Enabled = false;
                this.DButton.Enabled = false;
                this.EButton.Enabled = false;
                this.FButton.Enabled = false;
            }
            else 
            {
                this.ThreeButton.Enabled = true;
                this.TwoButton.Enabled = true;
                this.FourButton.Enabled = true;
                this.FiveButton.Enabled = true;
                this.SixButton.Enabled = true;
                this.SevenButton.Enabled = true;
                this.EightButton.Enabled = true;
                this.NineButton.Enabled = true;
                this.AButton.Enabled = true;
                this.BButton.Enabled = true;
                this.CButton.Enabled = true;
                this.DButton.Enabled = true;
                this.EButton.Enabled = true;
                this.FButton.Enabled = true;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            MainEqBox.Text = "0";
            SecondaryEqBox.Text = "";
            PrevRes = 0;
            PrevOp = "";
        }

        private void HexChar_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            AddtoMainEQ(button.Text);
        }

        private void Digit_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            AddtoMainEQ(button.Text);
        }
    }
}