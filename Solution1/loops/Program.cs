using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // NewMethod();

            string[] students = { "engin", "derin", "salih" };
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
                Console.ReadLine();
            }

            private static void NewMethod()
            {
                for (int i = 1; i <= 10; i = i + 2)
                {
                    Console.WriteLine(i);


                }
                Console.WriteLine("finished");
            }
        }
    }


