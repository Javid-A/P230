using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder__Class
{
    internal class House
    { 
        public byte Room;
        public short SquareMeter;
        public byte Floor;
        public int MonthlyRentPrice;
        public string Address;
        public bool IsRented;

        public House()
        {
        }
        public House(byte room)
        {

        }
        public House(byte room, short squaremeter, byte floor, int monthlyRentPrice, string address, bool isRented)
        {
            Room = room;
            SquareMeter = squaremeter;
            Floor = floor;
            MonthlyRentPrice = monthlyRentPrice;
            Address = address;
            IsRented = isRented;
        }

      
        public void Rented()
        {
            if (IsRented)
            {
                Console.WriteLine("This house has been already rented");
            }
            else
            {
                Console.WriteLine("You can rent this house");
            }
        }
    }
}
