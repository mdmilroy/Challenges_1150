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
                Console.WriteLine("\nWhat door accessible?");
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
                Console.Clear();
                Console.WriteLine($"You have successfully created badge number {newBadge.badgeID.ToString()}" +
                    $" with access to doors {newBadge.badgeAccess.ToString()}");
            }
            else
            {
                Console.WriteLine("Your badge creation was unsuccessful. Please try again.");
            }

            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
