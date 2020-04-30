using System;
using System.Collections.Generic;
using System.Text;
using BankApp.Views;

namespace BankApp
{
    class CustomerSection
    {
        CustomerView customerView = new CustomerView();
        AccountView accountView = new AccountView();
        TransactionView transactionView = new TransactionView();
        public CustomerSection()
        {
            BankMenu();
        }

        private void BankMenu()
        {
            string choice = null;

            string msg = "";
            do
            {
                choice = UserInterface(1);

                switch (choice.ToUpper())
                {
                    case "C":
                        Create();
                        msg = "\n----------------------------> \nPress Enter to continue!";
                        break;
                    case "R":
                        Read();
                        msg = "\n----------------------------> \nPress Enter to continue!";
                        break;
                    case "U":
                        Update();
                        msg = "\n---------------------------->! \nPress Enter to continue!";
                        break;
                    case "D":
                        Delete();
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

        static string UserInterface(int caller)
        {
            Console.Clear();
            if (caller == 1)
            {
                Console.WriteLine("BankApp\nCustomer section");
                Console.WriteLine("[C] Create");
                Console.WriteLine("[R] Read");
                Console.WriteLine("[U] Update");
                Console.WriteLine("[D] Delete");
                Console.WriteLine("[X] Close customer section");
                Console.Write("\nChoose procedure: ");
            }
            else if (caller == 2)
            {
                Console.WriteLine("BankApp\nCustomer section\nCreate");
                Console.WriteLine("[1] Create User");
                Console.WriteLine("[2] Create Account");
                Console.WriteLine("[3] Create Transaction");
                Console.WriteLine("[X] Close creation");
                Console.Write("\nChoose procedure: ");
            }
            else if (caller == 3)
            {
                Console.WriteLine("BankApp\nCustomer section\nRead");
                Console.WriteLine("[1] Print accounts by bank");
                Console.WriteLine("[2] Print customers by bank");
                Console.WriteLine("[3] Show account information by customer");
                Console.WriteLine("[4] Show customer's transactions");
                Console.WriteLine("[X] Close reading");
                Console.Write("\nChoose procedure: ");
            }
            else if (caller == 4)
            {
                Console.WriteLine("BankApp\nCustomer section\nDelete");
                Console.WriteLine("[1] Delete User");
                Console.WriteLine("[2] Delete Transaction");
                Console.WriteLine("[X] Close deleting");
                Console.Write("\nChoose procedure: ");
            }
            else
            {
                Console.WriteLine("This should not happen");
            }

            return Console.ReadLine();
        }

        private void Create()
        {
            string choice = null;

            string msg = "";
            do
            {
                choice = UserInterface(2);

                switch (choice.ToUpper())
                {
                    case "1":
                        customerView.Create();
                        accountView.Create();
                        msg = "\n----------------------------> \nPress Enter to continue!";
                        break;
                    case "2":
                        accountView.Create();
                        msg = "\n----------------------------> \nPress Enter to continue!";
                        break;
                    case "3":
                        transactionView.Create();
                        msg = "\n----------------------------> \nPress Enter to continue!";
                        break;
                    case "X":
                        msg = "\nBye bye!";
                        break;
                    default:
                        msg = "Error occured - Press Enter and start over!";
                        break;
                }
                Console.WriteLine(msg);
            }
            while (choice.ToUpper() != "X");
        }

        private void Read()
        {
            string choice = null;

            string msg = "";
            do
            {
                choice = UserInterface(3);

                switch (choice.ToUpper())
                {
                    case "1":
                        customerView.Create();
                        accountView.Create();
                        msg = "\n----------------------------> \nPress Enter to continue!";
                        break;
                    case "2":
                        transactionView.Create();
                        msg = "\n----------------------------> \nPress Enter to continue!";
                        break;
                    case "X":
                        msg = "\nBye bye!";
                        break;
                    default:
                        msg = "Error occured - Press Enter and start over!";
                        break;
                }
                Console.WriteLine(msg);
            }
            while (choice.ToUpper() != "X");
        }

        private void Update()
        {
            // update a customer's info
        }

        private void Delete()
        {
            string choice = null;

            string msg = "";
            do
            {
                choice = UserInterface(4);

                switch (choice.ToUpper())
                {
                    case "1":
                        customerView.Create();
                        accountView.Create();
                        msg = "\n----------------------------> \nPress Enter to continue!";
                        break;
                    case "2":
                        transactionView.Create();
                        msg = "\n----------------------------> \nPress Enter to continue!";
                        break;
                    case "X":
                        msg = "\nBye bye!";
                        break;
                    default:
                        msg = "Error occured - Press Enter and start over!";
                        break;
                }
                Console.WriteLine(msg);
            }
            while (choice.ToUpper() != "X");
        }
    }
}
