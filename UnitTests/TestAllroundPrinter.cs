using System.Reflection;
using System.Reflection.Metadata;
using System.Xml.Linq;
using Devices;

namespace UnitTests;

[TestClass]
public sealed class TestAllRoundPrinter
{
    [TestMethod]
    public void TestPrint()
    {
        IPrinter printer = new AllRoundPrinter();
        string doc = "Testing the printer in All round printer";

        printer.Print(doc);

        Assert.AreEqual(doc, printer.PrintText);
    }

    [TestMethod]
    public void TestScan()
    {
        IScanner scanner = new AllRoundPrinter();
        string doc = "Testing the scanner in All round printer";

        scanner.Scan(doc);
        Assert.AreEqual(doc, scanner.Document);
    }

    [TestMethod]
    public void TestFax()
    {
        IFax fax = new AllRoundPrinter();

        string info = "Hey, do your homework";
        string ipAddress = "123.1.1.128";

        string expectedMessage = $"Sending document: {info} to {ipAddress}";


        fax.Fax(info, ipAddress);

        Assert.AreEqual(expectedMessage, fax.FaxText);
    }
}
