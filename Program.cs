using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 100;
            musteri1.Adi = "Hasan";
            musteri1.Soyadi = "Çallı";
            musteri1.Kredisi = 500;

            Musteri musteri2 = new Musteri();
            musteri1.Id = 101;
            musteri1.Adi = "Burak";
            musteri1.Soyadi = "Ertürk";
            musteri1.Kredisi = 600;

            Musteri musteri3 = new Musteri();
            musteri1.Id = 102;
            musteri1.Adi = "Yusuf";
            musteri1.Soyadi = "Çallı";
            musteri1.Kredisi = 700;

            Musteri[] musteriler = new Musteri[] { musteri1 ,musteri2 ,musteri3 };

            foreach (var musteri in musteriler) 
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Kredisi);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Getir();
            musteriManager.Getir();
            musteriManager.Getir();
            musteriManager.Getir();
            musteriManager.Getir();

            Console.ReadLine();















        }
    }
}
