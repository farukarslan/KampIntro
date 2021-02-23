using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Didem";
            musteri1.Soyadi = "Akça";
            musteri1.Sehir = "İstanbul";
            musteri1.HesapTipi = "Şirket Hesabı";
            musteri1.Islem = "Para çekme(100.000tl)";
            musteri1.Tel = 05364789563;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Ömer Faruk";
            musteri2.Soyadi = "Arslan";
            musteri2.Sehir = "İstanbul";
            musteri2.HesapTipi = "Bireysel Hesap";
            musteri2.Islem = "Havale";
            musteri2.Tel = 05349875637;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Murat";
            musteri3.Soyadi = "Kısa";
            musteri3.Sehir = "Tokat";
            musteri3.HesapTipi = "Bireysel Hesap";
            musteri3.Islem = "Para yatırma";
            musteri3.Tel = 05368974236;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Adi = "Ali";
            musteri4.Soyadi = "Dak";
            musteri4.Sehir = "Bayburt";
            musteri4.HesapTipi = "Yatırım Hesabı";
            musteri4.Islem = "EFT";
            musteri4.Tel = 05324865941;

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("Eklenen Müşteriler:\n");
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri3);
            Console.WriteLine("\n--------------------------------------------------------------");
            Console.WriteLine("Listelenen Müşteriler:\n");
            musteriManager.List(musteri4);
            Console.WriteLine("\n--------------------------------------------------------------");
            Console.WriteLine("Silinen Müşteriler:\n");
            musteriManager.Delete(musteri2);


        }
    }
}
