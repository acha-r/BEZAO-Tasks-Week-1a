﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public class User
        {
            public string Name { get; set; }    
            public string Password { get; set; }

        }
        static void Main(User user = null)
        {
            Console.WriteLine(user?.Name);
            Console.WriteLine(user?.Password);
        }
    }
}