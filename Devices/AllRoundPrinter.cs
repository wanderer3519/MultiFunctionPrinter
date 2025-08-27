using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices;

public class AllRoundPrinter : IScanner, IPrinter, IFax
{
    // Document in scan which is scanned
    private string _document = "";

    // Text to be printed in print
    private string _printText = "";

    // Text to be printed in fax
    private string _faxText = "";

    // Scanner's Document property
    public string Document
    {
        get => _document;

        set => _document = value;
    }

    // Printer's PrintText property
    public string PrintText
    {
        get => _printText;
        set => _printText = value;
    }

    // Fax's FaxText property
    public string FaxText
    {
        get => _faxText;
        set => _faxText = value;
    }

    // Implementation of the Fax method of Fax machine
    public void Fax(string doc, string telnum)
    {
        _document = doc;
        _faxText = $"Sending document: {_document} to {telnum}";
        FaxText = _faxText;
    }


    // Implementation of the Print method of Printer
    public void Print(string doc)
    {
        _printText = doc;
        PrintText = _printText;
    }

    // Implementation of the Scan method of Scanner
    public void Scan(string doc)
    {
        _document = doc;
        Document = _document;
    }
}
