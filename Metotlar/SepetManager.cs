using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention - isimlendirme
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi: " + urun.Adi);
        }

        public void Ekle2(string urunadi, string urunaciklamasi, double fiyati, int stokadedi)
        {
            Console.WriteLine("Sepete eklendi: " + urunadi);
        }
    }
}
