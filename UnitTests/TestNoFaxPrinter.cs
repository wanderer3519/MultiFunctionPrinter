// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devices;

namespace UnitTests;

[TestClass]
public sealed class TestNoFaxPrinter
{
    [TestMethod]

    // Tester for the Print function in NoFaxPrinter
    public void TestPrint()
    {
        IPrinter printer = new AllRoundPrinter();
        string doc = "Testing the printer in No Fax printer";

        printer.Print(doc);

        Assert.AreEqual(doc, printer.PrintText);
    }

    [TestMethod]

    // Tester for the Scan function in NoFaxPrinter
    public void TestScan()
    {
        IScanner scanner = new AllRoundPrinter();
        string doc = "Testing the scanner in No Fax printer";

        scanner.Scan(doc);
        Assert.AreEqual(doc, scanner.Document);
    }
}
