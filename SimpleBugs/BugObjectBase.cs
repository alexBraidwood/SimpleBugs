namespace SimpleBugs {
    using System.Collections.Concurrent;
    using SimpleBugs.Interfaces;
    using System.Collections.Generic;

    /// <summary>
    /// Base Class for Bug Objects
    /// </summary>
    /// <typeparam name="T">Object Type</typeparam>
    public class BugObjectBase<T> : IBugObject<T> where T : class {
        /// <summary>
        /// 
        /// </summary>
        private IDictionary<string, dynamic> mappings; 

        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Table Name for Object
        /// </summary>
        public virtual string TableName { get; protected set; }

        /// <summary>
        /// Database Mappings in the form <Column Name, Value>
        /// </summary>
        public virtual IDictionary<string, dynamic> Mappings {
            get {
                if (mappings == null) {
                    mappings = new ConcurrentDictionary<string, dynamic>();
                }
                return mappings;;
            }
            protected set { mappings = value; }
        }

    }
}
