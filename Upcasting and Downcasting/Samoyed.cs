using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_and_Downcasting
{
    internal class Samoyed : Dog,IShaveable
    {
        public string Fur;
        public override void Bark()
        {
            Console.WriteLine("Samoyed makes sound");
        }

        public override void Eat()
        {
            Console.WriteLine("Pedigree");
        }

        public void Shave()
        {
            Fur = "Shaved";
            Console.WriteLine("Samoyed is shaved");
        }
    }
}
