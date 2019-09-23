using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using NUnit.Framework;

namespace Business.Tests
{
    [TestFixture]
    public class SerialPortParserTests
    {
        [Test]
        public void ParsePort_COM1_Returns1()
        {
            int result = SerialPortParser.ParsePort("COM1");
            Assert.That(result, Is.EqualTo(1));


        }
    }

}
