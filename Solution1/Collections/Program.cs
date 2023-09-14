using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList cities = new ArrayList();
            cities.Add("Adana");
            cities.Add("Ankara");

            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('A');

            foreach (var city in cities)
            {
                Console.WriteLine(city);



            }

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, FirstName = "engin" });
            customers.Add(new Customer { Id = 2, FirstName = "derin" });

            var count = customers.Count;
            var customer2 = new Customer
            {
                Id=3, FirstName="salih"
            };
            customers.Add(customer2);
            customers.AddRange(new Customer[2]
            {
                new Customer { Id = 4, FirstName = "esra" },
                new Customer { Id = 5, FirstName = "buse" }
                });

            Console.WriteLine(customers.Contains(customer2));

            var index = customers.IndexOf(customer2);
            Console.WriteLine("Index : {0}", index);


            Console.ReadLine();

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);

            

            }

            

        }

        class Customer
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public bool Firstname { get; internal set; }
        }
    }
}
