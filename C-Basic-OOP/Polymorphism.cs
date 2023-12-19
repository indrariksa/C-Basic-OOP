﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basic_OOP
{
    internal class Polymorphism
    {
    }
    class Bentuk
    {
        public virtual void Gambar()
        {
            Console.WriteLine("Ini adalah Base Class Bentuk");
        }
    }

    class Lingkaran : Bentuk
    {
        public override void Gambar()
        {
            // Menggambar Lingkaran...
            Console.WriteLine("Menggambar Lingkaran...");
        }
    }
    class Persegi : Bentuk
    {
        public override void Gambar()
        {
            // Menggambar Persegi...
            Console.WriteLine("Menggambar Persegi...");
        }
    }
}
