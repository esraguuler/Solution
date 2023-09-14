using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualmethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySql mySql = new MySql();
            mySql.Add(); 
            
            {
                Console.ReadLine();
            }
        }
            class Database
             {
            public virtual void Add()
            {
                Console.WriteLine("added by defult");

            }
             public virtual void Delete ()
            {
                Console.WriteLine("deleted by default");

               
            }

        }
            class SqlServer : Database
        {
             public override void Add()
            {
                Console.WriteLine("added by sql code");
            }
        }
             class MySql : Database
        {

        }
        }

    }

