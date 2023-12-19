using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basic_OOP
{
    internal class Inheritance
    {
    }

    class Car
    {
        public int Roda { get; set; }
        public int Tahun { get; set; }

        public void KlaksonMobil()
        {
            Console.WriteLine("Telolet!!!");
        }
    }

    class Civic : Car
    {
        public Civic()
        {
            Roda = 4;
        }
        public void Klakson()
        {
            Console.WriteLine("Biiim...!!!");
        }
    }
}
