namespace SimpleBugs.Test
{
    using SimpleBugs.DAL;
    using SimpleBugs.Models;
    using System;
    using NUnit.Framework;
    using System.Configuration;
    using System.Data.SqlClient;

    [TestFixture]
    public class SimpleBugsTest
    {
        [Test]
        public void TicketUserName()
        {
            //var configConnection = ConfigurationManager
            //    .ConnectionStrings["SimpleBugs"]
            //    .ConnectionString;
            SqlConnection db = new SqlConnection("Data Source=..\\SQLEXPRESS;Initial Catalog=SimpleBugs;Integrated Security=True");

            SimpleBugContext bugContext = new SimpleBugContext(db);

            BugTicket ticket = new BugTicket(bugContext);

            StringAssert.IsMatch(System.Environment.UserName.ToString(), ticket.UserName.ToString());
        }

        [Test]
        public void TicketDateTime()
        {
            SqlConnection db = new SqlConnection("Data Source=..\\SQLEXPRESS;Initial Catalog=SimpleBugs;Integrated Security=True");
            
            SimpleBugContext bugContext = new SimpleBugContext(db);

            BugTicket ticket = new BugTicket(bugContext);

            StringAssert.IsMatch(DateTime.Now.ToString(), ticket.DateInformation.ToString());
        }
    }
}
