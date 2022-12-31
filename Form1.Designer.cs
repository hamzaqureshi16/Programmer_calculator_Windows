namespace ProgCalc1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MemoryBox = new System.Windows.Forms.GroupBox();
            this.MainEqBox = new System.Windows.Forms.Label();
            this.SecondaryEqBox = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelPanel = new System.Windows.Forms.Panel();
            this.BinaryLabel = new System.Windows.Forms.Label();
            this.Octlabel = new System.Windows.Forms.Label();
            this.DecLabel = new System.Windows.Forms.Label();
            this.HexLabel = new System.Windows.Forms.Label();
            this.Binradio = new System.Windows.Forms.RadioButton();
            this.Octradio = new System.Windows.Forms.RadioButton();
            this.Decradio = new System.Windows.Forms.RadioButton();
            this.HexRadio = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bitWiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AND = new System.Windows.Forms.ToolStripMenuItem();
            this.OR = new System.Windows.Forms.ToolStripMenuItem();
            this.NOT = new System.Windows.Forms.ToolStripMenuItem();
            this.Nand = new System.Windows.Forms.ToolStripMenuItem();
            this.Nor = new System.Windows.Forms.ToolStripMenuItem();
            this.Xor = new System.Windows.Forms.ToolStripMenuItem();
            this.AButton = new System.Windows.Forms.Button();
            this.BButton = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.DButton = new System.Windows.Forms.Button();
            this.EButton = new System.Windows.Forms.Button();
            this.FButton = new System.Windows.Forms.Button();
            this.PlusMinusButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.EqualButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.ModuloButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.CurlyOpen = new System.Windows.Forms.Button();
            this.CurlyClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.LabelPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MemoryBox
            // 
            this.MemoryBox.BackColor = System.Drawing.Color.Silver;
            this.MemoryBox.Location = new System.Drawing.Point(598, 3);
            this.MemoryBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MemoryBox.Name = "MemoryBox";
            this.MemoryBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MemoryBox.Size = new System.Drawing.Size(262, 743);
            this.MemoryBox.TabIndex = 1;
            this.MemoryBox.TabStop = false;
            this.MemoryBox.Text = "Memory";
            // 
            // MainEqBox
            // 
            this.MainEqBox.BackColor = System.Drawing.Color.Gray;
            this.MainEqBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainEqBox.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainEqBox.Location = new System.Drawing.Point(-1, 40);
            this.MainEqBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MainEqBox.Name = "MainEqBox";
            this.MainEqBox.Size = new System.Drawing.Size(597, 118);
            this.MainEqBox.TabIndex = 2;
            this.MainEqBox.Text = "0";
            this.MainEqBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MainEqBox.TextChanged += new System.EventHandler(this.MainEqOnChange);
            // 
            // SecondaryEqBox
            // 
            this.SecondaryEqBox.BackColor = System.Drawing.Color.Gray;
            this.SecondaryEqBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SecondaryEqBox.Location = new System.Drawing.Point(-1, 3);
            this.SecondaryEqBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SecondaryEqBox.Name = "SecondaryEqBox";
            this.SecondaryEqBox.Size = new System.Drawing.Size(598, 37);
            this.SecondaryEqBox.TabIndex = 3;
            this.SecondaryEqBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.LabelPanel);
            this.panel1.Controls.Add(this.Binradio);
            this.panel1.Controls.Add(this.Octradio);
            this.panel1.Controls.Add(this.Decradio);
            this.panel1.Controls.Add(this.HexRadio);
            this.panel1.Location = new System.Drawing.Point(-1, 155);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 149);
            this.panel1.TabIndex = 4;
            // 
            // LabelPanel
            // 
            this.LabelPanel.Controls.Add(this.BinaryLabel);
            this.LabelPanel.Controls.Add(this.Octlabel);
            this.LabelPanel.Controls.Add(this.DecLabel);
            this.LabelPanel.Controls.Add(this.HexLabel);
            this.LabelPanel.Location = new System.Drawing.Point(126, 8);
            this.LabelPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LabelPanel.Name = "LabelPanel";
            this.LabelPanel.Size = new System.Drawing.Size(440, 141);
            this.LabelPanel.TabIndex = 4;
            // 
            // BinaryLabel
            // 
            this.BinaryLabel.BackColor = System.Drawing.Color.Gray;
            this.BinaryLabel.Location = new System.Drawing.Point(3, 111);
            this.BinaryLabel.Name = "BinaryLabel";
            this.BinaryLabel.Size = new System.Drawing.Size(414, 23);
            this.BinaryLabel.TabIndex = 3;
            this.BinaryLabel.Text = "BinLabel";
            // 
            // Octlabel
            // 
            this.Octlabel.BackColor = System.Drawing.Color.Gray;
            this.Octlabel.Location = new System.Drawing.Point(3, 73);
            this.Octlabel.Name = "Octlabel";
            this.Octlabel.Size = new System.Drawing.Size(414, 23);
            this.Octlabel.TabIndex = 2;
            this.Octlabel.Text = "OctLabel";
            // 
            // DecLabel
            // 
            this.DecLabel.BackColor = System.Drawing.Color.Gray;
            this.DecLabel.Location = new System.Drawing.Point(3, 40);
            this.DecLabel.Name = "DecLabel";
            this.DecLabel.Size = new System.Drawing.Size(414, 23);
            this.DecLabel.TabIndex = 1;
            this.DecLabel.Text = "DecLabel";
            // 
            // HexLabel
            // 
            this.HexLabel.BackColor = System.Drawing.Color.Gray;
            this.HexLabel.Location = new System.Drawing.Point(3, 4);
            this.HexLabel.Name = "HexLabel";
            this.HexLabel.Size = new System.Drawing.Size(414, 25);
            this.HexLabel.TabIndex = 0;
            this.HexLabel.Text = "HexLabel";
            // 
            // Binradio
            // 
            this.Binradio.AutoSize = true;
            this.Binradio.BackColor = System.Drawing.Color.Gray;
            this.Binradio.Location = new System.Drawing.Point(11, 116);
            this.Binradio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Binradio.Name = "Binradio";
            this.Binradio.Size = new System.Drawing.Size(51, 24);
            this.Binradio.TabIndex = 3;
            this.Binradio.TabStop = true;
            this.Binradio.Text = "Bin";
            this.Binradio.UseVisualStyleBackColor = false;
            this.Binradio.CheckedChanged += new System.EventHandler(this.BinMode);
            // 
            // Octradio
            // 
            this.Octradio.AutoSize = true;
            this.Octradio.BackColor = System.Drawing.Color.Gray;
            this.Octradio.Location = new System.Drawing.Point(11, 79);
            this.Octradio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Octradio.Name = "Octradio";
            this.Octradio.Size = new System.Drawing.Size(53, 24);
            this.Octradio.TabIndex = 2;
            this.Octradio.TabStop = true;
            this.Octradio.Text = "Oct";
            this.Octradio.UseVisualStyleBackColor = false;
            this.Octradio.CheckedChanged += new System.EventHandler(this.OctMode);
            // 
            // Decradio
            // 
            this.Decradio.AutoSize = true;
            this.Decradio.BackColor = System.Drawing.Color.Gray;
            this.Decradio.Location = new System.Drawing.Point(11, 45);
            this.Decradio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Decradio.Name = "Decradio";
            this.Decradio.Size = new System.Drawing.Size(56, 24);
            this.Decradio.TabIndex = 1;
            this.Decradio.TabStop = true;
            this.Decradio.Text = "Dec";
            this.Decradio.UseVisualStyleBackColor = false;
            this.Decradio.CheckedChanged += new System.EventHandler(this.DecMode);
            // 
            // HexRadio
            // 
            this.HexRadio.AutoSize = true;
            this.HexRadio.BackColor = System.Drawing.Color.Gray;
            this.HexRadio.Location = new System.Drawing.Point(11, 12);
            this.HexRadio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HexRadio.Name = "HexRadio";
            this.HexRadio.Size = new System.Drawing.Size(56, 24);
            this.HexRadio.TabIndex = 0;
            this.HexRadio.TabStop = true;
            this.HexRadio.Text = "Hex";
            this.HexRadio.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bitWiseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(-1, 300);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(597, 40);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bitWiseToolStripMenuItem
            // 
            this.bitWiseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AND,
            this.OR,
            this.NOT,
            this.Nand,
            this.Nor,
            this.Xor});
            this.bitWiseToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bitWiseToolStripMenuItem.Name = "bitWiseToolStripMenuItem";
            this.bitWiseToolStripMenuItem.Size = new System.Drawing.Size(73, 34);
            this.bitWiseToolStripMenuItem.Text = "BitWise";
            // 
            // AND
            // 
            this.AND.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AND.Name = "AND";
            this.AND.Size = new System.Drawing.Size(135, 26);
            this.AND.Text = "AND";
            // 
            // OR
            // 
            this.OR.BackColor = System.Drawing.SystemColors.ControlDark;
            this.OR.Name = "OR";
            this.OR.Size = new System.Drawing.Size(135, 26);
            this.OR.Text = "OR";
            // 
            // NOT
            // 
            this.NOT.BackColor = System.Drawing.SystemColors.ControlDark;
            this.NOT.Name = "NOT";
            this.NOT.Size = new System.Drawing.Size(135, 26);
            this.NOT.Text = "NOT";
            // 
            // Nand
            // 
            this.Nand.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Nand.Name = "Nand";
            this.Nand.Size = new System.Drawing.Size(135, 26);
            this.Nand.Text = "NAND";
            // 
            // Nor
            // 
            this.Nor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Nor.Name = "Nor";
            this.Nor.Size = new System.Drawing.Size(135, 26);
            this.Nor.Text = "NOR";
            // 
            // Xor
            // 
            this.Xor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Xor.Name = "Xor";
            this.Xor.Size = new System.Drawing.Size(135, 26);
            this.Xor.Text = "XOR";
            // 
            // AButton
            // 
            this.AButton.BackColor = System.Drawing.Color.DarkCyan;
            this.AButton.Location = new System.Drawing.Point(9, 344);
            this.AButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AButton.Name = "AButton";
            this.AButton.Size = new System.Drawing.Size(109, 59);
            this.AButton.TabIndex = 6;
            this.AButton.Text = "A";
            this.AButton.UseVisualStyleBackColor = false;
            this.AButton.EnabledChanged += new System.EventHandler(this.EnableChange);
            this.AButton.Click += new System.EventHandler(this.HexChar_Clicked);
            // 
            // BButton
            // 
            this.BButton.BackColor = System.Drawing.Color.DarkCyan;
            this.BButton.Location = new System.Drawing.Point(9, 409);
            this.BButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BButton.Name = "BButton";
            this.BButton.Size = new System.Drawing.Size(109, 57);
            this.BButton.TabIndex = 7;
            this.BButton.Text = "B";
            this.BButton.UseVisualStyleBackColor = false;
            this.BButton.EnabledChanged += new System.EventHandler(this.EnableChange);
            this.BButton.Click += new System.EventHandler(this.HexChar_Clicked);
            // 
            // CButton
            // 
            this.CButton.BackColor = System.Drawing.Color.DarkCyan;
            this.CButton.Location = new System.Drawing.Point(9, 475);
            this.CButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(109, 57);
            this.CButton.TabIndex = 8;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = false;
            this.CButton.EnabledChanged += new System.EventHandler(this.EnableChange);
            this.CButton.Click += new System.EventHandler(this.HexChar_Clicked);
            // 
            // DButton
            // 
            this.DButton.BackColor = System.Drawing.Color.DarkCyan;
            this.DButton.Location = new System.Drawing.Point(9, 540);
            this.DButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DButton.Name = "DButton";
            this.DButton.Size = new System.Drawing.Size(109, 57);
            this.DButton.TabIndex = 9;
            this.DButton.Text = "D";
            this.DButton.UseVisualStyleBackColor = false;
            this.DButton.EnabledChanged += new System.EventHandler(this.EnableChange);
            this.DButton.Click += new System.EventHandler(this.HexChar_Clicked);
            // 
            // EButton
            // 
            this.EButton.BackColor = System.Drawing.Color.DarkCyan;
            this.EButton.Location = new System.Drawing.Point(9, 605);
            this.EButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EButton.Name = "EButton";
            this.EButton.Size = new System.Drawing.Size(109, 57);
            this.EButton.TabIndex = 10;
            this.EButton.Text = "E";
            this.EButton.UseVisualStyleBackColor = false;
            this.EButton.EnabledChanged += new System.EventHandler(this.EnableChange);
            this.EButton.Click += new System.EventHandler(this.HexChar_Clicked);
            // 
            // FButton
            // 
            this.FButton.BackColor = System.Drawing.Color.DarkCyan;
            this.FButton.Location = new System.Drawing.Point(9, 669);
            this.FButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FButton.Name = "FButton";
            this.FButton.Size = new System.Drawing.Size(109, 57);
            this.FButton.TabIndex = 11;
            this.FButton.Text = "F";
            this.FButton.UseVisualStyleBackColor = false;
            this.FButton.EnabledChanged += new System.EventHandler(this.EnableChange);
            this.FButton.Click += new System.EventHandler(this.HexChar_Clicked);
            // 
            // PlusMinusButton
            // 
            this.PlusMinusButton.BackColor = System.Drawing.Color.DarkCyan;
            this.PlusMinusButton.Location = new System.Drawing.Point(125, 669);
            this.PlusMinusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PlusMinusButton.Name = "PlusMinusButton";
            this.PlusMinusButton.Size = new System.Drawing.Size(109, 57);
            this.PlusMinusButton.TabIndex = 12;
            this.PlusMinusButton.Text = "+/-";
            this.PlusMinusButton.UseVisualStyleBackColor = false;
            this.PlusMinusButton.EnabledChanged += new System.EventHandler(this.EnableChange);
            // 
            // OneButton
            // 
            this.OneButton.BackColor = System.Drawing.Color.DarkCyan;
            this.OneButton.Location = new System.Drawing.Point(125, 604);
            this.OneButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(109, 57);
            this.OneButton.TabIndex = 13;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            this.OneButton.EnabledChanged += new System.EventHandler(this.EnableChange);
            this.OneButton.Click += new System.EventHandler(this.Digit_Clicked);
            // 
            // FourButton
            // 
            this.FourButton.BackColor = System.Drawing.Color.DarkCyan;
            this.FourButton.Location = new System.Drawing.Point(125, 540);
            this.FourButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(109, 57);
            this.FourButton.TabIndex = 14;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            this.FourButton.EnabledChanged += new System.EventHandler(this.EnableChange);
            this.FourButton.Click += new System.EventHandler(this.Digit_Clicked);
            // 
            // SevenButton
            // 
            this.SevenButton.BackColor = System.Drawing.Color.DarkCyan;
            this.SevenButton.Location = new System.Drawing.Point(125, 475);
            this.SevenButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(109, 57);
            this.SevenButton.TabIndex = 15;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.EnabledChanged += new System.EventHandler(this.EnableChange);
            this.SevenButton.Click += new System.EventHandler(this.Digit_Clicked);
            // 
            // EightButton
            // 
            this.EightButton.BackColor = System.Drawing.Color.DarkCyan;
            this.EightButton.Location = new System.Drawing.Point(240, 475);
            this.EightButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(109, 57);
            this.EightButton.TabIndex = 16;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.EnabledChanged += new System.EventHandler(this.EnableChange);
            this.EightButton.Click += new System.EventHandler(this.Digit_Clicked);
            // 
            // FiveButton
            // 
            this.FiveButton.BackColor = System.Drawing.Color.DarkCyan;
            this.FiveButton.Location = new System.Drawing.Point(240, 540);
            this.FiveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(109, 57);
            this.FiveButton.TabIndex = 17;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            this.FiveButton.EnabledChanged += new System.EventHandler(this.EnableChange);
            this.FiveButton.Click += new System.EventHandler(this.Digit_Clicked);
            // 
            // TwoButton
            // 
            this.TwoButton.BackColor = System.Drawing.Color.DarkCyan;
            this.TwoButton.Location = new System.Drawing.Point(240, 605);
            this.TwoButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(109, 57);
            this.TwoButton.TabIndex = 18;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            this.TwoButton.EnabledChanged += new System.EventHandler(this.EnableChange);
            this.TwoButton.Click += new System.EventHandler(this.Digit_Clicked);
            // 
            // NineButton
            // 
            this.NineButton.BackColor = System.Drawing.Color.DarkCyan;
            this.NineButton.Location = new System.Drawing.Point(355, 475);
            this.NineButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(109, 57);
            this.NineButton.TabIndex = 19;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            this.NineButton.EnabledChanged += new System.EventHandler(this.EnableChange);
            this.NineButton.Click += new System.EventHandler(this.Digit_Clicked);
            // 
            // SixButton
            // 
            this.SixButton.BackColor = System.Drawing.Color.DarkCyan;
            this.SixButton.Location = new System.Drawing.Point(355, 540);
            this.SixButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(109, 57);
            this.SixButton.TabIndex = 20;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            this.SixButton.EnabledChanged += new System.EventHandler(this.EnableChange);
            this.SixButton.Click += new System.EventHandler(this.Digit_Clicked);
            // 
            // ThreeButton
            // 
            this.ThreeButton.BackColor = System.Drawing.Color.DarkCyan;
            this.ThreeButton.Location = new System.Drawing.Point(355, 605);
            this.ThreeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(109, 57);
            this.ThreeButton.TabIndex = 21;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            this.ThreeButton.EnabledChanged += new System.EventHandler(this.EnableChange);
            this.ThreeButton.Click += new System.EventHandler(this.Digit_Clicked);
            // 
            // ZeroButton
            // 
            this.ZeroButton.BackColor = System.Drawing.Color.DarkCyan;
            this.ZeroButton.Location = new System.Drawing.Point(240, 671);
            this.ZeroButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(109, 57);
            this.ZeroButton.TabIndex = 22;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.EnabledChanged += new System.EventHandler(this.EnableChange);
            this.ZeroButton.Click += new System.EventHandler(this.Digit_Clicked);
            // 
            // DotButton
            // 
            this.DotButton.BackColor = System.Drawing.Color.Gray;
            this.DotButton.Enabled = false;
            this.DotButton.Location = new System.Drawing.Point(355, 671);
            this.DotButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(109, 57);
            this.DotButton.TabIndex = 23;
            this.DotButton.Text = ".";
            this.DotButton.UseVisualStyleBackColor = false;
            this.DotButton.EnabledChanged += new System.EventHandler(this.EnableChange);
            // 
            // EqualButton
            // 
            this.EqualButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.EqualButton.Location = new System.Drawing.Point(471, 669);
            this.EqualButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(109, 57);
            this.EqualButton.TabIndex = 24;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = false;
            this.EqualButton.EnabledChanged += new System.EventHandler(this.EnableChange);
            this.EqualButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.BackColor = System.Drawing.Color.DarkCyan;
            this.PlusButton.Location = new System.Drawing.Point(471, 604);
            this.PlusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(109, 57);
            this.PlusButton.TabIndex = 25;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = false;
            this.PlusButton.EnabledChanged += new System.EventHandler(this.EnableChange);
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.BackColor = System.Drawing.Color.DarkCyan;
            this.MinusButton.Location = new System.Drawing.Point(471, 540);
            this.MinusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(109, 57);
            this.MinusButton.TabIndex = 26;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = false;
            this.MinusButton.EnabledChanged += new System.EventHandler(this.EnableChange);
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.BackColor = System.Drawing.Color.DarkCyan;
            this.MultiplyButton.Location = new System.Drawing.Point(471, 475);
            this.MultiplyButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(109, 57);
            this.MultiplyButton.TabIndex = 27;
            this.MultiplyButton.Text = "x";
            this.MultiplyButton.UseVisualStyleBackColor = false;
            this.MultiplyButton.EnabledChanged += new System.EventHandler(this.EnableChange);
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.BackColor = System.Drawing.Color.DarkCyan;
            this.DivideButton.Location = new System.Drawing.Point(471, 409);
            this.DivideButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(109, 57);
            this.DivideButton.TabIndex = 28;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = false;
            this.DivideButton.EnabledChanged += new System.EventHandler(this.EnableChange);
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // ModuloButton
            // 
            this.ModuloButton.BackColor = System.Drawing.Color.DarkCyan;
            this.ModuloButton.Location = new System.Drawing.Point(355, 409);
            this.ModuloButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ModuloButton.Name = "ModuloButton";
            this.ModuloButton.Size = new System.Drawing.Size(109, 57);
            this.ModuloButton.TabIndex = 29;
            this.ModuloButton.Text = "%";
            this.ModuloButton.UseVisualStyleBackColor = false;
            this.ModuloButton.EnabledChanged += new System.EventHandler(this.EnableChange);
            this.ModuloButton.Click += new System.EventHandler(this.ModuloButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.DarkCyan;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.Location = new System.Drawing.Point(471, 345);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(109, 57);
            this.DeleteButton.TabIndex = 30;
            this.DeleteButton.Text = "<x";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.EnabledChanged += new System.EventHandler(this.EnableChange);
            this.DeleteButton.Click += new System.EventHandler(this.Backspace);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.DarkCyan;
            this.ResetButton.Location = new System.Drawing.Point(355, 345);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(109, 57);
            this.ResetButton.TabIndex = 31;
            this.ResetButton.Text = "C";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.EnabledChanged += new System.EventHandler(this.EnableChange);
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // CurlyOpen
            // 
            this.CurlyOpen.BackColor = System.Drawing.Color.DarkCyan;
            this.CurlyOpen.Location = new System.Drawing.Point(125, 409);
            this.CurlyOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CurlyOpen.Name = "CurlyOpen";
            this.CurlyOpen.Size = new System.Drawing.Size(109, 57);
            this.CurlyOpen.TabIndex = 32;
            this.CurlyOpen.Text = "(";
            this.CurlyOpen.UseVisualStyleBackColor = false;
            this.CurlyOpen.EnabledChanged += new System.EventHandler(this.EnableChange);
            // 
            // CurlyClose
            // 
            this.CurlyClose.BackColor = System.Drawing.Color.DarkCyan;
            this.CurlyClose.Location = new System.Drawing.Point(240, 409);
            this.CurlyClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CurlyClose.Name = "CurlyClose";
            this.CurlyClose.Size = new System.Drawing.Size(109, 57);
            this.CurlyClose.TabIndex = 33;
            this.CurlyClose.Text = ")";
            this.CurlyClose.UseVisualStyleBackColor = false;
            this.CurlyClose.EnabledChanged += new System.EventHandler(this.EnableChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(859, 740);
            this.Controls.Add(this.CurlyClose);
            this.Controls.Add(this.CurlyOpen);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ModuloButton);
            this.Controls.Add(this.DivideButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.EqualButton);
            this.Controls.Add(this.DotButton);
            this.Controls.Add(this.ZeroButton);
            this.Controls.Add(this.ThreeButton);
            this.Controls.Add(this.SixButton);
            this.Controls.Add(this.NineButton);
            this.Controls.Add(this.TwoButton);
            this.Controls.Add(this.FiveButton);
            this.Controls.Add(this.EightButton);
            this.Controls.Add(this.SevenButton);
            this.Controls.Add(this.FourButton);
            this.Controls.Add(this.OneButton);
            this.Controls.Add(this.PlusMinusButton);
            this.Controls.Add(this.FButton);
            this.Controls.Add(this.EButton);
            this.Controls.Add(this.DButton);
            this.Controls.Add(this.CButton);
            this.Controls.Add(this.BButton);
            this.Controls.Add(this.AButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SecondaryEqBox);
            this.Controls.Add(this.MainEqBox);
            this.Controls.Add(this.MemoryBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.LabelPanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

            }

        #endregion
        private GroupBox MemoryBox;
        private Label MainEqBox;
        private Label SecondaryEqBox;
        private Panel panel1;
        private Panel LabelPanel;
        private Label BinaryLabel;
        private Label Octlabel;
        private Label DecLabel;
        private Label HexLabel;
        private RadioButton Binradio;
        private RadioButton Octradio;
        private RadioButton Decradio;
        private RadioButton HexRadio;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem bitWiseToolStripMenuItem;
        private ToolStripMenuItem AND;
        private ToolStripMenuItem OR;
        private ToolStripMenuItem NOT;
        private ToolStripMenuItem Nand;
        private ToolStripMenuItem Nor;
        private ToolStripMenuItem Xor;
        private Button AButton;
        private Button BButton;
        private Button CButton;
        private Button DButton;
        private Button EButton;
        private Button FButton;
        private Button PlusMinusButton;
        private Button OneButton;
        private Button FourButton;
        private Button SevenButton;
        private Button EightButton;
        private Button FiveButton;
        private Button TwoButton;
        private Button NineButton;
        private Button SixButton;
        private Button ThreeButton;
        private Button ZeroButton;
        private Button DotButton;
        private Button EqualButton;
        private Button PlusButton;
        private Button MinusButton;
        private Button MultiplyButton;
        private Button DivideButton;
        private Button ModuloButton;
        private Button DeleteButton;
        private Button ResetButton;
        private Button CurlyOpen;
        private Button CurlyClose;
    }
}