using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafe
{
    class ProgramUI
    {
        public void Run()
        {
            MenuRepo _menu = new MenuRepo();
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine(
                    "Welcome to the Menu Management System.\n" +
                    "Please choose an option below:");
                Console.WriteLine(
                    "1. Create a menu item.\n" +
                    "2. Delete a menu item.\n" +
                    "3. View a list of all menu items.\n" +
                    "4. Exit.\n");
                string response = Console.ReadLine();
                switch (response)
                {
                    case "1":
                        _menu.CreateMenuItem();
                        break;
                    case "2":
                        _menu.DeleteMenuItem();
                        break;
                    case "3":
                        _menu.ViewAllMenuItems();
                        break;
                    case "4":
                        isRunning = false;
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please select a valid option.");
                        break;
                }
            }
        }
    }
}