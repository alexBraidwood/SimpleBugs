using System.Text;

namespace SimpleBugs.DAL {

    using System;
    using System.Data;
    using SimpleBugs.Interfaces;
    using Dapper;

    public class SimpleBugContext : ISimpleBugContext {

        public SimpleBugContext(IDbConnection connection) {
            if (connection == null)
                throw new Exception("Database connection required to use this constructor");
        }

        public IDbConnection Connection { get; set; }

        public void Insert<T>(IBugObject<T> item) where T : class {
            StringBuilder sb = new StringBuilder();
            int i = 0;
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

        public void Update<T>(IBugObject<T> item) where T : class {

        }

        public void Delete<T>(IBugObject<T> item) where T : class {

        }
    }
}
