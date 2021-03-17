using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuren
{
    class Program
    {
        static void Main(string[] args)
        {
            Rechthoek rechthoek = new Rechthoek();
            rechthoek.Breedte = 10;
            rechthoek.Lengte = 5;
            Console.WriteLine($"Oppervlakte rechthoek is {rechthoek.ToonOppervlakte()}");

            Driehoek driehoek = new Driehoek();
            driehoek.Basis = 1;
            driehoek.Hoogte = 5;
            Console.WriteLine($"Oppervlakte driehoek is {driehoek.ToonOppervlakte()}");
            Console.ReadLine();
        }
    }
}
