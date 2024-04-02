using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Factory
    {
        public static Customer GetCustomer(string choice)
        {
            switch (choice)
            {
                case "SILVER":
                    return  new SilverCustomer();
                case "GOLD":
                    return  new GoldCustomer();
                case "PLATINIUM":
                    return  new PlatiniumCustomer();
                default:
                    return new Customer();
            }
        }
    }
}
