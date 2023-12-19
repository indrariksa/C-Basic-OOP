using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basic_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mobil SuatuMobil = new Mobil();
            //Mobil MobilSaya = new Mobil() { nama = "Ferrari", kecepatan = 0, bensin = 30000, posisi = 0 };
            //Mobil MobilAnda = new Mobil("Lamborghini", 300, 50000);
            //MobilSaya.percepat();
            //Console.WriteLine(SuatuMobil.nama);
            //Console.WriteLine(SuatuMobil.bensin);
            //Console.WriteLine(MobilSaya.nama);
            //Console.WriteLine(MobilSaya.bensin);
            //Console.WriteLine(MobilAnda.nama);

            //PropertyTest p = new PropertyTest();
            //PropertyTest p2 = new PropertyTest() {materi2 = "Pemrograman II"};
            //p.Materi = "OOP";
            //p2.Materi = "Mobile";
            //Console.WriteLine(p.Materi);
            //Console.WriteLine(p2.materi2);

            //Person person = new Person();
            //person.Nilai = 60;
            //Console.WriteLine(person.Nilai);

            Civic c = new Civic();
            Console.WriteLine(c.Roda);
            c.Klakson();
            c.KlaksonMobil();

            //Bentuk l = new Lingkaran();
            //l.Gambar();
            ////Outputs "Menggambar Lingkaran..."

            //Bentuk p = new Persegi();
            //p.Gambar();
        }
    }
}
