namespace SimpleBugs.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Runtime.CompilerServices;
    using SimpleBugs.Interfaces;


    public class BugTicket : ICreate, IResolve
    {
        public string UserName { get; private set; }
        public DateTime DateInformation { get; private set; }

        public BugTicket()
        {
            this.UserName = Environment.UserName.ToString();
            this.DateInformation = DateTime.Now;
        }

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
