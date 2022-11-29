using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic__Collections
{
    internal class Product<T>
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public T Quality { get; set; }

        public Product()
        {

        }
        public Product(T quality)
        {
            Quality = quality;
        }
    }
}
