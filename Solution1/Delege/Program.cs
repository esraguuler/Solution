using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delege
{
    public delegate void MyDelege();
    class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager();
            MyDelege myDelege = customerManager.SendMessage;
            myDelege += customerManager.ShowAlert;
            myDelege -= customerManager.SendMessage;
           
            myDelege();

            Console.ReadLine();
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello");

        }

        public void ShowAlert()
        {
            Console.WriteLine("Be careful");
        }
    }
}
