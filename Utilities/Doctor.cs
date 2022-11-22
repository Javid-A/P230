using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Doctor:Human
    {
        public string Profession;
        internal string Surname;
        private protected string DoctorProtected;
        public Doctor()
        {
            //Human human = new Human();
            //HumanProtected
            Human human = new Human();
            human.HumanProtectedInternal = "protected internal";
            Console.WriteLine();
        }
    }
}
