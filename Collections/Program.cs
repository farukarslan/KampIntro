using System;
using System.Collections.Generic; //List kullanımı için

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Ömer", "Ali", "Mehmet", "Ahmet" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5]; //new ile bellekte yeni bir referans adres oluştu (Diziye belirtilenden fazla eleman eklemek için bu yöntemi kullanırsak önceki değerleri kaybederiz.)
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]); //bu yüzden burada 0.eleman gözükmez yeni adreste 0.eleman yok(boş)


            //Arrayle yapılan hareketlerin aynısını koleksiyonlar ile yapmak(arraylerde bir sabitlik var)
            List<string> isimler2 = new List<string> { "Ömer", "Ali", "Mehmet", "Ahmet" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker"); 
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]); //Koleksiyonlarda sabitlik olmadığı için yeni bir değer eklendiğinde eleman sayısı 1 artar.
            //Arraylerde olduğu gibi değerleri kaybetmiyoruz.Koleksiyonlarda bunu engelleyen bir altyapı mevcut.
            
        }
    }
}
