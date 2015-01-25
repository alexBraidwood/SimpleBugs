namespace SimpleBugs.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface ICreate
    {
        /// <summary>
        /// 
        /// </summary>
        int CreateIdNumber {get; set;}

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string CreationInfo();
    }
}
