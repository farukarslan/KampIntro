using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Kuralları içeren Interface
    interface ICreditManager //Okunurluğu arttırmak için interfaceler I harfi ile başlatılır ki interface olduğu kolay anlaşılsın.
    {
        void Calculate();
        void DoSomething();
    }
}
//İmzanın aynı olduğu fakat içerisinin farklı olduğu durumlarda basede oluşturduğumuz classı class olarak değil de interface olarak oluştururuz.
//Her credit mutlaka bu interfacedeki methodları içermek zorunda.

//Interfaceleri, birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
