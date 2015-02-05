using System.Data;

namespace SimpleBugs.Models
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Runtime.CompilerServices;
    using SimpleBugs.Interfaces;
    using SimpleBugs.DAL;

    public class BugTicket : BugObjectBase<BugTicket>
    {
        /// <summary>
        /// 
        /// </summary>
        private int userId;

        /// <summary>
        /// 
        /// </summary>
        public string UserName { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime DateInformation { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public BugTicket(SimpleBugContext contextBug)
        {
            this.UserName = Environment.UserName.ToString();
            this.DateInformation = DateTime.Now;
        }

        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// 
        /// </summary>
        public string TableName
        {
            get { throw new NotImplementedException(); }
        }
    }
}
