using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 2,
                FirstName = "esra"
            };

            Console.WriteLine(customer.Id);
            Console.ReadLine();
        }
         
    }
}
