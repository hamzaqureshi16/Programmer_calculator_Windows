using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace ProgCalc1
{
    public partial class Form1 : Form
    {
        private bool replace = false;
        private int PrevRes;
        private String PrevOp = "";

        private int padding = 50;



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

        private bool CountOperators()
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
            
            if (Decradio.Checked)
            {
                MainEqBox.Text = PrevRes.ToString();
            }
            else if (Octradio.Checked)
            {
                MainEqBox.Text = DecToOctal(PrevRes.ToString());
            }
            else if (HexRadio.Checked)
            {
                MainEqBox.Text = DecToHexa(PrevRes.ToString());
            }
            else if (Binradio.Checked)
            {

                MainEqBox.Text = DecToBinary(PrevRes.ToString());
            }
            
        }

        //make a method to add labels to memory box
        

        private void OperatorClicked(string op)
        {
            
            //adds the current text of maineqbox and the op to the secondary eqbox
            if (SecondaryEqBox.Text == "")
            {
                PrevRes = int.Parse(DecLabel.Text);
            }

            
                if (SecondaryEqBox.Text.Contains("="))
                {
                //create a label inside memory box
                Label label = new Label();
                label.Text = SecondaryEqBox.Text + PrevRes.ToString();
                label.AutoSize = true;
                label.Location = new Point(0, padding);
                label.Font = new Font("Microsoft Sans Serif", 12);
                //add top and bottom padding to the 
                
                label.ForeColor = Color.White;
                label.BackColor = Color.Transparent;
                label.Margin = new Padding(0, 0, 0, 0);
                label.Padding = new Padding(0, 0, 0, 0);
                label.Size = new Size(0, 0);
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Anchor = AnchorStyles.None;
                label.MaximumSize = new Size(0, 0);
                label.MinimumSize = new Size(0, 0);
                label.Name = "label" + label.GetHashCode();
                MemoryBox.Controls.Add(label);


                padding += 50;


                //MemoryBox.Controls.Add(new Label() { Text = SecondaryEqBox.Text });


                if (Decradio.Checked)
                    {
                        SecondaryEqBox.Text = PrevRes.ToString() + op;
                    }
                    else if (Octradio.Checked)
                    {
                        SecondaryEqBox.Text = DecToOctal(PrevRes.ToString()) + op;
                    }
                    else if (HexRadio.Checked)
                    {
                        SecondaryEqBox.Text = DecToHexa(PrevRes.ToString()) + op;
                    }
                    else if (Binradio.Checked)
                    {
                        SecondaryEqBox.Text = DecToBinary(PrevRes.ToString()) + op;

                    }
                
               
                        

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
                        PrevRes += int.Parse(DecLabel.Text);
                        break;
                    case "-":
                        PrevRes += int.Parse(DecLabel.Text);
                        break;
                    case "*":
                        PrevRes *= int.Parse(DecLabel.Text);
                        break;
                    case "/":
                        PrevRes /= int.Parse(DecLabel.Text);
                        break;
                    case "%":
                        PrevRes %= int.Parse(DecLabel.Text);
                        break;
                    case "AND":
                        PrevRes = PrevRes & int.Parse(DecLabel.Text);
                        break;
                    case "OR":
                        PrevRes = PrevRes | int.Parse(DecLabel.Text);
                        break;
                    case "NOT":
                        PrevRes = ~PrevRes;
                        SecondaryEqBox.Text = PrevRes.ToString();
                        break;
                    case "NAND":
                        PrevRes = ~(PrevRes & int.Parse(DecLabel.Text));
                        break;
                    case "NOR":
                        PrevRes = ~(PrevRes | int.Parse(DecLabel.Text));
                        break;
                    case "XOR":
                        PrevRes = PrevRes ^ int.Parse(DecLabel.Text);
                        break;
                }

                if (op != "=")
                {
                    PrevOp = op;
                }
                

                if (Decradio.Checked)
                {
                    MainEqBox.Text = PrevRes.ToString();
                }
                else if (Octradio.Checked)
                {
                    MainEqBox.Text = DecToOctal(PrevRes.ToString());
                }
                else if (HexRadio.Checked)
                {
                    MainEqBox.Text = DecToHexa(PrevRes.ToString());
                }
                else if (Binradio.Checked)
                {
                    MainEqBox.Text = DecToBinary(PrevRes.ToString());
                   
                }

                
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

        private string TwosCompliment(string binary)
        {
          
            binary = binary.PadLeft(8, '0');
            StringBuilder str = new StringBuilder(binary);
                int n = str.Length;

                // Traverse the string to get
                // first '1' from the last of string
                int i;
                for (i = n - 1; i >= 0; i--)
                {
                    if (str[i] == '1')
                    {
                        break;
                    }
                }

                // If there exists no '1' concat 1
                // at the starting of string
                if (i == -1)
                {
                    return "1" + str;
                }

                // Continue traversal after the
                // position of first '1'
                for (int k = i - 1; k >= 0; k--)
                {
                    // Just flip the values
                    if (str[k] == '1')
                    {
                        str.Remove(k, k + 1 - k).Insert(k, "0");
                    }
                    else
                    {
                        str.Remove(k, k + 1 - k).Insert(k, "1");
                    }
                }

                // return the modified string
                return str.ToString();
            }
        

        private string DecToBinary(string toConvert)
        {
            bool isNegative = default;
            if (toConvert != "" && toConvert != "0")
            {
                int num = Convert.ToInt32(toConvert);
                if (num < 0)
                {
                    num *= -1;
                    isNegative = true;
                }
                string binary = "";
                while (num > 0)
                {
                    int rem = num % 2;
                    binary = rem.ToString() + binary;
                    num = num / 2;
                }
                if (isNegative)
                {
                    
                    binary = TwosCompliment( binary);

                    return binary;
                }
                return binary;
            }
            else
            {
                return "0";
            }
        }

        private string DecToOctal(string toConvert)
        {
            if (toConvert != "" && toConvert != "0"  )
            {

                
                int num = Convert.ToInt32(toConvert);

                if (num <0)
                {
                    num *= -1;
                }
                string octal = "";
                while (num > 0)
                {
                    int rem = num % 8;
                    octal = rem.ToString() + octal;
                    num = num / 8;
                }
                return octal;
            }
            else
            {
                return "0";
            }
            
        }

        //for converting decimal values to hexadecimal
        private string DecToHexa(string toConvert)
        {
            if (toConvert != "" && toConvert != "0"  )
            {
                string deciaml;
                if (!toConvert.Contains('-'))
                {
                     deciaml = toConvert;
                }
                else
                {
                    deciaml = (Math.Pow(2, 32) + int.Parse(toConvert)).ToString();
                }
            
                string hex = "";
                while (deciaml != "0")
                {
                    long temp = long.Parse(deciaml) % 16;


                    hex += temp < 10 ? (char)(48 + temp) : (char)(55 + temp);
                    deciaml = (long.Parse(deciaml) / 16).ToString();
                }

                //reverse the string hex
                char[] arr = hex.ToCharArray();
                Array.Reverse(arr);
                hex = new string(arr);
                return hex;
            }
            


            else
            {
                return "0";
            }
        }






        private String BinaryToDec(string toConvert)
        {
            if (toConvert != "" && toConvert != "0")
            {
                int num = Convert.ToInt32(toConvert);
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
                return dec.ToString();
            }
            else
            {
                return  "0";
            }
           



        }


        private string OctalToDec(string toConvert)
        {
            if (toConvert != "" && toConvert != "0")
            {
                int num = Convert.ToInt32(toConvert);
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
                return  dec.ToString();
            }
            else
            {
                 return "0";
            }
        }


        private string HexToDec(string toConvert)
        {
            if (toConvert != "" && toConvert != "0")
            {
                string hex = toConvert;
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
                return dec.ToString();
            }
            else
            {
                return "0";
            }
        }




        
            //handles changes of user input
            private void MainEqOnChange(object sender, EventArgs e)
        {
            if (Decradio.Checked)
            {
                HexLabel.Text = DecToHexa(MainEqBox.Text);
                Octlabel.Text = DecToOctal(MainEqBox.Text);
                BinaryLabel.Text = DecToBinary(MainEqBox.Text);
                DecLabel.Text = MainEqBox.Text;
            }
            else if (Binradio.Checked)
            {
                DecLabel.Text = BinaryToDec(MainEqBox.Text);
                HexLabel.Text = DecToHexa(DecLabel.Text);
                Octlabel.Text = DecToOctal(DecLabel.Text);
                BinaryLabel.Text = MainEqBox.Text;

            }
            else if (HexRadio.Checked)
            {
                DecLabel.Text = HexToDec(MainEqBox.Text);
                Octlabel.Text = DecToOctal(DecLabel.Text);
                BinaryLabel.Text = DecToBinary(DecLabel.Text);
                HexLabel.Text = MainEqBox.Text;

            }
            else if (Octradio.Checked)
            {
                DecLabel.Text = OctalToDec(MainEqBox.Text);
                HexLabel.Text = DecToHexa(DecLabel.Text);
                BinaryLabel.Text = DecToBinary(DecLabel.Text);
                Octlabel.Text = MainEqBox.Text;
            }
        }

        private void DecMode(object sender, EventArgs e)
        {
            if (Decradio.Checked)
            {
                this.PlusMinusButton.Enabled = true;
                this.AButton.Enabled = false;
                this.BButton.Enabled = false;
                this.CButton.Enabled = false;
                this.DButton.Enabled = false;
                this.EButton.Enabled = false;
                this.FButton.Enabled = false;
            }
            else
            {
                this.PlusMinusButton.Enabled = false;
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
        private void HexMode(object sender, EventArgs e)
        {
            if (HexRadio.Checked)
            {
                this.AButton.Enabled = true;
                this.BButton.Enabled = true;
                this.CButton.Enabled = true;
                this.DButton.Enabled = true;
                this.EButton.Enabled = true;
                this.FButton.Enabled = true;
            }
            else
            {
                this.AButton.Enabled = false;
                this.BButton.Enabled = false;
                this.CButton.Enabled = false;
                this.DButton.Enabled = false;
                this.EButton.Enabled = false;
                this.FButton.Enabled = false;
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

        private void Logical_Operator_Clicked(object sender, EventArgs e)
        {
            ToolStripMenuItem button = (ToolStripMenuItem)sender;
            OperatorClicked(button.Text);  
            
        }

        private void Sign_clicked(object sender, EventArgs e)
        {
            if (Decradio.Checked)
            {
                MainEqBox.Text = (-1 * int.Parse(MainEqBox.Text)).ToString();
            }
            
        }
    }
}