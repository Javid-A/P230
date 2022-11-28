using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_and_Downcasting
{
    internal class LionFish : Fish
    {
        public string Poison;
        public override void Eat()
        {
            Console.WriteLine("Small fishs");
        }

        public override void Swim()
        {
            Console.WriteLine("Swimming process");
        }
    }
}
