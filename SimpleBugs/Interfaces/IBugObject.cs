using System.Collections;
using System.Collections.Generic;

namespace SimpleBugs.Interfaces {

    public interface IBugObject<T> where T : class {
        /// <summary>
        /// 
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        string TableName { get; }

        /// <summary>
        /// 
        /// </summary>
        IDictionary<string, dynamic> Mappings { get; }
    }
}
