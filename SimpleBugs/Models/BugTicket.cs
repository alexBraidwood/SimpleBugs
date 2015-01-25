namespace SimpleBugs.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BugTicket : Interfaces.ICreate, Interfaces.IResolve
    {
        public string UserName { get; set { value = Environment.UserName; } }

        public int CreateIdNumber
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int ResolveIdNumber
        {
            get { throw new NotImplementedException(); }
        }

        public string CreationInfo()
        {
            throw new NotImplementedException();
        }

        public string ResolveInfo()
        {
            throw new NotImplementedException();
        }
    }
}
