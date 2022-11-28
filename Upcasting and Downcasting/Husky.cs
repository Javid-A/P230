using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_and_Downcasting
{
    internal class Husky : Dog, IShaveable
    {
        
        public override void Bark()
        {
            Console.WriteLine("Husky make sound");
        }

        public override void Eat()
        {
            Console.WriteLine("Fish");
        }

        public void Shave()
        {
            Console.WriteLine("Husky is shaved");
        }
    }
}
