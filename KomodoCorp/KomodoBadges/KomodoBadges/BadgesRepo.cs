using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoBadges
{
    public class BadgesRepo
    {
        public Dictionary<int, List<string>> _allBadges = new Dictionary<int, List<string>>();

        public void CreateBadge(Badges badgeToCreate)
        {
            _allBadges.Add(badgeToCreate.badgeID, badgeToCreate.badgeAccess);
        }

    
        public Dictionary<int, List<string>> ViewAllBadges()
        {
                return _allBadges;
        }

        public void EditBadge()
        {
            Console.Clear();
            if (_allBadges.Count > 0)
            {
                Console.WriteLine("{0, -15}", "Badge");
                foreach (KeyValuePair<int, List<string>> item in _allBadges)
                {
                    Console.WriteLine(item.Key.ToString());
                }

                Console.WriteLine("Which badge would you like to edit?");
                int badge = Convert.ToInt32(Console.ReadLine());

                if (_allBadges.ContainsKey(badge))
                {
                    Console.WriteLine($"Badge {badge} has access to doors {string.Join(", ", _allBadges[badge])}.\n");
                    Console.WriteLine("1. Add a door \n" +
                        "2. Remove a door");
                    string r = Console.ReadLine();
                    Console.Clear();
                    bool moreDoors = true;

                    switch (r)
                    {
                        case "1":
                            while (moreDoors)
                            {
                                Console.WriteLine("What door accessible?");
                                string door = Console.ReadLine();
                                _allBadges[badge].Add(door);
                                Console.WriteLine("\nMore doors?");
                                string response = Console.ReadLine().ToLower();

                                if (response == "n" || response == "no")
                                {
                                    moreDoors = false;
                                }
                                else if (response != "y" && response != "yes")
                                {
                                    Console.WriteLine("\nPlease enter [y] or [n]");
                                }
                            }
                            break;

                        case "2":
                            while (moreDoors)
                            {
                                Console.WriteLine($"Badge {badge} has access to doors {string.Join(", ", _allBadges[badge])}.\n");
                                Console.WriteLine("What door would you like to remove?");
                                string door = Console.ReadLine();
                                _allBadges[badge].Remove(door);
                                Console.WriteLine("\nMore doors?");
                                string response = Console.ReadLine().ToLower();

                                if (response == "n" || response == "no")
                                {
                                    moreDoors = false;
                                }
                                else if (response != "y" && response != "yes")
                                {
                                    Console.WriteLine("\nPlease enter [y] or [n]");
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("Please enter a valid option.");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("That badge number does not exist. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Currently there are no badges in the system.\n" +
                    "Press any key to return to the main menu");
                Console.ReadLine();
            }
            Console.Clear();
        }
    }
}
