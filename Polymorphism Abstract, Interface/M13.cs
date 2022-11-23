using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Abstract__Interface
{
    internal class M13 : Gun
    {
        public void Reload()
        {
            Console.WriteLine("M13 is reloading");
            Thread.Sleep(2000);
            Console.WriteLine("M13 is reloaded after 1 second");
        }
    }
}
