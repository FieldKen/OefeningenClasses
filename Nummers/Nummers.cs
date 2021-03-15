using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nummers
{
    class Nummers
    {
        public int Getal1 { get; set; }
        public int Getal2 { get; set; }

        public int Som() { return Getal1 + Getal2; }
        public int Verschil() { return Getal1 - Getal2; }
        public int Product() { return Getal1 * Getal2; }

        public double Quotient()
        {
            if (Getal2==0)
            {
                Console.WriteLine("Delen door nul mag niet.");
                return -1;
            }

            return Convert.ToDouble(Getal1) / Getal2;
        }
    }
}
