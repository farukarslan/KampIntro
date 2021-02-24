using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //T  bizim verdiğimiz tipe karşılık gelir.Sadece bir tipte değil diğer tiplerde de eleman eklememizi sağlar.
    {
        T[] items;
        //constructor bloğu(classı newlediğimiz anda çalışan kod bloğu)
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;              //Aşağıdaki satırda eleman sayısını arttırmak için new yaptığımızda arrayin referans değeri değişiyor.
            items = new T[items.Length + 1];    //Önceki bilgilerin kaybolmaması için de geçici dizide önceki referansı tutuyoruz.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; // tempArray'de tutuan items'ın eski değerlerini items dizisine geri veriyoruz.
            }

            items[items.Length - 1] = item; // aslında eklenmek istenen yeni elemanı şimdi burada ekledik
        }

        public int Length
        {
            get { return items.Length; }
        }
        public T[] Items
        {
            get { return items; }
        }
    }
}
