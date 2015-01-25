namespace SimpleBugs.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class User
    {
        public static string GetUserInformation()
        {
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString();
            return userName;
        }
    }
}
