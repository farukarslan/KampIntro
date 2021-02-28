using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalCreditManager = new PersonalCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager mortgageCreditManager = new MortgageCreditManager();

            //Interfaceler de o interface i implement eden classın referans numarasını tutabilir.

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };//işlemde birden fazla log işlemi yapabilmemiz için

            ApplicationManager applicationManager = new ApplicationManager();       
            applicationManager.ToApply(vehicleCreditManager, loggers);//Başvuruya hangi kredi türü gönderilirse o türün classındaki hesaplama metodu çalışır.Aynısı loglama türü için de geçerlidir.

            List<ICreditManager> credits = new List<ICreditManager>() { personalCreditManager, mortgageCreditManager };
            //applicationManager.CreditPreInformation(credits); //Birden fazla kredi türü hesaplanması için

        }
    }
}
