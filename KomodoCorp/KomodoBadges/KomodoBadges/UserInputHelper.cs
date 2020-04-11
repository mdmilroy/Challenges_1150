using KomodoBadges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoBadges
{
    public class UserInputHelper
    {
        public Badges GetBadgeToCreate()
        {
            Badges badgeToCreate = new Badges();
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
            badgeToCreate.badgeID = idnum;
            badgeToCreate.badgeAccess = access;
            return badgeToCreate;
        }
    }
}
