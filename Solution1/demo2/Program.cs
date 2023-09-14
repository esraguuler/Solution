using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerMenager customerMenager = new CustomerMenager();
            customerMenager.Logger = new ILogger();
            customerMenager.Add();
            Console.ReadLine();

        }
    }

    class CustomerMenager
    {
        public ILogger Logger { get; set; }
        public void Add()
        {
            Logger.Log();
            Console.WriteLine("customer added");
        }
    }

    class ILogger : Ilogger
    {
        public void Log()
        {
            Console.WriteLine("logged to database");

        }
    }
    class FileLogger : Ilogger
    {
        public void Log()
        {
            Console.WriteLine("logged to file");


        }
    }
    interface Ilogger
    {
    }
}