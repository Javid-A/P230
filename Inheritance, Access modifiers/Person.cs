using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance__Access_modifiers
{
    internal class Person
    {
        public string Name;
        public string Surname;
        public string Gender;
        public byte Age;

        public Person(string name, string surname, string gender, byte age)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
            Age = age;
        }

        public string Fullname()
        {
            return $"{Name} {Surname}";
        }
    }
}
