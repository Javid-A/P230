using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections__Delegate
{
    internal class OnlineSheet : IPrintable
    {
        public string Type;
        public OnlineSheet(string type)
        {
            Type = type;
        }
        public void Print()
        {
            Console.WriteLine($"{Type} was printed");
        }
    }
}
