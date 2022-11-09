using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Authentication
{
    internal class Program
    {
        public class Registration
        {
            public Registration()
            {
                Console.WriteLine("Hi newbie, fill in the following");

                Console.Write("Full Name:");
                string fullName = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Username:");
                string userName = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Set a password:");
                string password = Console.ReadLine();
                Console.WriteLine();

            }

        }

        public class LogIn
        {
            public LogIn()
            {
                Console.WriteLine("You're back");

                Console.Write("Your username: ");
                string userName = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Password here: ");
                string password = Console.ReadLine();
                Console.WriteLine();

            }
        }
        static void Main()
        {
            Console.WriteLine("Press 1 to register. Press 2 to log in");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int oneOrTwo))
            {
                if (oneOrTwo == 1)
                {
                    Registration newUser = new Registration();
                    Console.WriteLine("Welcome! That's all for now");

                }
                else if (oneOrTwo == 2)
                {
                    LogIn existringUser = new LogIn();
                    Console.WriteLine("Awkward silence");
                }
                else { 
                Console.WriteLine("I said ");
                Main();
            }
            }
            else Console.WriteLine("I said press 1 OR 2");
        }
    }
}
