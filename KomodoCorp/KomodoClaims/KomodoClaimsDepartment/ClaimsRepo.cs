using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoClaimsDepartment
{
    public class ClaimsRepo
    {
        int cid;
        List<Claim> _claims = new List<Claim>();
        List<Claim> _claimsHandled = new List<Claim>();

        public void ViewAllClaims()
        {
            if (_claims.Count < 1)
            {
                Console.WriteLine("There are no claims to view at this time.\n" +
                    "Press enter to return to the main menu.");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine(String.Format("{0, -15} {1, -15} {2, -15} {3, -15} {4, -15} {5, -15} {6, -15}", "ClaimID", "ClaimType", "Description", "Amount", "DateOfAccident", "DateOfClaim", "IsValid"));
                foreach (Claim claim in _claims)
                {
                    Console.WriteLine(String.Format("{0, -15} {1, -15} {2, -15} {3, -15} {4, -15} {5, -15} {6, -15}", claim.ClaimID, claim.ClaimType, claim.Description, claim.Amount, claim.DateOfAccident.ToString("MM/dd/yyyy"), claim.DateOfClaim.ToString("MM/dd/yyyy"), claim.IsValid));
                }
                Console.WriteLine("\nPress enter to return to the main menu.");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public void HandleNextClaim()
        {
            if (_claims.Count == 0)
            {
                Console.WriteLine("There are no claims to handle at this time.\n" +
                    "Press enter to return to the main menu.");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Claim nextClaim = _claims[0];
                Console.WriteLine("Here are the details of the next claim to be handled:\n" +
                    $"ClaimID: {nextClaim.ClaimID}\n" +
                    $"ClaimType: {nextClaim.ClaimType}\n" +
                    $"Description: {nextClaim.Description}\n" +
                    $"Ammount: ${nextClaim.Amount}\n" +
                    $"DateOfAccident: {nextClaim.DateOfAccident.ToString("MM/dd/yyyy")}\n" +
                    $"DateOfClaim: {nextClaim.DateOfClaim.ToString("MM/dd/yyyy")}\n" +
                    $"IsValid: {nextClaim.IsValid}\n\n");
                Console.WriteLine("Would you like to deal with this claim now [y / n]?");
                string response = Console.ReadLine();
                if (response == "y")
                {
                    _claimsHandled.Add(nextClaim);
                    Console.WriteLine("Your claim has been handled");
                    _claims.Remove(nextClaim);
                    Console.Clear();
                }
                else if (response == "n")
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Please enter an available option.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        public void CreateNewClaim()
        {
            cid++;
            string type = "undetermined";
            string descr;
            double amt = 0;
            DateTime accident = new DateTime();
            DateTime claimed = new DateTime();
            bool validity = false;



            Console.WriteLine("What is the type of claim you are creating?\n" +
                "1. Car\n" +
                "2. House\n" +
                "3. Theft\n");
            string response = Console.ReadLine();
            switch (response)
            {
                case "1":
                    type = "Car";
                    break;
                case "2":
                    type = "House";
                    break;
                case "3":
                    type = "Theft";
                    break;
                default:
                    Console.WriteLine("Please choose one of the given options.");
                    break;
            }

            Console.WriteLine("\nPlease describe the claim.");
            descr = Console.ReadLine();

            Console.WriteLine("\nWhat is the amount of the claim?");

            //amt = Convert.ToDouble(Console.ReadLine());
            bool valid = false;
            while (!valid)
            {
                if (Double.TryParse(Console.ReadLine(), out amt))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Please enter a numerical amount.");
                }
            }

            bool validAccident = false;
            while (!validAccident)
            {
                Console.WriteLine("\nWhen did the accident occur? (Please use MM, DD, YYYY format.)");
                if (DateTime.TryParse(Console.ReadLine(), out accident))
                {
                    validAccident = true;
                }
                else
                {
                    Console.WriteLine("You have entered an invalid date format.");
                }
            }

            bool validClaim = false;
            while (!validClaim)
            {
                Console.WriteLine("\nWhen was the claim submitted? (Please use MM, DD, YYYY format.)");
                if (DateTime.TryParse(Console.ReadLine(), out claimed))
                {
                    validClaim = true;
                }
                else
                {
                    Console.WriteLine("You have entered an invalid date format.");
                }
            }

            bool validValid = false;
            while (!validValid)
            {
                Console.WriteLine("\nIs this claim valid [y/n]?");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "y":
                        validity = true;
                        validValid = true;
                        break;
                    case "n":
                        validity = false;
                        validValid = true;
                        break;
                    default:
                        Console.WriteLine("Please enter y or n.");
                        break;
                }
            }


            Claim claim = new Claim(cid, type, descr, amt, accident, claimed, validity);
            _claims.Add(claim);
            Console.WriteLine("Your claim has been added to the queue.");
            Console.ReadLine();
            Console.Clear();
        }

        public void ViewHandledClaims()
        {
            if (_claimsHandled.Count < 1)
            {
                Console.WriteLine("There are no handled claims to view at this time.\n" +
                    "Press enter to return to the main menu.");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine(String.Format("{0, -15} {1, -15} {2, -15} {3, -15} {4, -15} {5, -15} {6, -15}", "ClaimID", "ClaimType", "Description", "Amount", "DateOfAccident", "DateOfClaim", "IsValid"));
                foreach (Claim claim in _claimsHandled)
                {
                    Console.WriteLine(String.Format("{0, -15} {1, -15} {2, -15} {3, -15} {4, -15} {5, -15} {6, -15}", claim.ClaimID, claim.ClaimType, claim.Description, claim.Amount, claim.DateOfAccident.ToString("MM/dd/yyyy"), claim.DateOfClaim.ToString("MM/dd/yyyy"), claim.IsValid));
                }
                Console.WriteLine("\nPress enter to return to the main menu.");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
