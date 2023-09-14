using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] bolgeler = new string[5, 3]
            {
                {"istanbul","izmit" ,"balıkesir" },
                {"ankara","konya" ,"kayseri" },
                {"istanbul","izmit" ,"balıkesir" },
                {"istanbul","izmit" ,"balıkesir" },
                {"istanbul","izmit" ,"balıkesir" },



            };

            for ( int i = 0; i <= bolgeler.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= bolgeler.GetUpperBound(1); j++)
                {
                    Console.WriteLine(bolgeler[i,j]);
                }

            }
            
            Console.ReadLine();
        }
    }
}
