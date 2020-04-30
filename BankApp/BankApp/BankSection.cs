using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Views;

namespace BankApp
{
    class BankSection
    {
        public BankSection()
        {
            BankMenu();
        }

        private void BankMenu()
        {
            string choice = null;
            BankView bankView = new BankView();

            string msg = "";
            do
            {
                choice = UserInterface();

                switch (choice.ToUpper())
                {
                    case "C":
                        bankView.Create();
                        msg = "\n----------------------------> \nPress a key to continue!";
                        break;
                    case "R":
                        bankView.Read();
                        msg = "\n----------------------------> \nPress a key to continue!";
                        break;
                    case "U":
                        bankView.Update();
                        msg = "\n---------------------------->! \nPress a key to continue!";
                        break;
                    case "D":
                        bankView.Delete();
                        msg = "\n---------------------------->! \nPress a key to continue!";
                        break;
                    case "X":
                        msg = "\nChanging to main menu\nPress a key to continue";
                        break;
                    default:
                        msg = "Error occured - Press Enter and start over!";
                        break;
                }
                Console.WriteLine(msg);
                Console.ReadKey();
            }
            while (choice.ToUpper() != "X");
        }

        static string UserInterface()
        {
            Console.Clear();
            Console.WriteLine("BankApp\nBank section");
            Console.WriteLine("[C] Create");
            Console.WriteLine("[R] Read");
            Console.WriteLine("[U] Update");
            Console.WriteLine("[D] Delete");
            Console.WriteLine("[X] Close Bank");
            Console.Write("\nChoose procedure: ");

            return Console.ReadLine();
        }
    }
}
