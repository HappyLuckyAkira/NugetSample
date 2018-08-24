using System;

namespace SerialPort
{
    public class Serial :IDisposable
    {
        private System.IO.Ports.SerialPort _serialport;

        public Serial(string portName)
        {
            _serialport = new System.IO.Ports.SerialPort();
        }
        public void Close()
        {
            _serialport.Close();
        }

        public void Dispose()
        {
            _serialport.Close();
            _serialport.Dispose();
        }

        public void Open()
        {
            _serialport.Open();
        }
    }
}
