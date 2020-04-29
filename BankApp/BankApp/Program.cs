using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = null;

            string msg = "";
            do
            {
                choice = UserInterface();

                switch (choice.ToUpper())
                {
                    case "B":
                        BankSection bank = new BankSection();
                        msg = "\n----------------------------> \nPress Enter to continue!";
                        break;
                    case "C":
                        CustomerSection customer = new CustomerSection();
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

        static string UserInterface()
        {
            Console.Clear();
            Console.WriteLine("BankApp\nConfigure Bank on Bank section and Customer on Customer section");
            Console.WriteLine("[B] Bank section");
            Console.WriteLine("[C] Customer section");
            Console.WriteLine("[X] End Program");
            Console.Write("\nChoose procedure: ");

            return Console.ReadLine();
        }
    }
}
