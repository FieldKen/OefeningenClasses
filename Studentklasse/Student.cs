using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentklasse
{
    public enum Klas { EA1, EA2, EA3, EA4 }
    class Student
    {
        public Klas MijnKlas { get; set; }
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public int PuntenCommunicatie { get; set; }
        public int PuntenProgrammingPrinciples { get; set; }
        public int PuntenWebTech { get; set; }

        public void GeefOverzicht()
        {
            Console.WriteLine($"{Naam}, {Leeftijd} jaar");
            Console.WriteLine($"Klas: {MijnKlas}");
            Console.WriteLine();
            Console.WriteLine("Cijferrapport");
            Console.WriteLine("*************");
            Console.WriteLine($"Punten Communicatie: {PuntenCommunicatie}");
            Console.WriteLine($"Punten ProgrammingPrinciples: {PuntenProgrammingPrinciples}");
            Console.WriteLine($"Punten WebTech: {PuntenWebTech}");
            Console.WriteLine($"Gemiddelde: {((PuntenCommunicatie + PuntenProgrammingPrinciples + PuntenWebTech)/3.0).ToString("0.00")}");
        }


    }
}
