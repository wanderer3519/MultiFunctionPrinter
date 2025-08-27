// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Devices;

namespace Executive;

internal class Program
{
    static void Main()
    {
        // Demo of All round printer
        AllRoundPrinter arp = new AllRoundPrinter();

        // using all round printer to print
        IPrinter p1 = arp;

        // using all round printer to scan
        IScanner s1 = arp;

        // using all round printer to fax
        IFax f = arp;

        p1.Print("Hello world from all round printer");
        s1.Scan("This is my document from all round printer");
        f.Fax("My document from all round printer", "9876554399");

        // Demo of no fax printer
        NoFaxPrinter nfp = new NoFaxPrinter();

        // using no fax printer to print
        IPrinter p2 = nfp;

        // using no fax printer to scan
        IScanner s2 = nfp;

        p2.Print("Hello world from no fax printer!");
        s2.Scan("This is my document from no fax printer");
    }
}
