﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, LastName = "Guler", Age = 32 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();

            
        }
    }

    [ToTable("Customers")]
    class Customer
    {
        public int Id { get; set; }
       [RequiredProperty]
        public string FirstName { get; set; }
        [RequiredProperty]
        public string  LastName { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }

    class CustomerDal
    {
        [Obsolete("Dont use Add, instead use AddNew Method")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }

}

class RequiredPropertyAttribute:Attribute
    {

    }

    class ToTableAttribure : Attribute
    {
        private string _tableName;

        public ToTableAttribure(string tableName)
        {
             _tableName = tableName;
        }
            

        

    }
