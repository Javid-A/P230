using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections__Delegate
{
    internal class PDF : IPrintable
    {
        public void Print()
        {
            Console.WriteLine("PDF was printed");
        }

        public override string ToString()
        {
            return "PDF";
        }
    }
}
