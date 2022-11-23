using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Abstract__Interface
{
    internal class AK47:Gun
    {
        public override void Reload()
        {
            Console.WriteLine("AK47 is reloading");
            Thread.Sleep(1000);
            Console.WriteLine("AK47 is reloaded after 1 second");
        }
    }
}
