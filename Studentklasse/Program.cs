using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentklasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.MijnKlas = Klas.EA1;
            student1.Leeftijd = 17;
            student1.Naam = "Bart";

            student1.PuntenCommunicatie = 9;
            student1.PuntenProgrammingPrinciples = 5;
            student1.PuntenWebTech = 3;

            student1.GeefOverzicht();
            Console.ReadLine();
        }
    }
}
