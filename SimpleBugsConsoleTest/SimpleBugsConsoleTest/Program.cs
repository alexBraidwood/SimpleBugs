﻿namespace SimpleBugsConsoleTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using SimpleBugs;

    class Program
    {
        static void Main(string[] args)
        {
            string test = SimpleBugs.Models.User.GetUserInformation();
            Console.WriteLine(test);
            Console.ReadLine();
        }
    }
}