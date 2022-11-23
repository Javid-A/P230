using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Abstract__Interface
{
    internal class Gun
    {
        public virtual void Reload()
        {
            Console.WriteLine("Gun is reloading... test");

            Console.WriteLine("Gun is reloaded");
        }
    }
}
