using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DBConnection con1 =  DBConnection.Instance;

            DBConnection con2 =  DBConnection.Instance;

            DBConnection con3 =  DBConnection.Instance;

            if (con1.Equals(con2) && con2.Equals(con3))
            {
                Console.WriteLine("con1, con2 & con3 objects are EQUAL");
            }
            else
            {
                Console.WriteLine("con1, con2 & con3 objects are NOT EQUAL");
            }

            DBConnection con4 = DBConnection.Instance;

            DBConnection con5 = DBConnection.Instance;

            DBConnection con6 = DBConnection.Instance; // this is not possible


            Console.ReadLine();
        }
    }
}
