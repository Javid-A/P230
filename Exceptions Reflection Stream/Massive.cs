using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Reflection_Stream
{
    internal abstract class Massive
    {
        public string Name;
        public int Population;

        public Massive(string name, int population)
        {
            Name = name;
            Population = population;
        }
    }
}
