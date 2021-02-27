using System;

namespace GenericsDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> urunStok = new MyDictionary<string, int>();
            Console.WriteLine("---------Ürün Listesi---------");
            urunStok.Add("CAT Bot", 14);
            urunStok.Add("Nike Koşu ayakkabısı", 30);
            urunStok.Add("Adidas Sneaker", 23);
            urunStok.Add("Nike Terlik", 15);

            urunStok.List();
            Console.WriteLine("\nDizi içindeki eleman sayısı : "+urunStok.Length);
            
        }
    }
}
