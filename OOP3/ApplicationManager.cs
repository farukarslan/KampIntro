using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        //Method injection
        public void ToApply(ICreditManager creditManager, List<ILoggerService> loggerServices)//parametre olarak hangi kredi türünü gönderirsek onun hesapla metodu çalışır
        {
            //Başvuran bilgilerini değerlendirme
            //
            //.....
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log(); //Loggerı list olarak belirttiğimiz için çoklu loglarla çalışabiliriz
            }
        }
        public void CreditPreInformation(List<ICreditManager> credits)//Kredi Önbilgilendirmesi //birden fazla kredi türü gönderilip sorgulanabilir
        {
            foreach (var credit in credits)
            {
                credit.Calculate(); //gelen bütün kredi türlerinin hesabını yap (tek bir kredi değil de birkaç tane kredi hesaplaması yapılabilir)
            }
        }
    }
}
