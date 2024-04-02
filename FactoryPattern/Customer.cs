using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Customer
    {
        public string Name { get; set; }

        public Customer()
        {
            Name = "NORMAL CUSTOMER";
        }
    }
    public class SilverCustomer : Customer
    {
        public SilverCustomer()
        {
            Name = "SILVER CUSTOMER";
        }
    }
    public class GoldCustomer : Customer
    {
        public GoldCustomer()
        {
            Name = "GOLD CUSTOMER";
        }
    }
    public class PlatiniumCustomer : Customer
    {
        public PlatiniumCustomer()
        {
            Name = "PLATINIUM CUSTOMER";
        }
    }
}
