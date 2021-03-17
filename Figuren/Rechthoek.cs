using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuren
{
    class Rechthoek
    {
        private int lengte = 1;
        private int breedte = 1;

        public int Lengte
        {
            get { return lengte; }
            set 
            {   
                if (value >= 1)
                    lengte = value; 
            }
        }

        public int Breedte
        {
            get { return breedte; }
            set 
            {
                if (value >= 1)
                    breedte = value; 
            }
        }

        public int ToonOppervlakte()
        {
            return lengte * breedte;
        }
    }
}
