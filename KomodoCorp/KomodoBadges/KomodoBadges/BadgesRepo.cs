using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoBadges
{
    public class BadgesRepo
    {
        private List<Badges> _badges = new List<Badges>();
        private Dictionary<int, List<string>> allBadges = new Dictionary<int, List<string>>();

        public void CreateBadge()
        {
            Console.Clear();
            Random randID = new Random();
            int idnum = randID.Next(1000, 10000);
            List<string> access = new List<string>();
            bool moreDoors = true;

            while(moreDoors)
            {
                Console.WriteLine("What door accessible?");
                string doors = Console.ReadLine();
                access.Add(doors);
                Console.WriteLine("\nMore doors?");
                string r = Console.ReadLine().ToLower();

                if (r == "n" || r == "no")
                {
                    moreDoors = false;
                }
                else if (r != "y" && r != "yes")
                {
                    Console.WriteLine("\nPlease enter [y] or [n]");
                }
            }
            Badges newBadge = new Badges(idnum, access);
            allBadges.Add(newBadge.badgeID, newBadge.badgeAccess);
            
            if (allBadges.ContainsKey(newBadge.badgeID))
            {
                // TODO: CANNOT GET THIS TO PRINT LIST OF ACCESS DOORS; IT PRINTS THE OBJECT.GETTYPE
                Console.Clear();
                Console.WriteLine($"You have successfully created badge number {newBadge.badgeID.ToString()}" +
                    $" with access to doors {string.Join(", ", newBadge.badgeAccess)}");
            }
            else
            {
                Console.WriteLine("Your badge creation was unsuccessful. Please try again.");
            }

            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadLine();
            Console.Clear();
        }
    
        public Dictionary<int, List<string>> ViewAllBadges()
        {
            Console.Clear();
            if (allBadges.Count > 0)
            {
                Console.WriteLine("{0, -15} {1, -10}", "Badge", "Access");
                foreach (KeyValuePair<int, List<string>> item in allBadges)
                {
                    // TRIED TO CONVERT TO ARRAY IN ORDER TO PRINT EACH ACCESS LIST ITEM... FAILED...
                    // This finally worked!!! I misunderstood the default ToString() behavior.
                    Console.WriteLine("{0, -15} {1, -10}", item.Key.ToString(), string.Join(", ", item.Value));
                }
                Console.WriteLine("Press any key to return to the main menu");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Currently there are no badges in the system.\n" +
                    "Press any key to return to the main menu");
                Console.ReadLine();
            }
            Console.Clear();
            return allBadges;
        }

        public void EditBadge()
        {
            Console.Clear();
            if (allBadges.Count > 0)
            {
                Console.WriteLine("{0, -15}", "Badge");
                foreach (KeyValuePair<int, List<string>> item in allBadges)
                {
                    Console.WriteLine(item.Key.ToString());
                }

                Console.WriteLine("Which badge would you like to edit?");
                int badge = Convert.ToInt32(Console.ReadLine());

                if (allBadges.ContainsKey(badge))
                {
                    Console.WriteLine($"Badge {badge} has access to doors {string.Join(", ", allBadges[badge])}.\n");
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
                                allBadges[badge].Add(door);
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
                                Console.WriteLine($"Badge {badge} has access to doors {string.Join(", ", allBadges[badge])}.\n");
                                Console.WriteLine("What door would you like to remove?");
                                string door = Console.ReadLine();
                                allBadges[badge].Remove(door);
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
