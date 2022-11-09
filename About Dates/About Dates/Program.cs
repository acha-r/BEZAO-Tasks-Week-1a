using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace About_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter date (dd/mm/yyyy)");
            string dateEnteree = Console.ReadLine();
            DateTime actualDateEntered = DateTime.Parse(dateEnteree);
            DateTime oneWeekFromDateEntered = actualDateEntered.AddDays(7);
            Console.WriteLine($"One week from your date is {oneWeekFromDateEntered}");
        }
    }
}
