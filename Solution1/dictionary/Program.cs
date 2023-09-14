using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(dictionary.ContainsKey("glass"));





                Console.ReadLine();

            }

        }
    }
 
