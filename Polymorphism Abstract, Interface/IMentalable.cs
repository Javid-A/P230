using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Abstract__Interface
{
    internal interface IMentalable:ITestable
    {
        byte IQ { get; set; }
    }
}
