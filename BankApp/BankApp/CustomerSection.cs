using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Views;

namespace BankApp
{
    class CustomerSection
    {
        public CustomerSection()
        {
            BankMenu();
        }

        private void BankMenu()
        {
            string choice = null;
            CustomerView customerView = new CustomerView();

            string msg = "";
            do
            {
                choice = UserInterface();

                switch (choice.ToUpper())
                {
                    case "C":
                        customerView.Create();
                        msg = "\n----------------------------> \nPress Enter to continue!";
                        break;
                    case "R":
                        customerView.Read();
                        msg = "\n----------------------------> \nPress Enter to continue!";
                        break;
                    case "U":
                        customerView.Update();
                        msg = "\n---------------------------->! \nPress Enter to continue!";
                        break;
                    case "D":
                        customerView.Delete();
                        msg = "\n---------------------------->! \nPress Enter to continue!";
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
            } while (choice.ToUpper() != "X");
        }

        static string UserInterface()
        {
            Console.Clear();
            Console.WriteLine("BankApp\nCustomer section");
            Console.WriteLine("[C] Create");
            Console.WriteLine("[R] Read");
            Console.WriteLine("[U] Update");
            Console.WriteLine("[D] Delete");
            Console.WriteLine("[X] Close Customer");
            Console.Write("\nChoose procedure: ");

            return Console.ReadLine();
        }
    }
}
