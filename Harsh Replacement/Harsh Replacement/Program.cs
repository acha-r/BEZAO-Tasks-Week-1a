using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harsh_Replacement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word");

            string userInput = Console.ReadLine();
            
            int length = userInput.Length;
            var hashReplacement = new String('#', length - 4) + userInput.Substring(length - 4);

            Console.WriteLine(hashReplacement);


        }
    }
}
