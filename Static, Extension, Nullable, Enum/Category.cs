using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static__Extension__Nullable__Enum
{
    internal class Category
    {
        public int Id;
        public string Name;
        public static int count;


        public Category(string name)
        {
            Id =++count;
            Name = name;
        }

        static Category()
        {
            count = 10;
        }

        public static void Show()
        {
            Console.WriteLine(count);
        }

        public static void Test()
        {
            Console.WriteLine("Show test");
        }
        public void ShowCount()
        {
            Console.WriteLine(count);
        }
    }
}
