using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoBadges
{
    class ProgramUI
    {

        private BadgesRepo _badges;
        private UserInputHelper _helper;

        public void Run()
        {
            
            bool running = true;

            while (running)
            {
                Console.WriteLine("Welcome. Please choose option:\n" +
                    "1. Create a new badge\n" +
                    "2. View all badges \n" +
                    "3. Edit a badge \n" +
                    "4. Exit");
                string userInput = Console.ReadLine();
                switch (Convert.ToInt32(userInput))
                {
                    case 1:
                        _helper = new UserInputHelper();
                        Badges badgeToCreate = _helper.GetBadgeToCreate();
                        _badges.CreateBadge(badgeToCreate);
                        break;
                    case 2:
                        _helper = new UserInputHelper();
                        _badges.ViewAllBadges();
                        break;
                    case 3:
                        _badges.EditBadge();
                        Console.Clear();
                        break;
                    case 4:
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
