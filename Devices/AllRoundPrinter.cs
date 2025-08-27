using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices
{
    public class AllRoundPrinter : IScanner, IPrinter, IFax
    {
        private string document = "";
        public string doc
        {
            get
            {
                return document;
            }
            set
            {
                document = value;
            }
        }

        public void Fax(string doc, string ip)
        {
            Scan(doc);
            Console.WriteLine($"Sending document: {document} to {ip}");
        }


        public void Print(string doc)
        {
            Console.WriteLine(doc);
        }

        public void Scan(string doc)
        {
            document += doc;
        }
    }
}
