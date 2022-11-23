using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Abstract__Interface
{
    internal class Teacher : Employee,IMentalable
    {
        public string Profession;

        
        public byte IQ { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Breath()
        {
            throw new NotImplementedException();
        }

        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public override void GetPaid()
        {
            throw new NotImplementedException();
        }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}
