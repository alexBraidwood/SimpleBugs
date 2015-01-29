using System.Text;

namespace SimpleBugs.DAL {

    using System;
    using System.Data;
    using SimpleBugs.Interfaces;
    using Dapper;

    /// <summary>
    /// Base Context for Simple Bug Data Interaction, Inherit for more specific implementations
    /// </summary>
    public class SimpleBugContext : ISimpleBugContext {

        /// <summary>
        /// Base Constructor
        /// </summary>
        /// <param name="connection">Db Connection for all interaction with class</param>
        public SimpleBugContext(IDbConnection connection) {
            if (connection == null)
                throw new Exception("Database connection required to use this constructor");
        }

        /// <summary>
        /// Db Connection for all interaction with class
        /// </summary>
        public IDbConnection Connection { get; set; }

        /// <summary>
        /// Inserts a BugObject into the Database / Store
        /// TODO (Alex): Currently doesn't handle partial column INSERT 
        /// </summary>
        /// <typeparam name="T">Type of Object to Insert</typeparam>
        /// <param name="item">Item to Insert</param>
        public void Insert<T>(IBugObject<T> item) where T : class {
            StringBuilder sb = new StringBuilder();
            int i = 0;

            // Build VALUES part of Sql statement
            foreach (var obj in item.Mappings.Keys) {
                ++i;
                sb.Append(item.Mappings[obj]);
                if (i < item.Mappings.Count) {
                    sb.Append(", ");
                }
            }

            Connection.Query<IBugObject<T>>("INSERT INTO %t VALUES %v",
                new { t = item.TableName, v = sb.ToString() });
        }

        /// <summary>
        /// Updates object that already exists in Database / Store
        /// </summary>
        /// <typeparam name="T">Type of Object to Update</typeparam>
        /// <param name="item">Object to Update</param>
        public void Update<T>(IBugObject<T> item) where T : class {


        }

        /// <summary>
        /// Deletes object from database
        /// </summary>
        /// <typeparam name="T">Type of Object to Delete</typeparam>
        /// <param name="item">Object to delete</param>
        public void Delete<T>(IBugObject<T> item) where T : class {

        }

        /// <summary>
        /// Checks to see if items already exist in database
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool BugExist<T>(IBugObject<T> item) where T : class {
            return false;
        }
    }
}
