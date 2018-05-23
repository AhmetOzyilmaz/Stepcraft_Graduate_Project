namespace StepcraftUi
{
    partial class UserInterface
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            this.lblX = new System.Windows.Forms.TextBox();
            this.lblY = new System.Windows.Forms.TextBox();
            this.lblZ = new System.Windows.Forms.TextBox();
            this.posY = new System.Windows.Forms.TextBox();
            this.posX = new System.Windows.Forms.TextBox();
            this.posZ = new System.Windows.Forms.TextBox();
            this.moveXP = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.moveYP = new System.Windows.Forms.Button();
            this.moveXN = new System.Windows.Forms.Button();
            this.moveYN = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.portList = new System.Windows.Forms.ComboBox();
            this.bitRate = new System.Windows.Forms.ComboBox();
            this.draw_square = new System.Windows.Forms.Button();
            this.moveZN = new System.Windows.Forms.Button();
            this.moveZP = new System.Windows.Forms.Button();
            this.square_Size = new System.Windows.Forms.TextBox();
            this.square_label = new System.Windows.Forms.TextBox();
            this.enter_command = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.run_command = new System.Windows.Forms.Button();
            this.btn_center = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.TextBox();
            this.btn_clean = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btn_draw_square = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(54, 208);
            this.lblX.Margin = new System.Windows.Forms.Padding(2);
            this.lblX.Name = "lblX";
            this.lblX.ReadOnly = true;
            this.lblX.Size = new System.Drawing.Size(28, 30);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X";
            this.lblX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblY
            // 
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(54, 239);
            this.lblY.Margin = new System.Windows.Forms.Padding(2);
            this.lblY.Name = "lblY";
            this.lblY.ReadOnly = true;
            this.lblY.Size = new System.Drawing.Size(28, 30);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "Y";
            this.lblY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblZ
            // 
            this.lblZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZ.Location = new System.Drawing.Point(54, 269);
            this.lblZ.Margin = new System.Windows.Forms.Padding(2);
            this.lblZ.Name = "lblZ";
            this.lblZ.ReadOnly = true;
            this.lblZ.Size = new System.Drawing.Size(28, 30);
            this.lblZ.TabIndex = 2;
            this.lblZ.Text = "Z";
            this.lblZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // posY
            // 
            this.posY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posY.Location = new System.Drawing.Point(86, 239);
            this.posY.Margin = new System.Windows.Forms.Padding(2);
            this.posY.Name = "posY";
            this.posY.ReadOnly = true;
            this.posY.Size = new System.Drawing.Size(83, 30);
            this.posY.TabIndex = 4;
            this.posY.Text = "0.00";
            this.posY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // posX
            // 
            this.posX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posX.Location = new System.Drawing.Point(86, 208);
            this.posX.Margin = new System.Windows.Forms.Padding(2);
            this.posX.Name = "posX";
            this.posX.ReadOnly = true;
            this.posX.Size = new System.Drawing.Size(83, 30);
            this.posX.TabIndex = 6;
            this.posX.Text = "0.00";
            this.posX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // posZ
            // 
            this.posZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posZ.Location = new System.Drawing.Point(86, 269);
            this.posZ.Margin = new System.Windows.Forms.Padding(2);
            this.posZ.Name = "posZ";
            this.posZ.ReadOnly = true;
            this.posZ.Size = new System.Drawing.Size(83, 30);
            this.posZ.TabIndex = 7;
            this.posZ.Text = "0.00";
            this.posZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // moveXP
            // 
            this.moveXP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveXP.Location = new System.Drawing.Point(31, 314);
            this.moveXP.Margin = new System.Windows.Forms.Padding(2);
            this.moveXP.Name = "moveXP";
            this.moveXP.Size = new System.Drawing.Size(66, 60);
            this.moveXP.TabIndex = 10;
            this.moveXP.Text = "+X";
            this.moveXP.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.moveXP.UseVisualStyleBackColor = true;
            this.moveXP.Click += new System.EventHandler(this.moveXP_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(283, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 606);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(736, 10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(15, 615);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "Y0                                     RULER Y                                   " +
    "                                                              Y600";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(282, 643);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(412, 20);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "0           4          8          12       16        20        24        28      " +
    "   32        36       40        44     ";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(12, 10);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 29);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = "SELECT PORT";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(12, 124);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(266, 30);
            this.btn_connect.TabIndex = 18;
            this.btn_connect.Text = "CONNECT";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(68, 540);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(125, 59);
            this.btn_home.TabIndex = 19;
            this.btn_home.Text = "HOME";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(12, 160);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(266, 30);
            this.btn_disconnect.TabIndex = 20;
            this.btn_disconnect.Text = "DISCONNECT";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // moveYP
            // 
            this.moveYP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveYP.Location = new System.Drawing.Point(101, 314);
            this.moveYP.Margin = new System.Windows.Forms.Padding(2);
            this.moveYP.Name = "moveYP";
            this.moveYP.Size = new System.Drawing.Size(66, 60);
            this.moveYP.TabIndex = 22;
            this.moveYP.Text = "+Y";
            this.moveYP.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.moveYP.UseVisualStyleBackColor = true;
            this.moveYP.Click += new System.EventHandler(this.moveYP_Click);
            // 
            // moveXN
            // 
            this.moveXN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveXN.Location = new System.Drawing.Point(31, 378);
            this.moveXN.Margin = new System.Windows.Forms.Padding(2);
            this.moveXN.Name = "moveXN";
            this.moveXN.Size = new System.Drawing.Size(66, 60);
            this.moveXN.TabIndex = 23;
            this.moveXN.Text = "-X";
            this.moveXN.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.moveXN.UseVisualStyleBackColor = true;
            this.moveXN.Click += new System.EventHandler(this.moveXN_Click);
            // 
            // moveYN
            // 
            this.moveYN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveYN.Location = new System.Drawing.Point(101, 378);
            this.moveYN.Margin = new System.Windows.Forms.Padding(2);
            this.moveYN.Name = "moveYN";
            this.moveYN.Size = new System.Drawing.Size(66, 60);
            this.moveYN.TabIndex = 24;
            this.moveYN.Text = "-Y";
            this.moveYN.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.moveYN.UseVisualStyleBackColor = true;
            this.moveYN.Click += new System.EventHandler(this.moveYN_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(840, 314);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(184, 20);
            this.textBox4.TabIndex = 25;
            this.textBox4.Text = "INFO SCREEN";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox5.Location = new System.Drawing.Point(12, 45);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(140, 33);
            this.textBox5.TabIndex = 26;
            this.textBox5.Text = "SELECT PORT RATE";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // portList
            // 
            this.portList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.portList.FormattingEnabled = true;
            this.portList.Location = new System.Drawing.Point(156, 10);
            this.portList.Name = "portList";
            this.portList.Size = new System.Drawing.Size(121, 28);
            this.portList.TabIndex = 30;
            // 
            // bitRate
            // 
            this.bitRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bitRate.FormattingEnabled = true;
            this.bitRate.Items.AddRange(new object[] {
            "115200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600"});
            this.bitRate.Location = new System.Drawing.Point(158, 45);
            this.bitRate.Name = "bitRate";
            this.bitRate.Size = new System.Drawing.Size(121, 28);
            this.bitRate.TabIndex = 31;
            // 
            // draw_square
            // 
            this.draw_square.Location = new System.Drawing.Point(930, 344);
            this.draw_square.Name = "draw_square";
            this.draw_square.Size = new System.Drawing.Size(94, 39);
            this.draw_square.TabIndex = 32;
            this.draw_square.Text = "Square";
            this.draw_square.UseVisualStyleBackColor = true;
            this.draw_square.Click += new System.EventHandler(this.draw_square_Click);
            // 
            // moveZN
            // 
            this.moveZN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveZN.Location = new System.Drawing.Point(171, 378);
            this.moveZN.Margin = new System.Windows.Forms.Padding(2);
            this.moveZN.Name = "moveZN";
            this.moveZN.Size = new System.Drawing.Size(66, 60);
            this.moveZN.TabIndex = 39;
            this.moveZN.Text = "-Z";
            this.moveZN.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.moveZN.UseVisualStyleBackColor = true;
            this.moveZN.Click += new System.EventHandler(this.moveZN_Click);
            // 
            // moveZP
            // 
            this.moveZP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveZP.Location = new System.Drawing.Point(171, 314);
            this.moveZP.Margin = new System.Windows.Forms.Padding(2);
            this.moveZP.Name = "moveZP";
            this.moveZP.Size = new System.Drawing.Size(66, 60);
            this.moveZP.TabIndex = 38;
            this.moveZP.Text = "+Z";
            this.moveZP.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.moveZP.UseVisualStyleBackColor = true;
            this.moveZP.Click += new System.EventHandler(this.moveZP_Click);
            // 
            // square_Size
            // 
            this.square_Size.Location = new System.Drawing.Point(840, 363);
            this.square_Size.Margin = new System.Windows.Forms.Padding(1);
            this.square_Size.Multiline = true;
            this.square_Size.Name = "square_Size";
            this.square_Size.Size = new System.Drawing.Size(86, 20);
            this.square_Size.TabIndex = 40;
            // 
            // square_label
            // 
            this.square_label.Location = new System.Drawing.Point(840, 344);
            this.square_label.Margin = new System.Windows.Forms.Padding(1);
            this.square_label.Multiline = true;
            this.square_label.Name = "square_label";
            this.square_label.ReadOnly = true;
            this.square_label.Size = new System.Drawing.Size(86, 20);
            this.square_label.TabIndex = 41;
            this.square_label.Text = "Enter edge size";
            // 
            // enter_command
            // 
            this.enter_command.Location = new System.Drawing.Point(840, 446);
            this.enter_command.Margin = new System.Windows.Forms.Padding(1);
            this.enter_command.Multiline = true;
            this.enter_command.Name = "enter_command";
            this.enter_command.Size = new System.Drawing.Size(145, 29);
            this.enter_command.TabIndex = 43;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(840, 406);
            this.textBox7.Margin = new System.Windows.Forms.Padding(1);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(115, 29);
            this.textBox7.TabIndex = 44;
            this.textBox7.Text = "Enter Command : ";
            // 
            // run_command
            // 
            this.run_command.Location = new System.Drawing.Point(841, 486);
            this.run_command.Margin = new System.Windows.Forms.Padding(1);
            this.run_command.Name = "run_command";
            this.run_command.Size = new System.Drawing.Size(142, 33);
            this.run_command.TabIndex = 46;
            this.run_command.Text = "Run";
            this.run_command.UseVisualStyleBackColor = true;
            this.run_command.Click += new System.EventHandler(this.run_command_Click);
            // 
            // btn_center
            // 
            this.btn_center.Location = new System.Drawing.Point(68, 475);
            this.btn_center.Name = "btn_center";
            this.btn_center.Size = new System.Drawing.Size(125, 59);
            this.btn_center.TabIndex = 48;
            this.btn_center.Text = "GO CENTER POSITION";
            this.btn_center.UseVisualStyleBackColor = true;
            this.btn_center.Click += new System.EventHandler(this.btn_center_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(840, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 49;
            // 
            // btn_clean
            // 
            this.btn_clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_clean.Location = new System.Drawing.Point(840, 160);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(125, 61);
            this.btn_clean.TabIndex = 50;
            this.btn_clean.Text = "CLEAN";
            this.btn_clean.UseVisualStyleBackColor = true;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // btn_draw_square
            // 
            this.btn_draw_square.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_draw_square.Location = new System.Drawing.Point(840, 21);
            this.btn_draw_square.Name = "btn_draw_square";
            this.btn_draw_square.Size = new System.Drawing.Size(125, 110);
            this.btn_draw_square.TabIndex = 51;
            this.btn_draw_square.Text = "DRAW";
            this.btn_draw_square.UseVisualStyleBackColor = true;
            this.btn_draw_square.Click += new System.EventHandler(this.btn_draw_square_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(282, 622);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(412, 20);
            this.textBox6.TabIndex = 52;
            this.textBox6.Text = " I ı ı ı ı ı ı I ı ı ı ı ı ı I ı ı ı ı ı ı I ı ı ı ı ı ı I ı ı ı ı ı ı I ı ı ı ı " +
    "ı ı I ı ı ı ı ı ı I ı ı ı ı ı ı I ı ı ı ı ı ı I ı ı ı ı ı ı I ı ı ı ı ı ı I ı ı " +
    "ı ı ı ı I";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(673, 10);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(21, 606);
            this.textBox8.TabIndex = 53;
            this.textBox8.Text = resources.GetString("textBox8.Text");
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(700, 15);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(30, 610);
            this.textBox9.TabIndex = 54;
            this.textBox9.Text = resources.GetString("textBox9.Text");
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(282, 669);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(412, 20);
            this.textBox10.TabIndex = 55;
            this.textBox10.Text = "X0                                                     RULER X                   " +
    "                                 X380";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1058, 689);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.btn_draw_square);
            this.Controls.Add(this.btn_clean);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_center);
            this.Controls.Add(this.run_command);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.enter_command);
            this.Controls.Add(this.square_label);
            this.Controls.Add(this.square_Size);
            this.Controls.Add(this.moveZN);
            this.Controls.Add(this.moveZP);
            this.Controls.Add(this.draw_square);
            this.Controls.Add(this.bitRate);
            this.Controls.Add(this.portList);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.moveYN);
            this.Controls.Add(this.moveXN);
            this.Controls.Add(this.moveYP);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.moveXP);
            this.Controls.Add(this.posZ);
            this.Controls.Add(this.posX);
            this.Controls.Add(this.posY);
            this.Controls.Add(this.lblZ);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserInterface";
            this.Text = "STEPCRAFT CONTROLLER";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lblX;
        private System.Windows.Forms.TextBox lblY;
        private System.Windows.Forms.TextBox lblZ;
        private System.Windows.Forms.TextBox posY;
        private System.Windows.Forms.TextBox posX;
        private System.Windows.Forms.TextBox posZ;
        private System.Windows.Forms.Button moveXP;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button moveYP;
        private System.Windows.Forms.Button moveXN;
        private System.Windows.Forms.Button moveYN;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox portList;
        private System.Windows.Forms.ComboBox bitRate;
        private System.Windows.Forms.Button draw_square;
        private System.Windows.Forms.Button moveZN;
        private System.Windows.Forms.Button moveZP;
        private System.Windows.Forms.TextBox square_Size;
        private System.Windows.Forms.TextBox square_label;
        private System.Windows.Forms.TextBox enter_command;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button run_command;
        private System.Windows.Forms.Button btn_center;
        private System.Windows.Forms.TextBox label1;
        private System.Windows.Forms.Button btn_clean;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btn_draw_square;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
    }
}

