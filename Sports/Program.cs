using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports
{
    class Program
    {
        static void Main(string[] args)
        {
            Speler speler = new Speler();
            speler.StelIn(50, "Vincent", true, true, "Eerste klasse");
            speler.GooiBal();
            Console.ReadLine();
        }
    }
}
