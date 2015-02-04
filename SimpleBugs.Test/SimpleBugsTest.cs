using System.Security.Cryptography.X509Certificates;
using SimpleBugs.Models;

namespace SimpleBugs.Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NUnit.Framework;
    using SimpleBugs;

    [TestFixture]
    public class SimpleBugsTest
    {
        [Test]
        public void TicketUserName()
        {
            BugTicket ticket = new BugTicket();

            StringAssert.IsMatch("Nicholas", ticket.UserName.ToString());
        }

        [Test]
        public void TicketDateTime()
        {
            BugTicket ticket = new BugTicket();
            StringAssert.IsMatch(DateTime.Now.ToString(), ticket.DateInformation.ToString());
        }

        public void TicketDbConnection()
        {
            BugTicket ticket = new BugTicket();
            
        }
    }
}
