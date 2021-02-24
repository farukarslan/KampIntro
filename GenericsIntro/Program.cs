using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Eğer C#'da List diye bir şey olmasaydı kendi koleksiyonumuzu nasıl yazardık?


            MyList<string> isimler = new MyList<string>(); //Arkaplanda T = string yaptık.
            isimler.Add("Ömer");

            Console.WriteLine(isimler.Length);

            isimler.Add("Ali");

            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
        }
    }
}
