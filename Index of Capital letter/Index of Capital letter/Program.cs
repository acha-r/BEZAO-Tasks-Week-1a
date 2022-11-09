using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Index_of_Capital_letter
{
    internal class Program
    {
       
        public static int[] CapitalIndex(string userInput)
        {
           int[] indexOfCapitalLetters = new int[userInput.Length];
          

            for (int i = 0; i < userInput.Length; i++)
            {
                if (Char.IsUpper(userInput[i]))
                {
                    indexOfCapitalLetters.Append(i);
                }
            }
           
            return indexOfCapitalLetters;         
            
        }
        static void Main()
        {
            Console.WriteLine("TypE sOmEThinG LikE ThiS");

            string userInput = Console.ReadLine();

           CapitalIndex(userInput);
           
           
        }
    }
}
