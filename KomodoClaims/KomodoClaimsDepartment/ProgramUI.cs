using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaimsDepartment
{
    public class ProgramUI
    {
        public void Run()
        {
            ClaimsRepo repo = new ClaimsRepo();
            bool claimsMenu = true;

            while (claimsMenu)
            {
                Console.WriteLine("Welecome to the main Claims Menu. Please select an option below:\n" +
                "1. See all claims\n" +
                "2. Take care of next claim\n" +
                "3. Enter a new claim\n" +
                "4. See all handled claims\n" +
                "5. Exit\n");

                string response = Console.ReadLine();
                Console.Clear();

                switch (response)
                {
                    case "1":
                        repo.ViewAllClaims();
                        break;
                    case "2":
                        repo.HandleNextClaim();
                        break;
                    case "3":
                        repo.CreateNewClaim();
                        break;
                    case "4":
                        repo.ViewHandledClaims();
                        break;
                    case "5":
                        claimsMenu = false;
                        break;
                    default:
                        Console.WriteLine("Please select one of the given options.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
            Environment.Exit(0);
        }
    }
}
