using System.Data;

namespace SimpleBugs.Interfaces {

    /// <summary>
    /// Interface for all SimpleBugContexts
    /// </summary>
    public interface ISimpleBugContext {

        IDbConnection Connection { set; }
        void Insert<T>(IBugObject<T> item) where T : class;
        void Update<T>(IBugObject<T> item) where T : class;
        void Delete<T>(IBugObject<T> item) where T : class;
    }
}
