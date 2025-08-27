using Devices;

namespace Executive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPrinter p = new ClassicPrinter();
            p.Print("Hello world");

            AllRoundPrinter all = new AllRoundPrinter();
            IScanner s = all;
            IPrinter p1 = all;

            p1.Print("Hello. Please type something to proceed: ");
            s.Scan();

            string d = s.doc;
            Console.WriteLine(d);
        }
    }
}
