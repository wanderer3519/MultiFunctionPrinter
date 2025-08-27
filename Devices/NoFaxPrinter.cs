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
    private string _document = "";
    private string _printText = "";

    public string Document
    {
        get => _document;
        set => _document = value;
    }
    public string PrintText
    {
        get => _printText;
        set => _printText = value;
    }

    public void Print(string doc)
    {
        _printText = doc;
        PrintText = _printText;
    }

    public void Scan(string doc)
    {
        _document = doc;
        Document = _document;
    }
}
