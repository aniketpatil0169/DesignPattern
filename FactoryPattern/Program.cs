using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your ticket choice");
            string choice = Console.ReadLine().ToUpper();

            Customer c = Factory.GetCustomer(choice);
            //switch (choice)
            //{
            //    case "SILVER":
            //        c = new SilverCustomer();
            //        break;
            //    case "GOLD":
            //        c = new GoldCustomer();
            //        break;
            //    case "PLATINIUM":
            //        c = new PlatiniumCustomer();
            //        break;
            //    default:
            //        c = new Customer();
            //        break;
            //}
            Console.WriteLine(c.Name);

            Console.ReadLine();
        }
    }
}
