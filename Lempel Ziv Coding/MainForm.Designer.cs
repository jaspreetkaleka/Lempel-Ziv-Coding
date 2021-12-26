namespace LempelZivCoding
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.decodeButton = new System.Windows.Forms.Button();
            this.encodeButton = new System.Windows.Forms.Button();
            this.b2EcTextBox = new System.Windows.Forms.RichTextBox();
            this.binarySequenceTextBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textMessageTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.b16EcTextBox = new System.Windows.Forms.RichTextBox();
            this.b8EcTextBox = new System.Windows.Forms.RichTextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.panel1 = new System.Windows.Forms.Panel();
            this.R16Label = new System.Windows.Forms.Label();
            this.R8Label = new System.Windows.Forms.Label();
            this.R2Label = new System.Windows.Forms.Label();
            this.ET16Label = new System.Windows.Forms.Label();
            this.ET8Label = new System.Windows.Forms.Label();
            this.ET2Label = new System.Windows.Forms.Label();
            this.EL16Label = new System.Windows.Forms.Label();
            this.EL8Label = new System.Windows.Forms.Label();
            this.EL2Label = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape7 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape4 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CB8Button = new System.Windows.Forms.Button();
            this.CB16Button = new System.Windows.Forms.Button();
            this.CB2Button = new System.Windows.Forms.Button();
            this.DT16Label = new System.Windows.Forms.Label();
            this.DT8Label = new System.Windows.Forms.Label();
            this.DT2Label = new System.Windows.Forms.Label();
            this.DL16Label = new System.Windows.Forms.Label();
            this.DL8Label = new System.Windows.Forms.Label();
            this.DL2Label = new System.Windows.Forms.Label();
            this.b2DcTextBox = new System.Windows.Forms.RichTextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.b8DcTextBox = new System.Windows.Forms.RichTextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.b16DcTextBox = new System.Windows.Forms.RichTextBox();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape8 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape6 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape5 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.decodedTextMessageTextBox = new System.Windows.Forms.RichTextBox();
            this.ELbinarySeqLabel = new System.Windows.Forms.Label();
            this.LtextMsgLabel = new System.Windows.Forms.Label();
            this.LdecodedTextMsgLabel = new System.Windows.Forms.Label();
            this.updateConcurrentlyCheckBox = new System.Windows.Forms.CheckBox();
            this.rectangleShape9 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape11 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape10 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label1 = new System.Windows.Forms.Label();
            this.b2_EC_LinkLabel = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // decodeButton
            // 
            this.decodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decodeButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.decodeButton.Location = new System.Drawing.Point(857, 37);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(131, 55);
            this.decodeButton.TabIndex = 3;
            this.decodeButton.Text = "Decode";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
            // 
            // encodeButton
            // 
            this.encodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encodeButton.ForeColor = System.Drawing.Color.Crimson;
            this.encodeButton.Location = new System.Drawing.Point(720, 37);
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.Size = new System.Drawing.Size(131, 55);
            this.encodeButton.TabIndex = 2;
            this.encodeButton.Text = "Encode";
            this.encodeButton.UseVisualStyleBackColor = true;
            this.encodeButton.Click += new System.EventHandler(this.encodeButton_Click);
            // 
            // b2EcTextBox
            // 
            this.b2EcTextBox.BackColor = System.Drawing.Color.White;
            this.b2EcTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.b2EcTextBox.DetectUrls = false;
            this.b2EcTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2EcTextBox.ForeColor = System.Drawing.Color.Crimson;
            this.b2EcTextBox.Location = new System.Drawing.Point(179, 6);
            this.b2EcTextBox.Multiline = false;
            this.b2EcTextBox.Name = "b2EcTextBox";
            this.b2EcTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.b2EcTextBox.Size = new System.Drawing.Size(495, 33);
            this.b2EcTextBox.TabIndex = 0;
            this.b2EcTextBox.Text = "";
            this.b2EcTextBox.TextChanged += new System.EventHandler(this.b2EcTextBox_TextChanged);
            // 
            // binarySequenceTextBox
            // 
            this.binarySequenceTextBox.BackColor = System.Drawing.Color.White;
            this.binarySequenceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.binarySequenceTextBox.DetectUrls = false;
            this.binarySequenceTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binarySequenceTextBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.binarySequenceTextBox.Location = new System.Drawing.Point(181, 140);
            this.binarySequenceTextBox.Multiline = false;
            this.binarySequenceTextBox.Name = "binarySequenceTextBox";
            this.binarySequenceTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.binarySequenceTextBox.Size = new System.Drawing.Size(495, 33);
            this.binarySequenceTextBox.TabIndex = 1;
            this.binarySequenceTextBox.Text = "";
            this.binarySequenceTextBox.TextChanged += new System.EventHandler(this.binarySequenceTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(12, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Base 2 - Encoding :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(14, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Binary Sequence : ";
            // 
            // textMessageTextBox
            // 
            this.textMessageTextBox.BackColor = System.Drawing.Color.White;
            this.textMessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMessageTextBox.DetectUrls = false;
            this.textMessageTextBox.Font = new System.Drawing.Font("Comic Sans MS", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMessageTextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.textMessageTextBox.Location = new System.Drawing.Point(181, 12);
            this.textMessageTextBox.Name = "textMessageTextBox";
            this.textMessageTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.textMessageTextBox.Size = new System.Drawing.Size(495, 122);
            this.textMessageTextBox.TabIndex = 0;
            this.textMessageTextBox.Text = "";
            this.textMessageTextBox.TextChanged += new System.EventHandler(this.textMessageTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(14, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Text Message : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Base 8 - Encoding :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Crimson;
            this.label11.Location = new System.Drawing.Point(12, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 23);
            this.label11.TabIndex = 31;
            this.label11.Text = "Base 16 - Encoding :";
            // 
            // b16EcTextBox
            // 
            this.b16EcTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.b16EcTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b16EcTextBox.ForeColor = System.Drawing.Color.Crimson;
            this.b16EcTextBox.Location = new System.Drawing.Point(179, 88);
            this.b16EcTextBox.Multiline = false;
            this.b16EcTextBox.Name = "b16EcTextBox";
            this.b16EcTextBox.Size = new System.Drawing.Size(495, 33);
            this.b16EcTextBox.TabIndex = 2;
            this.b16EcTextBox.Text = "";
            this.b16EcTextBox.TextChanged += new System.EventHandler(this.b16EcTextBox_TextChanged);
            // 
            // b8EcTextBox
            // 
            this.b8EcTextBox.BackColor = System.Drawing.Color.White;
            this.b8EcTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.b8EcTextBox.DetectUrls = false;
            this.b8EcTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8EcTextBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.b8EcTextBox.Location = new System.Drawing.Point(179, 47);
            this.b8EcTextBox.Multiline = false;
            this.b8EcTextBox.Name = "b8EcTextBox";
            this.b8EcTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.b8EcTextBox.Size = new System.Drawing.Size(495, 33);
            this.b8EcTextBox.TabIndex = 1;
            this.b8EcTextBox.Text = "";
            this.b8EcTextBox.TextChanged += new System.EventHandler(this.b8EcTextBox_TextChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.Color.DarkGreen;
            this.label28.Location = new System.Drawing.Point(14, 486);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(153, 23);
            this.label28.TabIndex = 37;
            this.label28.Text = "Decoded Message : ";
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.MidnightBlue;
            this.rectangleShape1.BorderWidth = 2;
            this.rectangleShape1.CornerRadius = 10;
            this.rectangleShape1.Location = new System.Drawing.Point(9, 6);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(161, 116);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.b2_EC_LinkLabel);
            this.panel1.Controls.Add(this.R16Label);
            this.panel1.Controls.Add(this.R8Label);
            this.panel1.Controls.Add(this.R2Label);
            this.panel1.Controls.Add(this.ET16Label);
            this.panel1.Controls.Add(this.ET8Label);
            this.panel1.Controls.Add(this.ET2Label);
            this.panel1.Controls.Add(this.EL16Label);
            this.panel1.Controls.Add(this.EL8Label);
            this.panel1.Controls.Add(this.EL2Label);
            this.panel1.Controls.Add(this.b2EcTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.b8EcTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.b16EcTextBox);
            this.panel1.Controls.Add(this.shapeContainer2);
            this.panel1.Location = new System.Drawing.Point(2, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 128);
            this.panel1.TabIndex = 38;
            // 
            // R16Label
            // 
            this.R16Label.AutoSize = true;
            this.R16Label.BackColor = System.Drawing.Color.Transparent;
            this.R16Label.ForeColor = System.Drawing.Color.Crimson;
            this.R16Label.Location = new System.Drawing.Point(924, 94);
            this.R16Label.Name = "R16Label";
            this.R16Label.Size = new System.Drawing.Size(38, 23);
            this.R16Label.TabIndex = 50;
            this.R16Label.Text = "0 %";
            // 
            // R8Label
            // 
            this.R8Label.AutoSize = true;
            this.R8Label.BackColor = System.Drawing.Color.Transparent;
            this.R8Label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.R8Label.Location = new System.Drawing.Point(924, 53);
            this.R8Label.Name = "R8Label";
            this.R8Label.Size = new System.Drawing.Size(38, 23);
            this.R8Label.TabIndex = 48;
            this.R8Label.Text = "0 %";
            // 
            // R2Label
            // 
            this.R2Label.AutoSize = true;
            this.R2Label.BackColor = System.Drawing.Color.Transparent;
            this.R2Label.ForeColor = System.Drawing.Color.Crimson;
            this.R2Label.Location = new System.Drawing.Point(924, 12);
            this.R2Label.Name = "R2Label";
            this.R2Label.Size = new System.Drawing.Size(38, 23);
            this.R2Label.TabIndex = 49;
            this.R2Label.Text = "0 %";
            // 
            // ET16Label
            // 
            this.ET16Label.AutoSize = true;
            this.ET16Label.BackColor = System.Drawing.Color.Transparent;
            this.ET16Label.ForeColor = System.Drawing.Color.Crimson;
            this.ET16Label.Location = new System.Drawing.Point(809, 94);
            this.ET16Label.Name = "ET16Label";
            this.ET16Label.Size = new System.Drawing.Size(43, 23);
            this.ET16Label.TabIndex = 47;
            this.ET16Label.Text = "0 ms";
            // 
            // ET8Label
            // 
            this.ET8Label.AutoSize = true;
            this.ET8Label.BackColor = System.Drawing.Color.Transparent;
            this.ET8Label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ET8Label.Location = new System.Drawing.Point(809, 53);
            this.ET8Label.Name = "ET8Label";
            this.ET8Label.Size = new System.Drawing.Size(43, 23);
            this.ET8Label.TabIndex = 45;
            this.ET8Label.Text = "0 ms";
            // 
            // ET2Label
            // 
            this.ET2Label.AutoSize = true;
            this.ET2Label.BackColor = System.Drawing.Color.Transparent;
            this.ET2Label.ForeColor = System.Drawing.Color.Crimson;
            this.ET2Label.Location = new System.Drawing.Point(809, 12);
            this.ET2Label.Name = "ET2Label";
            this.ET2Label.Size = new System.Drawing.Size(43, 23);
            this.ET2Label.TabIndex = 46;
            this.ET2Label.Text = "0 ms";
            // 
            // EL16Label
            // 
            this.EL16Label.AutoSize = true;
            this.EL16Label.BackColor = System.Drawing.Color.Transparent;
            this.EL16Label.ForeColor = System.Drawing.Color.Crimson;
            this.EL16Label.Location = new System.Drawing.Point(690, 93);
            this.EL16Label.Name = "EL16Label";
            this.EL16Label.Size = new System.Drawing.Size(20, 23);
            this.EL16Label.TabIndex = 44;
            this.EL16Label.Text = "0";
            // 
            // EL8Label
            // 
            this.EL8Label.AutoSize = true;
            this.EL8Label.BackColor = System.Drawing.Color.Transparent;
            this.EL8Label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.EL8Label.Location = new System.Drawing.Point(690, 52);
            this.EL8Label.Name = "EL8Label";
            this.EL8Label.Size = new System.Drawing.Size(20, 23);
            this.EL8Label.TabIndex = 42;
            this.EL8Label.Text = "0";
            // 
            // EL2Label
            // 
            this.EL2Label.AutoSize = true;
            this.EL2Label.BackColor = System.Drawing.Color.Transparent;
            this.EL2Label.ForeColor = System.Drawing.Color.Crimson;
            this.EL2Label.Location = new System.Drawing.Point(690, 11);
            this.EL2Label.Name = "EL2Label";
            this.EL2Label.Size = new System.Drawing.Size(20, 23);
            this.EL2Label.TabIndex = 43;
            this.EL2Label.Text = "0";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape7,
            this.rectangleShape3,
            this.rectangleShape4,
            this.rectangleShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(1020, 128);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // rectangleShape7
            // 
            this.rectangleShape7.BorderColor = System.Drawing.Color.MidnightBlue;
            this.rectangleShape7.BorderWidth = 2;
            this.rectangleShape7.CornerRadius = 10;
            this.rectangleShape7.Location = new System.Drawing.Point(910, 6);
            this.rectangleShape7.Name = "rectangleShape7";
            this.rectangleShape7.Size = new System.Drawing.Size(100, 116);
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.BorderColor = System.Drawing.Color.MidnightBlue;
            this.rectangleShape3.BorderWidth = 2;
            this.rectangleShape3.CornerRadius = 10;
            this.rectangleShape3.Location = new System.Drawing.Point(801, 6);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(100, 116);
            // 
            // rectangleShape4
            // 
            this.rectangleShape4.BorderColor = System.Drawing.Color.MidnightBlue;
            this.rectangleShape4.BorderWidth = 2;
            this.rectangleShape4.CornerRadius = 10;
            this.rectangleShape4.Location = new System.Drawing.Point(679, 6);
            this.rectangleShape4.Name = "rectangleShape4";
            this.rectangleShape4.Size = new System.Drawing.Size(114, 116);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CB8Button);
            this.panel2.Controls.Add(this.CB16Button);
            this.panel2.Controls.Add(this.CB2Button);
            this.panel2.Controls.Add(this.DT16Label);
            this.panel2.Controls.Add(this.DT8Label);
            this.panel2.Controls.Add(this.DT2Label);
            this.panel2.Controls.Add(this.DL16Label);
            this.panel2.Controls.Add(this.DL8Label);
            this.panel2.Controls.Add(this.DL2Label);
            this.panel2.Controls.Add(this.b2DcTextBox);
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.b8DcTextBox);
            this.panel2.Controls.Add(this.label30);
            this.panel2.Controls.Add(this.label31);
            this.panel2.Controls.Add(this.b16DcTextBox);
            this.panel2.Controls.Add(this.shapeContainer3);
            this.panel2.Location = new System.Drawing.Point(2, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 128);
            this.panel2.TabIndex = 39;
            // 
            // CB8Button
            // 
            this.CB8Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB8Button.ForeColor = System.Drawing.Color.DarkGreen;
            this.CB8Button.Location = new System.Drawing.Point(923, 51);
            this.CB8Button.Name = "CB8Button";
            this.CB8Button.Size = new System.Drawing.Size(74, 28);
            this.CB8Button.TabIndex = 48;
            this.CB8Button.Text = "CB - 8";
            this.CB8Button.UseVisualStyleBackColor = true;
            this.CB8Button.Click += new System.EventHandler(this.CB8Button_Click);
            // 
            // CB16Button
            // 
            this.CB16Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB16Button.ForeColor = System.Drawing.Color.DarkGreen;
            this.CB16Button.Location = new System.Drawing.Point(923, 85);
            this.CB16Button.Name = "CB16Button";
            this.CB16Button.Size = new System.Drawing.Size(74, 28);
            this.CB16Button.TabIndex = 51;
            this.CB16Button.Text = "CB - 16";
            this.CB16Button.UseVisualStyleBackColor = true;
            this.CB16Button.Click += new System.EventHandler(this.CB16Button_Click);
            // 
            // CB2Button
            // 
            this.CB2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB2Button.ForeColor = System.Drawing.Color.DarkGreen;
            this.CB2Button.Location = new System.Drawing.Point(923, 17);
            this.CB2Button.Name = "CB2Button";
            this.CB2Button.Size = new System.Drawing.Size(74, 28);
            this.CB2Button.TabIndex = 47;
            this.CB2Button.Text = "CB - 2";
            this.CB2Button.UseVisualStyleBackColor = true;
            this.CB2Button.Click += new System.EventHandler(this.CB2Button_Click);
            // 
            // DT16Label
            // 
            this.DT16Label.AutoSize = true;
            this.DT16Label.BackColor = System.Drawing.Color.Transparent;
            this.DT16Label.ForeColor = System.Drawing.Color.Crimson;
            this.DT16Label.Location = new System.Drawing.Point(809, 93);
            this.DT16Label.Name = "DT16Label";
            this.DT16Label.Size = new System.Drawing.Size(43, 23);
            this.DT16Label.TabIndex = 50;
            this.DT16Label.Text = "0 ms";
            // 
            // DT8Label
            // 
            this.DT8Label.AutoSize = true;
            this.DT8Label.BackColor = System.Drawing.Color.Transparent;
            this.DT8Label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.DT8Label.Location = new System.Drawing.Point(809, 52);
            this.DT8Label.Name = "DT8Label";
            this.DT8Label.Size = new System.Drawing.Size(43, 23);
            this.DT8Label.TabIndex = 48;
            this.DT8Label.Text = "0 ms";
            // 
            // DT2Label
            // 
            this.DT2Label.AutoSize = true;
            this.DT2Label.BackColor = System.Drawing.Color.Transparent;
            this.DT2Label.ForeColor = System.Drawing.Color.Crimson;
            this.DT2Label.Location = new System.Drawing.Point(809, 11);
            this.DT2Label.Name = "DT2Label";
            this.DT2Label.Size = new System.Drawing.Size(43, 23);
            this.DT2Label.TabIndex = 49;
            this.DT2Label.Text = "0 ms";
            // 
            // DL16Label
            // 
            this.DL16Label.AutoSize = true;
            this.DL16Label.BackColor = System.Drawing.Color.Transparent;
            this.DL16Label.ForeColor = System.Drawing.Color.Crimson;
            this.DL16Label.Location = new System.Drawing.Point(690, 93);
            this.DL16Label.Name = "DL16Label";
            this.DL16Label.Size = new System.Drawing.Size(20, 23);
            this.DL16Label.TabIndex = 47;
            this.DL16Label.Text = "0";
            // 
            // DL8Label
            // 
            this.DL8Label.AutoSize = true;
            this.DL8Label.BackColor = System.Drawing.Color.Transparent;
            this.DL8Label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.DL8Label.Location = new System.Drawing.Point(690, 52);
            this.DL8Label.Name = "DL8Label";
            this.DL8Label.Size = new System.Drawing.Size(20, 23);
            this.DL8Label.TabIndex = 45;
            this.DL8Label.Text = "0";
            // 
            // DL2Label
            // 
            this.DL2Label.AutoSize = true;
            this.DL2Label.BackColor = System.Drawing.Color.Transparent;
            this.DL2Label.ForeColor = System.Drawing.Color.Crimson;
            this.DL2Label.Location = new System.Drawing.Point(690, 11);
            this.DL2Label.Name = "DL2Label";
            this.DL2Label.Size = new System.Drawing.Size(20, 23);
            this.DL2Label.TabIndex = 46;
            this.DL2Label.Text = "0";
            // 
            // b2DcTextBox
            // 
            this.b2DcTextBox.BackColor = System.Drawing.Color.White;
            this.b2DcTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.b2DcTextBox.DetectUrls = false;
            this.b2DcTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2DcTextBox.ForeColor = System.Drawing.Color.Crimson;
            this.b2DcTextBox.Location = new System.Drawing.Point(179, 6);
            this.b2DcTextBox.Multiline = false;
            this.b2DcTextBox.Name = "b2DcTextBox";
            this.b2DcTextBox.ReadOnly = true;
            this.b2DcTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.b2DcTextBox.Size = new System.Drawing.Size(495, 33);
            this.b2DcTextBox.TabIndex = 0;
            this.b2DcTextBox.Text = "";
            this.b2DcTextBox.TextChanged += new System.EventHandler(this.b2DcTextBox_TextChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.Color.Crimson;
            this.label29.Location = new System.Drawing.Point(12, 11);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(151, 23);
            this.label29.TabIndex = 8;
            this.label29.Text = "Base 2 - Decoding :";
            // 
            // b8DcTextBox
            // 
            this.b8DcTextBox.BackColor = System.Drawing.Color.White;
            this.b8DcTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.b8DcTextBox.DetectUrls = false;
            this.b8DcTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8DcTextBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.b8DcTextBox.Location = new System.Drawing.Point(179, 47);
            this.b8DcTextBox.Multiline = false;
            this.b8DcTextBox.Name = "b8DcTextBox";
            this.b8DcTextBox.ReadOnly = true;
            this.b8DcTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.b8DcTextBox.Size = new System.Drawing.Size(495, 33);
            this.b8DcTextBox.TabIndex = 1;
            this.b8DcTextBox.Text = "";
            this.b8DcTextBox.TextChanged += new System.EventHandler(this.b8DcTextBox_TextChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label30.Location = new System.Drawing.Point(12, 52);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(151, 23);
            this.label30.TabIndex = 27;
            this.label30.Text = "Base 8 - Decoding :";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.ForeColor = System.Drawing.Color.Crimson;
            this.label31.Location = new System.Drawing.Point(12, 93);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(158, 23);
            this.label31.TabIndex = 31;
            this.label31.Text = "Base 16 - Decoding :";
            // 
            // b16DcTextBox
            // 
            this.b16DcTextBox.BackColor = System.Drawing.Color.White;
            this.b16DcTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.b16DcTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b16DcTextBox.ForeColor = System.Drawing.Color.Crimson;
            this.b16DcTextBox.Location = new System.Drawing.Point(179, 88);
            this.b16DcTextBox.Multiline = false;
            this.b16DcTextBox.Name = "b16DcTextBox";
            this.b16DcTextBox.ReadOnly = true;
            this.b16DcTextBox.Size = new System.Drawing.Size(495, 33);
            this.b16DcTextBox.TabIndex = 2;
            this.b16DcTextBox.Text = "";
            this.b16DcTextBox.TextChanged += new System.EventHandler(this.b16DcTextBox_TextChanged);
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape8,
            this.rectangleShape6,
            this.rectangleShape5,
            this.rectangleShape2});
            this.shapeContainer3.Size = new System.Drawing.Size(1020, 128);
            this.shapeContainer3.TabIndex = 0;
            this.shapeContainer3.TabStop = false;
            // 
            // rectangleShape8
            // 
            this.rectangleShape8.BorderColor = System.Drawing.Color.DarkGreen;
            this.rectangleShape8.BorderWidth = 2;
            this.rectangleShape8.CornerRadius = 10;
            this.rectangleShape8.Location = new System.Drawing.Point(910, 6);
            this.rectangleShape8.Name = "rectangleShape8";
            this.rectangleShape8.Size = new System.Drawing.Size(100, 116);
            // 
            // rectangleShape6
            // 
            this.rectangleShape6.BorderColor = System.Drawing.Color.MidnightBlue;
            this.rectangleShape6.BorderWidth = 2;
            this.rectangleShape6.CornerRadius = 10;
            this.rectangleShape6.Location = new System.Drawing.Point(801, 6);
            this.rectangleShape6.Name = "rectangleShape6";
            this.rectangleShape6.Size = new System.Drawing.Size(100, 116);
            // 
            // rectangleShape5
            // 
            this.rectangleShape5.BorderColor = System.Drawing.Color.MidnightBlue;
            this.rectangleShape5.BorderWidth = 2;
            this.rectangleShape5.CornerRadius = 10;
            this.rectangleShape5.Location = new System.Drawing.Point(679, 6);
            this.rectangleShape5.Name = "rectangleShape5";
            this.rectangleShape5.Size = new System.Drawing.Size(114, 116);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BorderColor = System.Drawing.Color.MidnightBlue;
            this.rectangleShape2.BorderWidth = 2;
            this.rectangleShape2.CornerRadius = 10;
            this.rectangleShape2.Location = new System.Drawing.Point(9, 6);
            this.rectangleShape2.Name = "rectangleShape1";
            this.rectangleShape2.Size = new System.Drawing.Size(162, 116);
            // 
            // decodedTextMessageTextBox
            // 
            this.decodedTextMessageTextBox.BackColor = System.Drawing.Color.White;
            this.decodedTextMessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decodedTextMessageTextBox.DetectUrls = false;
            this.decodedTextMessageTextBox.Font = new System.Drawing.Font("Comic Sans MS", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decodedTextMessageTextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.decodedTextMessageTextBox.Location = new System.Drawing.Point(181, 446);
            this.decodedTextMessageTextBox.Name = "decodedTextMessageTextBox";
            this.decodedTextMessageTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.decodedTextMessageTextBox.Size = new System.Drawing.Size(495, 122);
            this.decodedTextMessageTextBox.TabIndex = 4;
            this.decodedTextMessageTextBox.Text = "";
            this.decodedTextMessageTextBox.TextChanged += new System.EventHandler(this.decodedTextMessageTextBox_TextChanged);
            // 
            // ELbinarySeqLabel
            // 
            this.ELbinarySeqLabel.AutoSize = true;
            this.ELbinarySeqLabel.BackColor = System.Drawing.Color.Transparent;
            this.ELbinarySeqLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ELbinarySeqLabel.Location = new System.Drawing.Point(692, 145);
            this.ELbinarySeqLabel.Name = "ELbinarySeqLabel";
            this.ELbinarySeqLabel.Size = new System.Drawing.Size(20, 23);
            this.ELbinarySeqLabel.TabIndex = 43;
            this.ELbinarySeqLabel.Text = "0";
            // 
            // LtextMsgLabel
            // 
            this.LtextMsgLabel.AutoSize = true;
            this.LtextMsgLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.LtextMsgLabel.Location = new System.Drawing.Point(14, 76);
            this.LtextMsgLabel.Name = "LtextMsgLabel";
            this.LtextMsgLabel.Size = new System.Drawing.Size(20, 23);
            this.LtextMsgLabel.TabIndex = 44;
            this.LtextMsgLabel.Text = "0";
            // 
            // LdecodedTextMsgLabel
            // 
            this.LdecodedTextMsgLabel.AutoSize = true;
            this.LdecodedTextMsgLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.LdecodedTextMsgLabel.Location = new System.Drawing.Point(14, 509);
            this.LdecodedTextMsgLabel.Name = "LdecodedTextMsgLabel";
            this.LdecodedTextMsgLabel.Size = new System.Drawing.Size(20, 23);
            this.LdecodedTextMsgLabel.TabIndex = 45;
            this.LdecodedTextMsgLabel.Text = "0";
            // 
            // updateConcurrentlyCheckBox
            // 
            this.updateConcurrentlyCheckBox.AutoSize = true;
            this.updateConcurrentlyCheckBox.Checked = true;
            this.updateConcurrentlyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.updateConcurrentlyCheckBox.ForeColor = System.Drawing.Color.Crimson;
            this.updateConcurrentlyCheckBox.Location = new System.Drawing.Point(831, 143);
            this.updateConcurrentlyCheckBox.Name = "updateConcurrentlyCheckBox";
            this.updateConcurrentlyCheckBox.Size = new System.Drawing.Size(182, 27);
            this.updateConcurrentlyCheckBox.TabIndex = 46;
            this.updateConcurrentlyCheckBox.Text = "Update Concurrently";
            this.updateConcurrentlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // rectangleShape9
            // 
            this.rectangleShape9.BackColor = System.Drawing.Color.Transparent;
            this.rectangleShape9.BorderColor = System.Drawing.Color.DarkGreen;
            this.rectangleShape9.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.rectangleShape9.BorderWidth = 5;
            this.rectangleShape9.CornerRadius = 10;
            this.rectangleShape9.Location = new System.Drawing.Point(685, 450);
            this.rectangleShape9.Name = "rectangleShape9";
            this.rectangleShape9.Size = new System.Drawing.Size(329, 121);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape11,
            this.rectangleShape10,
            this.rectangleShape9});
            this.shapeContainer1.Size = new System.Drawing.Size(1027, 582);
            this.shapeContainer1.TabIndex = 47;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape11
            // 
            this.rectangleShape11.BorderColor = System.Drawing.Color.MidnightBlue;
            this.rectangleShape11.BorderWidth = 2;
            this.rectangleShape11.CornerRadius = 10;
            this.rectangleShape11.Location = new System.Drawing.Point(11, 138);
            this.rectangleShape11.Name = "rectangleShape11";
            this.rectangleShape11.Size = new System.Drawing.Size(160, 35);
            // 
            // rectangleShape10
            // 
            this.rectangleShape10.BorderColor = System.Drawing.Color.MidnightBlue;
            this.rectangleShape10.BorderWidth = 2;
            this.rectangleShape10.CornerRadius = 10;
            this.rectangleShape10.Location = new System.Drawing.Point(679, 138);
            this.rectangleShape10.Name = "rectangleShape10";
            this.rectangleShape10.Size = new System.Drawing.Size(125, 35);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(765, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 90);
            this.label1.TabIndex = 48;
            this.label1.Text = "Lempel-Ziv\r\n   LZ\'78";
            // 
            // b2_EC_LinkLabel
            // 
            this.b2_EC_LinkLabel.AutoSize = true;
            this.b2_EC_LinkLabel.Location = new System.Drawing.Point(12, 12);
            this.b2_EC_LinkLabel.Name = "b2_EC_LinkLabel";
            this.b2_EC_LinkLabel.Size = new System.Drawing.Size(149, 23);
            this.b2_EC_LinkLabel.TabIndex = 51;
            this.b2_EC_LinkLabel.TabStop = true;
            this.b2_EC_LinkLabel.Text = "Base 2 - Encoding :";
            this.b2_EC_LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.b2_EC_LinkLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1027, 582);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateConcurrentlyCheckBox);
            this.Controls.Add(this.LdecodedTextMsgLabel);
            this.Controls.Add(this.LtextMsgLabel);
            this.Controls.Add(this.ELbinarySeqLabel);
            this.Controls.Add(this.decodedTextMessageTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textMessageTextBox);
            this.Controls.Add(this.decodeButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.encodeButton);
            this.Controls.Add(this.binarySequenceTextBox);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MediumOrchid;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lempel Ziv Coding ( LZ 78 )";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox binarySequenceTextBox;
        private System.Windows.Forms.RichTextBox b2EcTextBox;
        private System.Windows.Forms.Button encodeButton;
        private System.Windows.Forms.RichTextBox textMessageTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox b16EcTextBox;
        private System.Windows.Forms.RichTextBox b8EcTextBox;
        private System.Windows.Forms.Label label28;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox b2DcTextBox;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.RichTextBox b8DcTextBox;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.RichTextBox b16DcTextBox;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.RichTextBox decodedTextMessageTextBox;
        private System.Windows.Forms.Label EL16Label;
        private System.Windows.Forms.Label EL8Label;
        private System.Windows.Forms.Label EL2Label;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape4;
        private System.Windows.Forms.Label ET16Label;
        private System.Windows.Forms.Label ET8Label;
        private System.Windows.Forms.Label ET2Label;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape6;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape5;
        private System.Windows.Forms.Label DT16Label;
        private System.Windows.Forms.Label DT8Label;
        private System.Windows.Forms.Label DT2Label;
        private System.Windows.Forms.Label DL16Label;
        private System.Windows.Forms.Label DL8Label;
        private System.Windows.Forms.Label DL2Label;
        private System.Windows.Forms.Label ELbinarySeqLabel;
        private System.Windows.Forms.Label LtextMsgLabel;
        private System.Windows.Forms.Label LdecodedTextMsgLabel;
        private System.Windows.Forms.Label R16Label;
        private System.Windows.Forms.Label R8Label;
        private System.Windows.Forms.Label R2Label;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape7;
        private System.Windows.Forms.CheckBox updateConcurrentlyCheckBox;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape8;
        private System.Windows.Forms.Button CB8Button;
        private System.Windows.Forms.Button CB16Button;
        private System.Windows.Forms.Button CB2Button;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape9;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape10;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape11;
        private System.Windows.Forms.LinkLabel b2_EC_LinkLabel;
    }
}

