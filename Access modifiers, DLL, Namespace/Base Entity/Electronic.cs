using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_modifiers__DLL__Namespace.Base_Entity
{
    internal class Electronic
    {
        string _id;
        public string Brand;
        public string Model;
        public string Size;
        double _price;
        byte _discount;
        //camera.Id = 17ahf-kja8f;
        public string Id
        {
            get { return _id; }

            set
            {
                if (value.Length == 11 && value.Contains('-'))
                {
                    _id = value;
                }
            }
        }

        public byte Discount
        {
            get
            {
                return _discount;
            }
            set
            {
                if(value>=0 && value <= 100)
                {
                    _discount = value;
                }
                else
                {
                    _discount = default;
                }
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (Discount > 0)
                {
                    _price = value * (100 - Discount) / 100;
                }
                else
                {
                    _price = value;
                }
            }
        }


        public Electronic(string id, string brand, string model, string size, double price, byte discount = 0)
        {
            Id = id;
            Brand = brand;
            Model = model;
            Size = size;
            Discount = discount;
            Price = price;
        }


        public void ShowInfo()
        {
            if (Discount > 0)
            {
                Console.WriteLine($"Id: {_id}, Brand: {Brand}, Model: {Model}, Price: Endirimli qiymet: {_price}");
            }
            else
            {
                Console.WriteLine($"Id: {_id}, Brand: {Brand}, Model: {Model}, Price: {_price}");
            }
        }
    }
}
