using System.Collections;
using System.Collections.Generic;

namespace SimpleBugs.Interfaces {

    public interface IBugObject<T> where T : class {
        int Id { get; set; }
        string TableName { get; }
        IDictionary<string, dynamic> Mappings { get; }
    }
}
