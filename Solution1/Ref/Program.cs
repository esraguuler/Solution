using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 20;
            int number2 = 30;

            var result = Add(ref number1, number2);
            Console.WriteLine(Add2(1, 3, 5));
            Console.WriteLine(number1 + number2);
            Console.WriteLine(number1);
            Console.ReadLine();
        }
         

        static int Add( ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Add2(params int [] numbers)
        {
            return numbers.Sum();
        } 
    }
}
