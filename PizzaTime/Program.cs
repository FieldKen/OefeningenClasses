using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new Pizza();
            pizza.Toppings = "Salami";
            pizza.Diameter = 8;
            pizza.Prijs = 16.70;
            Console.WriteLine($"Toppings: {pizza.Toppings}");
            Console.WriteLine($"Diameter: {pizza.Diameter}");
            Console.WriteLine($"Prijs: {pizza.Prijs}");


            pizza.Toppings = "";
            Console.WriteLine($"Toppings: {pizza.Toppings}");
            pizza.Diameter = -8;
            Console.WriteLine($"Diameter: {pizza.Diameter}");
            pizza.Prijs = -16.70;
            Console.WriteLine($"Prijs: {pizza.Prijs}");
            Console.ReadLine();
        }
    }
}
