using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Abstract__Interface
{
    internal abstract class Human
    {
        public string Firstname;
        public string Lastname;
        protected byte _iq;

        public abstract void Eat();
        public abstract void Breath();

        public void Sleep()
        {
            Console.WriteLine("8 hours");
        }
    }
}
