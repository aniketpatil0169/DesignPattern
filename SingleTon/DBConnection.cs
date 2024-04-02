using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon
{
    //public class DBConnection
    //{
    //    private static DBConnection _obj = null;

    //    private static object _o = new object();
    //    private DBConnection() { }

    //    public static DBConnection Instance
    //    {
    //        get
    //        {
    //            if (_obj == null)
    //             {
    //            lock (_o)
    //            {
    //                if (_obj == null)
    //                {
    //                    _obj = new DBConnection();
    //                }
    //                return _obj;
    //            }
    //        }
    //        return _obj;
    //    }
    //}
    // }

    public class DBConnection
    {
        private static DBConnection _obj = null;

        private static object _o = new object();

        private static int _counter = 1;
        private DBConnection() { }

        public static DBConnection Instance
        {
            get
            {
                if (_counter <= 5)
                {
                    _obj = new DBConnection();
                    _counter++;
                }
                else 
                {
                    Console.WriteLine("Only 5 objects are possible");
                }
                return _obj;
            }
        }
    }
}
