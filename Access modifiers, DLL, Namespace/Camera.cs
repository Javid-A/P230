using Access_modifiers__DLL__Namespace.Base_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_modifiers__DLL__Namespace
{
    internal class Camera:Electronic
    {
        public string TotalPixels;
        public int FrameRate;
        public Camera(string id, string brand, string model, string size, double price, string totalPixels, int frameRate, byte discount = 0):base(id, brand, model, size, price, discount)
        {
            TotalPixels = totalPixels;
            FrameRate = frameRate;
        }
        public void ShowTotalAndFPS()
        {
            Console.WriteLine($"Total pixels: {TotalPixels}, Frame rate: {FrameRate}");
        }
    }
}
