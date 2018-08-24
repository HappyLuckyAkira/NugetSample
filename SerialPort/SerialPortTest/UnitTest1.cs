using System;
using NUnit;
using NUnit.Framework;
using SerialPort;

namespace SerialPortTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void OpenTest()
        {
            var port = new Serial("COM7");
            Assert.DoesNotThrow(() => port.Open());

        }
    }
}
