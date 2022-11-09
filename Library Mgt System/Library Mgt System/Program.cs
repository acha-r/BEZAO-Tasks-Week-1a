using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Mgt_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
               $"Hi\nMake a choice from the options below to view available books\n" +
               $"c: \n" +
               $"o: \n" +
               $"d: \n" +
               $"e: ");
            
            Console.Write("Your Choice: ");
            string userChoice = Console.ReadLine();
            string userChoiceAgain = userChoice.ToLower();

            switch (userChoiceAgain)
            {
                case "c":
                    Console.WriteLine("You get C# Books");
                    break;
                case "o":
                    Console.WriteLine("You get .NET Core Books");
                    break;
                case "d":
                    Console.WriteLine("You get Clean Coding Books");
                    break;
                case "e":
                    Console.WriteLine("You get EF Core Books");
                    break;
                    default:
                    Console.WriteLine("You can read, right?\nTry again");
                    
                    break;

            }
            



        }
    }
}
