using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ömer Faruk Arslan
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.FirstName = "Ömer Faruk";
            customer1.LastName = "Arslan";
            customer1.TcId = "12345678910";

            //Kodlama.io
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "1234567890";

            //Gerçek Müşteri(Individual-Bireysel) - Tüzel Müşteri (Corporate)
            //SOLID

            Customer customer3 = new IndividualCustomer();  //Customer classı hem Individual customerın referansını tutabiliyor
            Customer customer4 = new CorporateCustomer();  //hem de corporate customerın referansını tutabiliyor

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);


        }
    }
}
