using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections__Delegate
{
    internal class Word : IPrintable
    {
        public void Print()
        {
            Console.WriteLine("Word was printed");
        }
    }
}
