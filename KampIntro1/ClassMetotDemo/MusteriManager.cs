using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {

        //Musteri[] musteri = new Musteri[] {};

        public void musteriEkleme(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " +musteri.MusteriAd + " " + musteri.MusteriSoyAd + " " + musteri.MusteriTc + " " + musteri.MusteriYas);
            Console.WriteLine("Müşteri Eklendi");
        }

        public void musteriListele(Musteri musteri)
        { 
            Console.WriteLine(musteri.Id);
            Console.WriteLine(musteri.MusteriAd);
            Console.WriteLine(musteri.MusteriSoyAd);
            Console.WriteLine(musteri.MusteriTc);
            Console.WriteLine(musteri.MusteriYas);

        }

        public void musteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri bilgileri silindi..." + musteri.Id);
        }
    }
}
