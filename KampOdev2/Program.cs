using System;

namespace KampOdev2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.AyakkabiMarkası = "Nike";
            product1.AyakkabiNo = "35-42";
            product1.Renk = "Siyah";
            product1.Cinsiyet = "Erkek";
            product1.Fiyat = 250;
            product1.AyakkabiTipi = "Spor";

            Product product2 = new Product();
            product2.Id = 2;
            product2.AyakkabiMarkası = "Adidas";
            product2.AyakkabiNo = "35-39";
            product2.Renk = "Pembe";
            product2.Cinsiyet = "Kadın";
            product2.Fiyat = 400;
            product2.AyakkabiTipi = "Spor";

            Product product3 = new Product();
            product3.Id = 3;
            product3.AyakkabiMarkası = "Greyder";
            product3.AyakkabiNo = "35-44";
            product3.Renk = "Kum yeşili";
            product3.Cinsiyet = "Unisex";
            product3.Fiyat = 750;
            product3.AyakkabiTipi = "Bot";

            Product product4 = new Product();
            product4.Id = 4;
            product4.AyakkabiMarkası = "Skechers";
            product4.AyakkabiNo = "39";
            product4.Renk = "Mavi";
            product4.Cinsiyet = "Kadın";
            product4.Fiyat = 650;
            product4.AyakkabiTipi = "Spor";

            Product[] products = new Product[] { product1, product2, product3, product4 };
            foreach (var product in products)
            {
                Console.WriteLine("Ayakkabı Markası: " + product.AyakkabiMarkası + "\nAyakkabı Tipi: " + product.AyakkabiTipi + "\nAyakkabı Rengi: " + product.Renk
                    + "\nAyakkabı Numarası: " + product.AyakkabiNo + "\nCinsiyet: " + product.Cinsiyet + "\nAyakkabı Fiyatı: " + product.Fiyat);
                Console.WriteLine("---------------------------------------------------");

            }
        }
    }
}
