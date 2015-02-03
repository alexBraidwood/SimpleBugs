namespace SimpleBugs.Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NUnit.Framework;

    [TestFixture]
    public class SimpleBugsTest
    {
        [Test]
        public void PassingTest()
        {

        }

        [Test]
        int Add(int x, int y)
        {
            return x + y;
        }
    }
}
