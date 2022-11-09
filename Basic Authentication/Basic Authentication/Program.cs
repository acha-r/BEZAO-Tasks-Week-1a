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
            string userName;
            string password;
            public Registration()
            {
                Console.WriteLine("Hi newbie, fill in the following");

                Console.Write("Full Name:");
                string fullName = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Username:");
                userName = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Set a password:");
                password = Console.ReadLine();
                Console.WriteLine();


            }

            public void LogIn()
            {
                Console.WriteLine("Log in");

                Console.Write("Your username: ");
                string lUserName = Console.ReadLine();
                if (lUserName == userName)
                {
                    Console.Write("Password here: ");
                    string lPassword = Console.ReadLine();
                    if (lPassword != password)
                    {
                        Console.Write("Invalid password. Try again");
                        Console.WriteLine();
                        LogIn();
                    } else Console.WriteLine("That's all");

                }
                
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
                    Console.WriteLine("Welcome! Log in with your details");
                    newUser.LogIn();

                } else if (oneOrTwo == 2)
                {
                    Console.WriteLine("I'm sorry, this is currently unavailable");
                }
           
            }
            else Console.WriteLine("I said press 1 OR 2");
        }
    }
}
