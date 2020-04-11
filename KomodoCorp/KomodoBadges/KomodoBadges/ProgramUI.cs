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
                    "1. Create a new badge.\n");
                string r = Console.ReadLine();
                if (r == "1")
                {
                    _badges.CreateBadge();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Please choose a valid option.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

        }
    }
}
