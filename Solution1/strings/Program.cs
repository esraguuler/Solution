using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "my name is esra";
            var result = sentence.Length;
            var result2 = sentence.Clone();
            bool result3 = sentence.EndsWith("ğ");
            bool result4 = sentence.StartsWith("my");
            var result5 = sentence.IndexOf("namee");
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(1 , "hello, ");
            var result9 = sentence.Substring(3,6  );


             Console.WriteLine(result9 );
            Console.ReadLine();

            string city = "Ankara";
            Console.WriteLine(city[0]);
            Console.WriteLine("*******");

            foreach (var item in city)
            {
                Console.WriteLine(item);

            }

            string city2 = "istanbul";

            Console.WriteLine(string.Format("{0} {1}", city, city2));
            
        }
    }
}
 