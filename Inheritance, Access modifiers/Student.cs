using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance__Access_modifiers
{
    internal class Student:Person
    {
        public string GroupNo;
        public byte Point;
        public bool IsGraduated;

        public Student(string name, string surname, string gender, byte age, string groupno, byte point, bool isGraduated = false):base(name,surname,gender,age)
        {
            GroupNo = groupno;
            Point = point;
            IsGraduated = isGraduated;
           
        }

        #region this keyword with constructors
        //public Student(string surname,byte point) : this(point)
        //{
        //    if (surname.StartsWith("Test"))
        //    {
        //        Console.WriteLine("Test sozuyle bashlayir");
        //    }
        //    else if (surname.Length > 9)
        //    {
        //        Console.WriteLine("9-dan boyukdur");
        //    }
        //}

        //public Student(byte point)
        //{
        //    if (point > 50)
        //    {
        //        Point = point;
        //    }
        //    else if (point > 30 && point <= 50)
        //    {
        //        Point = point;
        //        Console.WriteLine("Kesildi");
        //    }
        //    else
        //    {
        //        Point = 0;
        //        Console.WriteLine("Bal 0-a teyin olundu");
        //    }
        //}
        //public Student(string Name, string Surname, string GroupNo, byte Point, bool IsGraduated = false)
        //{
        //    this.Name = Name;
        //    this.Surname = Surname;
        //    this.GroupNo = GroupNo;
        //    this.Point = Point;
        //    this.IsGraduated = IsGraduated;
        //} 
        #endregion


        public void Info()
        {
            if (IsGraduated)
            {
                Console.WriteLine("Name: " + Name + ", Surname: " + Surname + ", Group no: " + GroupNo + ", Point: " + Point + ". Mezun olub");
            }
            else
            {
                Console.WriteLine("Name: " + Name + ", Surname: " + Surname + ", Group no: " + GroupNo + ", Point: " + Point);
            }
        }

        public bool TryAnother()
        {
            if (Point > 80)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ShowData()
        {
            Console.WriteLine(this.Point);
        }


    }
}
