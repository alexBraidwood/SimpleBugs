using System.Data;

namespace SimpleBugs.Interfaces {

    public interface ISimpleBugContext {

        IDbConnection Connection { set; }
        void Insert<T>(IBugObject<T> item) where T : class;
        void Update<T>(IBugObject<T> item) where T : class;
        void Delete<T>(IBugObject<T> item) where T : class;
    }
}
