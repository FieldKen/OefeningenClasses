using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime
{
    class Pizza
    {
        private string toppings;

        public string Toppings
        {
            get { return toppings; }
            set 
            { 
                if (value != "")
                    toppings = value; 
            }
        }

        private int diameter;

        public int Diameter
        {
            get { return diameter; }
            set 
            { 
                if (value >= 0)
                    diameter = value; 
            }
        }

        private double prijs;

        public double Prijs
        {
            get { return prijs; }
            set
            {
                if (value >= 0)
                    prijs = value; 
            }
        }
    }
}
