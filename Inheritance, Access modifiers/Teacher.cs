using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance__Access_modifiers
{
    internal class Teacher:Person
    {
        public string Profession;
        public long Salary;

        public Teacher(string name, string surname, string gender, byte age, string profession, long salary) : base(name, surname, gender, age)
        {
            Profession = profession;
            Salary = salary;
        }
    }
}
