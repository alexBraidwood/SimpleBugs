﻿using SimpleBugs.Models;

namespace SimpleBugsConsoleTest
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
            BugTicket test = new BugTicket();

            Console.WriteLine(test.UserName);
            Console.WriteLine(test.DateInformation);
            Console.ReadLine();
        }
    }
}
