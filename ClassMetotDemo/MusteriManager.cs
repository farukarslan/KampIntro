using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " adlı müşteri eklendi.");

        }

        public void List(Musteri musteri)
        {
            Console.WriteLine("Müşteri Adı: " + musteri.Adi);
            Console.WriteLine("Müşteri Soyadı: " + musteri.Soyadi);
            Console.WriteLine("Yaşadığı Şehir " + musteri.Sehir);
            Console.WriteLine("Hesap Tipi: " + musteri.HesapTipi);
            Console.WriteLine("Telefon Numarası: " + musteri.Tel);
            Console.WriteLine("Yapılan İşlem: " + musteri.Islem);

        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " adlı müşteri silindi!");
        }
    }
}
