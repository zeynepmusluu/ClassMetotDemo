using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 1;
            musteri1.Adi = "Ali";
            musteri1.Soyadi = "Muslu";
            musteri1.Yasi = 25;
            musteri1.Cinsiyeti = "Erkek";

            Musteri musteri2 = new Musteri();
            musteri2.ID = 2;
            musteri2.Adi = "Zeynep";
            musteri2.Soyadi = "Muslu";
            musteri2.Yasi = 21;
            musteri2.Cinsiyeti = "Kadın";

            Musteri musteri3 = new Musteri();
            musteri3.ID = 3;
            musteri3.Adi = "Hasan";
            musteri3.Soyadi = "Muslu";
            musteri3.Yasi = 52;
            musteri3.Cinsiyeti = "Erkek";

            Musteri musteri4 = new Musteri();
            musteri4.ID = 4;
            musteri4.Adi = "Hasibe";
            musteri4.Soyadi = "Muslu";
            musteri4.Yasi = 47;
            musteri4.Cinsiyeti = "Kadın";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri3);
            musteriManager.MusteriSil(musteri1);
            Console.WriteLine("Müşteriler Listeleniyor.\n");
            for (int i = 0; i <= musteriler.Length; i++)
            {
                musteriManager.MusteriListele(musteriler[i]);
            }
        }
    }
}
