
using Access_modifiers__DLL__Namespace.Base_Entity;
using Access_modifiers__DLL__Namespace.Base_Entity.Test;
using Utilities;
//using System.Text;

namespace Access_modifiers__DLL__Namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classwork
            //Headphone headphone = new("123ac-ghacd","Apple","Airpods Pro 2","20mm x 15mm",600,"400mah",5.0);
            //Camera camera = new("camer-a2kac","Canon","1xTT","100mm x 70mm x 100mm",2000,"29.8 megaPixel",120,40);


            //headphone.ShowInfo();
            //headphone.ShowBatteryAndBluetooth();

            //Console.WriteLine("Camera specs:");

            //camera.ShowInfo();
            //camera.ShowTotalAndFPS(); 
            #endregion


            Student stu = new Student();

            //Electronic electronic = new Electronic();
            //Testing test = new Testing();
            Doctor doctor = new Doctor();

            Utilities.Human human = new Utilities.Human();
            
            Console.WriteLine(stu.Surname);
            //Console.WriteLine(stu.nam);
        }
    }
}
