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
                    "2. View all badges \n" +
                    "3. Edit a badge \n" +
                    "4. Exit");
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
                    case "3":
                        _badges.EditBadge();
                        Console.Clear();
                        break;
                    case "4":
                        running = false;
                        Environment.Exit(0);
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
