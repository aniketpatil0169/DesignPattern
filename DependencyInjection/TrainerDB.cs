using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    // TrainerDB is low level module
    // sql data provider
    public class TrainerDB : ITrainerDB
    {
        // crud method for trainer table
        public void Insert()
        {
            Console.WriteLine("Trainer created successfully");
        }
    }
}
