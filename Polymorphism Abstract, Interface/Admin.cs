using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Abstract__Interface
{
    internal class Admin:User
    {
        public bool IsSuperAdmin;
        public string Section;

        public Admin(string username, string pw, string section, bool isSuperAdmin=false):base(username,pw)
        {
            Section = section;
            IsSuperAdmin = isSuperAdmin;
        }

        public void ShowAllInfos()
        {
            Console.WriteLine($"{Username}, {Password.GetHashCode()}, {Section}, {(IsSuperAdmin ? "Super admindir" : "Super admin deyil")}");
        }
    }
}
