using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance__Access_modifiers
{
    internal class Computer
    {
        public string Brand;
        public string Model;
        public double Price;
        public byte Ram;
        public string Memory;
        //private string Code;
        string _code;
        public int Test { get; set; }
        public string Code
        {
            get
            {
                return _code;
            }
            set
            {
                if (value.Length>13)
                {
                    _code = value;
                }
                else
                {
                    _code = "error";
                }
            }
        }
        public Computer(string brand, string model, double price, byte ram, string memory, string code)
        {
            Brand = brand;
            Model = model;
            Price = price;
            Ram = ram;
            Memory = memory;
            Code = code;
        }

        //public string ShowCode()
        //{
        //    return Code;
        //}


        ///// <summary>
        ///// Please assign value at least 13 character
        ///// </summary>
        ///// <param name="code">Code value</param>
        //public void ChangeCode(string code)
        //{
        //    if (code.Length > 13)
        //    {
        //        Code = code;
        //    }
        //}
    }
}
