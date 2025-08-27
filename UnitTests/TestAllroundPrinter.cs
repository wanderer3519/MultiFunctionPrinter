using System.Reflection;
using System.Reflection.Metadata;
using System.Xml.Linq;
using Devices;

namespace UnitTests
{
    [TestClass]
    public sealed class TestAllroundPrinter
    {
        [TestMethod]
        public void TestPrint()
        {
            IPrinter printer = new AllRoundPrinter();
            string doc = "Testing the printer";

            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            printer.Print(doc);
            string output = stringWriter.ToString();
            Assert.AreEqual($"{doc}\r\n", output);

        }

        [TestMethod]
        public void TestScan() 
        {
            IScanner scanner = new AllRoundPrinter();
            string doc = "Testing the scanner";


            scanner.Scan(doc);
            Assert.AreEqual(doc, scanner.doc);
        }

        [TestMethod]
        public void TestFax()
        {
            IFax fax = new AllRoundPrinter();

            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            string info = "Hey, do your homework";
            string ipAddress = "123.1.1.128";

            

            string expectedMessage = $"Sending document: {info} to {ipAddress}";


            fax.Fax(info, ipAddress);
            string output = stringWriter.ToString();
            Assert.AreEqual(expectedMessage, output);

        }
    }
}
