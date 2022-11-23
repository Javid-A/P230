using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Abstract__Interface
{
    internal class Student : Human
    {
        public string GroupNo;
        public string Section;

      

        public override void Breath()
        {
            Console.WriteLine("0.5 second");
        }

        public override void Eat()
        {
            Console.WriteLine("Makaron bezen et");
        }
    }
}
