// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices;
public class NoFaxPrinter : IScanner, IPrinter
{
    // Document in scan which is scanned
    private string _document = "";

    // Text printed when print is called
    private string _printText = "";

    // Document from Scanner
    public string Document
    {
        get => _document;
        set => _document = value;
    }

    // PrintText from Printer
    public string PrintText
    {
        get => _printText;
        set => _printText = value;
    }

    // Print method implementation from IPrinter
    public void Print(string doc)
    {
        _printText = doc;
        PrintText = _printText;

        Console.WriteLine(_printText);
    }

    // Scan method implementation from IScanner
    public void Scan(string doc)
    {
        _document = doc;
        Document = _document;
    }
}
