using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafe
{
    class MenuRepo
    {
        List<Menu> _menu = new List<Menu>();
        public void CreateMenuItem()
        {
            Console.Clear();
            int num = _menu.Count + 1;
            Console.WriteLine("What is the name of the item you wish to add?");
            string name = Console.ReadLine();

            Console.WriteLine("\nBriefly describe the menu item: ");
            string desc = Console.ReadLine();

            Console.WriteLine("\nPlease enter the list of ingredients:");
            string ingred = Console.ReadLine();

            bool priceInt = false;
            double cost = 0;
            while (!priceInt)
            {
                Console.WriteLine("\nWhat is the price for this item?");
                string response = Console.ReadLine();
                if (double.TryParse(response, out cost))
                {
                    cost = Convert.ToDouble(response);
                    priceInt = true;
                }
                else
                {
                    Console.WriteLine("\nPlease enter a dollar amount.");
                }
            }

            Menu newItem = new Menu(num, name, desc, ingred, cost);
            _menu.Add(newItem);
            Console.Clear();
            Console.WriteLine("Your item has been added to the menu.\n" +
                "Press any key to return to the main menu.");
            Console.ReadLine();
            Console.Clear();
        }
        public void ViewAllMenuItems()
        {
            Console.Clear();
            if (_menu.Count > 0)
            {
                foreach (Menu item in _menu)
                {
                    Console.WriteLine($"{item.mealNumber} - {item.mealName}");
                }
                Console.WriteLine("\n\nPress any key to return to the main menu.");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("There are currently no menu items to view.\n" +
                    "Press any key to return to the main menu.");
                Console.ReadLine();
                Console.Clear();
            }
        }

        // TODO why won't this delete work?.......
        public void DeleteMenuItem()
        {
            Console.Clear();
            if (_menu.Count > 0)
            {
                bool finished = false;
                while (!finished)
                {
                    for (int i = 0; i < _menu.Count; i++)
                    {
                        Console.WriteLine($"Number {_menu[i].mealNumber}: {_menu[i].mealName} \n");
                    }
                    int r = Convert.ToInt32(Console.ReadLine());
                    int indexToDelete = r - 1;
                    _menu.RemoveAt(indexToDelete);
                    finished = true;
                    Console.WriteLine("Your item has been removed from the menu.\n" +
                        "Press any key to return to the main menu.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("There are currently no menu items to view.\n" +
                    "Press any key to return to the main menu.");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
