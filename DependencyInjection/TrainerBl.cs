using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    // TrainerBl is high level module
    public class TrainerBl // BL = Business Logic
    {
        private ITrainerDB _db;

        // using constructor
        public TrainerBl(ITrainerDB db)
        {
            _db = db;
        }

        //// Using property
        //public ITrainerDB Dependency
        //{
        //    set
        //    { 
        //        _db = value;
        //    }
        //}


        // Dependency injection through method

        //public void Dependency(ITrainerDB db)
        //{ 
        //    _db = db;
        //}
        public void Insert()
        {
            //TrainerDB db = new TrainerDB();
            //db.Insert();
            _db.Insert();
        }
    }
}
