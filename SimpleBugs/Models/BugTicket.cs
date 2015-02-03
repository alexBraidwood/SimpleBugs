﻿namespace SimpleBugs.Models
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
        private SimpleBugContext bugContext;

        /// <summary>
        /// 
        /// </summary>
        private int userId;

        private int ticketId;

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
        public BugTicket()
        {

            this.UserName = Environment.UserName.ToString();
            this.DateInformation = DateTime.Now;
            InitialBugInformation("SimpleBugs");
        }

        /// <summary>
        /// 
        /// TODO (Nick): Create database selection type for method 
        /// </summary>
        private void InitialBugInformation(string dataSource)
        {
            string configConnection = ConfigurationManager.ConnectionStrings[dataSource].ConnectionString;
            SqlConnection db = new SqlConnection(configConnection);

            bugContext = new SimpleBugContext(db);
            bugContext.Connection = db;

            if (bugContext.BugExist(this) == false)
            {
                bugContext.Insert(this);
            }
            else
            {
                bugContext.Update(this);
            }
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
