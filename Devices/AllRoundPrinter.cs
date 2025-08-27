using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices;

public class AllRoundPrinter : IScanner, IPrinter, IFax
{
    private string _document = "";
    private string _printText = "";
    private string _faxText = "";


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

    public string FaxText
    {
        get => _faxText;
        set => _faxText = value;
    }

    public void Fax(string doc, string ip)
    {
        _document = doc;
        _faxText = $"Sending document: {_document} to {ip}";
        FaxText = _faxText;
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
