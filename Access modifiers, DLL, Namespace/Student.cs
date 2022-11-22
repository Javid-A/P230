using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_modifiers__DLL__Namespace
{
    internal class Student:Human
    {
        public byte Grade;
        public Student()
        {
            Name = "protected";
            Surname = "public";
        }
    }
}
