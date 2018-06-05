using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace StepcraftUi
{
    public partial class UserInterface : Form
    {
        static bool _continue;
        SerialPort _serialPort;
        TextBox output = new TextBox();
        Boolean positionIsHome = true;
        Boolean positionIsCenter = false;
        List<Line> lines = new List<Line>();
        Line line = null;
        
        public UserInterface()
        {
            InitializeComponent();
            GoFullscreen(true);
            var lines = new List<Line>();
        }
            
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                line = new Line { Start = e.Location, End = e.Location };
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                lines.Add(line);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (line != null)
            {
                e.Graphics.DrawLine(Pens.Red, line.Start, line.End);
                line.Print();
            }

            foreach (var l in lines)
            {
                e.Graphics.DrawLine(Pens.Silver, l.Start, l.End);
                line.Print();
            }
        }
       

        private void Clean()
        {
            lines = new List<Line>();
            line = null;
            panel1.Refresh();
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "X = " + e.X + " ; Y = " + e.Y;
            if (e.Button == MouseButtons.Left)
            {
                line.End = e.Location;
                panel1.Invalidate();
            }
        }

        private void btn_connect_Click(object sender, System.EventArgs e)
        {
            try
            {
                connect();
                reverseVisible();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void addAndListPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            if (ports.Length == 0)
                Console.WriteLine("The following serial ports were found:");
            foreach (string s in SerialPort.GetPortNames())
            {
                portList.Items.Add(s);
            }
        }
        public void connect()
        {
            try
            {
                if (portList.SelectedItem.ToString() != null && 
                    bitRate.SelectedItem.ToString() != null)
                {
                    //port = new SerialPort(portList.SelectedItem.ToString(), Int32.Parse(bitRate.SelectedItem.ToString()), Parity.None, 8, StopBits.One);
                    MessageBox.Show("Connection Success:");
                    PortChat(portList.SelectedItem.ToString(), Int32.Parse(bitRate.SelectedItem.ToString()));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("PORT AND BITRATE SHOULD BE SELECTED " + e.ToString());
            }
        }
        private void PortChat(string PortName, int BaudRate)
        {
            _serialPort = new SerialPort();
            _serialPort.PortName = PortName;
            _serialPort.BaudRate = BaudRate;
            _serialPort.Parity = Parity.None;
            _serialPort.DataBits = 8;
            _serialPort.StopBits = StopBits.One;
            _serialPort.Handshake = _serialPort.Handshake;
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            // Allow the user to set the appropriate properties.
            _continue = true;

            // Set the read/write timeouts
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;
            _serialPort.Open();

            //set home position
            OneStep("M306 Z0");
            OneStep("G92 X0 Y0 Z0");
            OneStep("g28");

        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            Console.WriteLine( "  " + "Data Received:");
            Console.WriteLine("  " + indata);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            addAndListPorts();
            panel1.BackColor = Color.White;
            reverseVisible();

        }
        private void reverseVisible()
        {
            moveXN.Visible = !moveXN.Visible;
            moveYN.Visible = !moveYN.Visible;
            moveXP.Visible = !moveXP.Visible;
            moveYP.Visible = !moveYP.Visible;
            moveZN.Visible = !moveZN.Visible;
            moveZP.Visible = !moveZP.Visible;
            btn_center.Visible = !btn_center.Visible;
            btn_draw.Visible = !btn_draw.Visible;
            btn_home.Visible = !btn_home.Visible;
            btn_clean.Visible = !btn_clean.Visible;
            run_command.Visible = !run_command.Visible;
            draw_square.Visible = !draw_square.Visible;
        }
        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            connectionClose();
        }
        private void draw_square_Click(object sender, EventArgs e)
        {
            if (positionIsCenter == true)
            {
                var isNumeric = int.TryParse(square_Size.Text.ToString(), out int n);

                if (square_Size != null && isNumeric)
                {
                    int size = Int32.Parse(square_Size.Text.ToString());
                    //Console.WriteLine(size);
                    OneStep("G0 X" + size.ToString());
                    OneStep("G0 Y" + size.ToString());
                    OneStep("G0 X-" + size.ToString());
                    OneStep("G0 Y-" + size.ToString());

                }     
            }            
        }
        private void btn_home_Click(object sender, EventArgs e)
        {
            goHome();
        }
        private void goHome()
        {
            _serialPort.WriteLine("G28");
        }
        private void run_command_Click(object sender, EventArgs e)
        {
            OneStep(enter_command.Text.ToString());
        }
        public void position()
        {
            _serialPort.WriteLine("?");
        }
 
        public void OneStep(string message)
        {
            //Console.WriteLine(message);
            _serialPort.WriteLine(message);
            position();
        }
        public void connectionClose()
        {
            _serialPort.Close();
        }

        private void GoFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                WindowState = FormWindowState.Maximized;
                Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                FormBorderStyle = FormBorderStyle.Sizable;
            }
        }

        private void btn_center_Click(object sender, EventArgs e)
        {
            _serialPort.WriteLine("G91 X 90");
            _serialPort.WriteLine("G91 Y -110");
            _serialPort.WriteLine("G91 Z -70");
        }

        private void draw_Butterfly_Click(object sender, EventArgs e)
        {
            string[] butterfly = getProgram(@"C:\Users\Espanyol\Desktop\Desk\GitReposityoy\Graduation_Project\Graduation_Project\Ui\StepcraftUi\StepcraftUi\butterflies\butterfly.nc");
            foreach(string str in butterfly)
                _serialPort.WriteLine(str);

        }

        private String[] getProgram(string filename)
        {
            string[] lines = null;
            try
            {
                lines = System.IO.File.ReadAllLines(filename);

            }
            catch (Exception ex)
            {
                Console.WriteLine("ex: " + ex.ToString());
            }

                return lines;
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            Clean();
            
        }
        /** X Ekseni için Belirlenen Haraket Alanı 43 cm - Cihazın o yöndeki step sayısı 190 , Step Aralığı 0,226
         * *Y Ekseni için Belirlenen Haraket Alanı 104.8 cm - Cihazın o yöndeki step sayısı 300 , Step Aralığı 0,349
         * * X ekseninde 380 pixel var
         * * Y ekseninde 450 pixel var
         * *
         */
  
        private void drawLine(int x1,int x2,int y1,int y2,int feedRate)
        {
            int difX = ((x2 - x1) / 2);
            int difY = (-1) * ((y2 - y1) / 2);
            string command = "G01 X " + difX.ToString() + "  Y " + difY.ToString() + " f"+ feedRate.ToString();
            Console.WriteLine(command);
            OneStep(command);
        }
        private void btn_draw_Click(object sender, EventArgs e)
        {
            if (lines != null)
            {
                // start
                // go start point

                bool isFirst = true;

                Line line ;
                for (int i = 0; i <lines.Count; i++ )
                {
                    line = lines[i];

                    if (isFirst)
                    {
                        drawLine(0, line.Start.X, 0, line.Start.Y, 500);
                        isFirst = false;
                    }
                    else
                    {
                        Line previous = lines[i - 1];
                        drawLine(previous.End.X, line.Start.X, previous.End.Y, line.Start.Y, 500);
                    }

                    UpDownZaxis(true,-70);
                    drawLine(line.Start.X,line.End.X, line.Start.Y, line.End.Y, 500);
                    UpDownZaxis(false,70);

                }
                goHome();
            }
        }
        private void UpDownZaxis(Boolean state,int stepNum)
        {
            string command = "";
            command = "G91 Z " + stepNum.ToString();
            OneStep(command);
        }

        private void moveXP_MouseDown(object sender, MouseEventArgs e)
        {
            OneStep("G91 X 1");
        }

        private void moveYP_MouseDown(object sender, MouseEventArgs e)
        {
            OneStep("G91 Y 1");
        }

        private void moveZP_MouseDown(object sender, MouseEventArgs e)
        {
            OneStep("G91 z 1");
        }

        private void moveXN_MouseDown(object sender, MouseEventArgs e)
        {
            OneStep("G91 X-1");
        }

        private void moveYN_MouseDown(object sender, MouseEventArgs e)
        {
            OneStep("G91 Y -1");
        }

        private void moveZN_MouseDown(object sender, MouseEventArgs e)
        {
            OneStep("G91 z -1");
        }
    }
}

