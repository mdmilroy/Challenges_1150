using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoBadges
{
    public class Badges
    {
        public int badgeID;
        public List<string> badgeAccess;

        public Badges(int id, List<string> doors)
        {
            badgeID = id;
            badgeAccess = doors;
        }
    }
}
