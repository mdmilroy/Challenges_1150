using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoOutings
{
    class ProgramUI
    {
        public void Run()
        {
            OutingsRepo repo = new OutingsRepo();
            bool running = true;
            UserHelper helper = new UserHelper();

            while (running)
            {
                Console.WriteLine("What do you want to do? 1 or 2 or 3");
                int response = Convert.ToInt32(Console.ReadLine());
                switch (response)
                {
                    case 1:
                        var add = helper.GetOutingToAdd();
                        repo.AddOuting(add);
                        break;
                    case 2:
                        var type = helper.GetTypeForCost();
                        repo.TotalCostByType(type);
                        break;
                    case 3:
                        running = false;
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please select a valid option.");
                        break;
                }
            }
        }
    }
}
