using System.Reflection;
using System.Reflection.Metadata;
using System.Xml.Linq;
using Devices;

namespace UnitTests;

[TestClass]
public sealed class TestAllRoundPrinter
{
    [TestMethod]

    // Tester for the Print method in AllRoundPrinter
    public void TestPrint()
    {
        IPrinter printer = new AllRoundPrinter();
        string doc = "Testing the printer in All round printer";

        printer.Print(doc);

        Assert.AreEqual(doc, printer.PrintText);
    }

    [TestMethod]

    // Tester for the Scan method in AllRoundPrinter
    public void TestScan()
    {
        IScanner scanner = new AllRoundPrinter();
        string doc = "Testing the scanner in All round printer";

        scanner.Scan(doc);
        Assert.AreEqual(doc, scanner.Document);
    }

    [TestMethod]

    // Tester for the Fax method in AllRoundPrinter
    public void TestFax()
    {
        IFax fax = new AllRoundPrinter();

        string info = "Hey, do your homework";
        string telephoneNumber = "9886654423";

        string expectedMessage = $"Sending document: {info} to {telephoneNumber}";


        fax.Fax(info, telephoneNumber);

        Assert.AreEqual(expectedMessage, fax.FaxText);
    }
}
