using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity; 

namespace DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TrainerBl bl = new TrainerBl();

            //TrainerBl bl = new TrainerBl(new TrainerDB
            //
            //TrainerBl bl = new TrainerBl();
            //bl.Dependency = new TrainerDB();

            //TrainerBl bl = new TrainerBl();
            //bl.SetDependency(new TrainerDB());


            //rainerBl bl = new TrainerBl(new TrainerDB());

            //TrainerBl bl = new TrainerBl(new TrainerOracleDB());
            //bl.Insert();

            var container = new UnityContainer();
            // Register
            container.RegisterType<ITrainerDB, TrainerDB>();

            // Resolve
            TrainerBl bl = container.Resolve<TrainerBl>();

            bl.Insert();
            //bl.Insert();

            Console.WriteLine();
        }
    }
}
