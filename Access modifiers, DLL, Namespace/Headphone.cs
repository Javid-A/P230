using Access_modifiers__DLL__Namespace.Base_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_modifiers__DLL__Namespace
{
    internal class Headphone:Electronic
    {
        public string Battery;
        public double Bluetooth;

        public Headphone(string id, string brand, string model, string size, double price, string battery, double bluetooth, byte discount = 0) : base(id,brand,model,size,price,discount)
        {
            Battery = battery;
            Bluetooth = bluetooth;
        }
        public void ShowBatteryAndBluetooth()
        {
            Console.WriteLine($"Battery: {Battery}, Bluetooth: {Bluetooth}");
        }
    }
}
