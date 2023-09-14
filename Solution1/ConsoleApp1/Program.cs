using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char charecter = 'A';
            int number1 = 10;
            decimal number2 = 10.6m; // 10 da yazabilirsin ama double kullanacağında m koy.
            Console.WriteLine("number1 is : {0}", number1);
            Console.WriteLine("charecter is : {0}" ,(int) charecter);
            Console.WriteLine("number2 is : {0}", number2);
            Console.WriteLine((int)Days.monday);
            Console.ReadLine();

           
        }
    }

    enum Days
    {
        monday,tuesday,wednesday,thursday,friday,saturday,sunday

    }
}
