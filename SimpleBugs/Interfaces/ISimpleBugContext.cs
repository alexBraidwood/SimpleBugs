namespace SimpleBugs.Interfaces {
    using System.Data;

    /// <summary>
    /// Interface for all SimpleBugContexts
    /// </summary>
    public interface ISimpleBugContext {
        /// <summary>
        /// 
        /// </summary>
        IDbConnection Connection { set; }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        void Insert<T>(IBugObject<T> item) where T : class;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        void Update<T>(IBugObject<T> item) where T : class;

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        void Delete<T>(IBugObject<T> item) where T : class;
    }
}
