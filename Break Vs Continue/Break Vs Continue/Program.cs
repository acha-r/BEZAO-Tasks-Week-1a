using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_Vs_Continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number less than 11");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int result))
            {
                for (int i = 0; i <= result; i++)
                {
                    if (i % 2 == 0)
                        continue;
                    if (i >= 11)
                        break;
                    Console.WriteLine(i);
                }
            } else
            {
                Console.WriteLine("This is not a number");
            }
        }
    }
}
