using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports
{
    class Speler
    {
        private int rugnummer;
        private string naam;
        private bool isDoelman;
        private bool isReserve;
        private string reeks;

        public int Rugnummer
        {
            get { return rugnummer; }
            private set { rugnummer = value; }
        }

        public string Naam
        {
            get { return naam; }
            private set { naam = value; }
        }

        public bool IsDoelman
        {
            get { return isDoelman; }
            private set { isDoelman = value; }
        }

        public bool IsReserve
        {
            get { return isReserve; }
            private set { isReserve = value; }
        }

        public string Reeks
        {
            get { return reeks; }
            private set { reeks = value; }
        }

        public void GooiBal()
        {
            Console.WriteLine($"{naam} ({rugnummer}) gooit de bal!");
        }

        public void StelIn(int rugnummer, string naam, bool isDoelman, bool isReserve, string reeks)
        {
            Rugnummer = rugnummer;
            Naam = naam;
            IsDoelman = isDoelman;
            IsReserve = isReserve;
            Reeks = reeks;
        }
    }
}
