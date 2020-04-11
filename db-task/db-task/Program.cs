using System;

namespace db_task
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = null;
            PersonView personView = new PersonView();

            string msg = "";
            do
            {
                choice = UserInterface();

                switch (choice.ToUpper())
                {
                    case "C":

                        //personView.CreatePerson();
                        msg = "\n----------------------------> \nPress Enter to continue!";
                        break;
                    case "R":
                        //personView.Read(5002);
                        //personView.PrintAll();
                        msg = "\n----------------------------> \nPress Enter to continue!";
                        break;
                    case "U":
                        //personView.UpdatePerson();
                        msg = "\n---------------------------->! \nPress Enter to continue!";
                        break;
                    case "D":
                        //personView.DeletePerson(5003);
                        msg = "\n---------------------------->! \nPress Enter to continue!";
                        break;
                    case "X":
                        msg = "\nProgram end!";
                        break;
                    default:
                        msg = "Error occured - Press Enter and start over!";
                        break;
                }

                Console.WriteLine(msg);
                Console.ReadLine();
                Console.Clear();
            }
            while (choice.ToUpper() != "X");
        }

        static string UserInterface()
        {
            Console.WriteLine("Database task 1!");
            Console.WriteLine("[C] Create");
            Console.WriteLine("[R] Read");
            Console.WriteLine("[U] Update");
            Console.WriteLine("[D] Delete");
            Console.WriteLine("[X] End Program");
            Console.WriteLine();
            Console.Write("Choose procedure: ");

            return Console.ReadLine();
        }
    }
}
