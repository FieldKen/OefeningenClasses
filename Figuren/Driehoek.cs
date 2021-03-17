using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuren
{
    class Driehoek
    {
        private int hoogte = 1;
        private int basis = 1;

        public int Hoogte
        {
            get { return hoogte; }
            set
            {
                if (value >= 1)
                    hoogte = value;
            }
        }

        public int Basis
        {
            get { return basis; }
            set
            {
                if (value >= 1)
                    basis = value;
            }
        }

        public double ToonOppervlakte()
        {
            return hoogte * basis / 2.0;
        }
    }
}
