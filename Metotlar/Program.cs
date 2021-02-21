using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { "Elma", "Karpuz" };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler) //urunler dizisini tek tek geziyor //en soldaki veri tipi
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("---------------Metotlar-----------------");

            //instance - örnek
            //encapsulation - Kapsulleme - ayrı ayrı yazmak yerine class kullanarak encapsulation yapıyoruz.

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 8);   // Metodumuzda bir parametre değişikliği yaptığımızda burayı da değiştirmemiz gerekiyor.
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);      // Eğer ki değiştirmezsek burada patlicak ve hata vericek.
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 9); // Bu kullanım şekli yerine class kullandığımızda yeni eklenen property
                                                                       // için metodu düzeltmemiz gerekmiyor. Çünkü class bütün propertyleri kendi içerisinde barındırıyor.

        }
    }
}

//Dont repeat yourself(DIY) - tekrar etme - clean code - best practice
