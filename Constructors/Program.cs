using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Ömer Faruk", LastName = "Arslan", City = "İstanbul" };//parametresiz kullanım

            Customer customer3 = new Customer();
            customer3.Id = 3;

            Customer customer2 = new Customer(2, "Didem", "Akça", "İstanbul" ); //parametreli kullanım(method mantığı)

            Console.WriteLine(customer2.FirstName);
        }

    }

    class Customer
    {
        //default constructor(parametresi olmayan constructor)
        public Customer() // customer1 'de çalışan constructor
        {
            //Eğer default constructoru eklemezsek parametresiz kullanım şekli hata verir.Yeni eklenen constructor default ctoru ezer.
        }
        public Customer(int id, string firstName, string lastName, string city) //(ctor) //customer2 'de çalışan constructor
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
