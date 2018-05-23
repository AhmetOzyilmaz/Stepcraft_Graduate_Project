using System;
using System.IO.Ports;
using System.Threading;
using System.Timers;

namespace StepcraftUi
{
  
    public class PortChat
    {
        static bool _continue ;
        static SerialPort _serialPort;
        static string pName = "";
        static int baudRate = 0;
   
        public PortChat(string PortName, int BaudRate)
        {
            _serialPort = new SerialPort();
            _serialPort.PortName = PortName;
            _serialPort.BaudRate = BaudRate;
            _serialPort.Parity = Parity.None;
            _serialPort.DataBits = 8;
            _serialPort.StopBits = StopBits.One;
            _serialPort.Handshake = _serialPort.Handshake;

            // Allow the user to set the appropriate properties.

            // Set the read/write timeouts
            _serialPort.ReadTimeout = 20;
            _serialPort.WriteTimeout = 20;
            _serialPort.Open();

            pName = PortName;
            baudRate = BaudRate;
        }
        public void flushBuffer()
        {      
            Read();                        
        }
        public void OneStep(string message)
        {
            _continue = false;
            Console.WriteLine("Write : " + message);
             _serialPort.WriteLine(message);
            _continue = true;

        }
        public void Close()
        {
            _serialPort.Close();
        }
        public static void Read()
        {
            while (_continue)
            {
                try
                {
                    string message = _serialPort.ReadLine();
                    Console.WriteLine("Read : " + message);
                }
                catch (TimeoutException) {
                    break;
     
                }
            }
        }
    }
}
