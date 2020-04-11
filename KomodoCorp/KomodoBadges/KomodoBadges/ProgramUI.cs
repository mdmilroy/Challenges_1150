using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoBadges
{
    public class ProgramUI
    {
        public void Run()
        {
            BadgesRepo _badges = new BadgesRepo();
            bool running = true;

            while (running)
            {
                Console.WriteLine("Welcome. Please choose option:\n" +
                    "1. Create a new badge\n" +
                    "2. View all badges \n");
                string r = Console.ReadLine();
                switch (r)
                {
                    case "1":
                        _badges.CreateBadge();
                        Console.Clear();
                        break;
                    case "2":
                        _badges.ViewAllBadges();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Please choose a valid option.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
