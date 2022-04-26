using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("MÜSTERİ EKLENDİ.\n");
            Console.WriteLine("Müşteri TC: " + musteri.ID);
            Console.WriteLine("Müşteri Adı Soyadı: " + musteri.Adi + " " + musteri.Soyadi);
            Console.WriteLine("Müşteri Yaşı: " + musteri.Yasi);
            Console.WriteLine("Müşteri Cinsiyeti: " + musteri.Cinsiyeti);
            Console.WriteLine(" ");
            Console.WriteLine("----------");
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("MÜŞTERİ SİLİNDİ.\n");
            Console.WriteLine("Müşteri Adı Soyadı: " + musteri.Adi + " " + musteri.Soyadi);
            Console.WriteLine(" ");
            Console.WriteLine("-----------");
        }

        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Müşteri TC: " + musteri.ID);
            Console.WriteLine("Müşteri Adı Soyadı: " + musteri.Adi + " " + musteri.Soyadi);
            Console.WriteLine("Müşteri Yaşı: " + musteri.Yasi);
            Console.WriteLine("Müşteri Cinsiyeti: " + musteri.Cinsiyeti);
            Console.WriteLine(" ");
        }
    }
}
