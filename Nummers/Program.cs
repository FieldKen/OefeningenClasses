using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nummers
{
    class Program
    {
        static void Main(string[] args)
        {
            Nummers nummers = new Nummers();
            nummers.Getal1 = 5;
            nummers.Getal2 = 2;

            Console.WriteLine(nummers.Som());
            Console.WriteLine(nummers.Verschil());
            Console.WriteLine(nummers.Product());
            Console.WriteLine(nummers.Quotient());

            Console.ReadLine();
        }
    }
}
