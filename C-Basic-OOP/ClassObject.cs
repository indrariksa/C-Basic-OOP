using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basic_OOP
{
    internal class ClassObject
    {
    }

    public class Mobil
    {
        public double kecepatan;
        public double bensin;
        public double posisi;
        public string nama;

        public void percepat()
        {
            this.kecepatan += 10;
            this.bensin -= 5;
        }
        public void maju()
        {
            this.posisi += this.kecepatan;
            this.bensin -= 2;
        }
        public void isibensin(double bensin)
        {
            this.bensin += bensin;
        }

        public Mobil(string nama, double kecepatan, double bensin)
        {
            this.nama = nama;
            this.kecepatan = kecepatan;
            this.bensin = bensin;
            this.posisi = 0;
        }

        public Mobil()
        {
            this.nama = "";
            this.kecepatan = 0;
            this.bensin = 0;
            this.posisi = 0;
        }

        ~Mobil()
        {
            Console.WriteLine("mobil " + nama + " telah dihancurkan");
        }
    }
}
