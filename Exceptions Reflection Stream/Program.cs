using System.Reflection;

namespace Exceptions_Reflection_Stream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exception
            //DivideByZeroException
            //int result;
            //int num1 = 22;
            //int num2 = 0;
            //Console.WriteLine("before");
            //result = num1 / num2;
            //Console.WriteLine("after");

            //IndexOutOfRangeException
            //int[] arr = new int[2];
            //arr[1] = 5;
            //arr[2] = 10;

            //NullReferenceException
            //Group group = new Group();
            //group.Students.Add(new Student());


            //InvalidOperationException
            //group.Students.First(student=>student.Age>20);

            //ArgumentNullException
            //group.Students.First(null);

            //try
            //{
            //    int result;
            //    int num1 = 22;
            //num2:
            //    int num2 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("before");
            //    result = num1 / num2;
            //    Console.WriteLine("after");
            //    int[] arr = new int[2];
            //    int index = int.Parse(Console.ReadLine());
            //    arr[1] = 5;
            //    arr[index] = 10;
            //}
            //catch (DivideByZeroException ex)
            //{

            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine("Please enter valid number to divide");
            //    Console.ReadLine();
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine("Please enter valid number for index");
            //    Console.ReadLine();
            //}
            //catch (Exception ex)
            //{

            //    throw new FormatException();
            //    //Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    bool result = false;
            //    if (result)
            //    {
            //        Console.WriteLine("Finally block");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Else block");
            //    }
            //}
            //throw new Exception("");
            //Student stu = new Student();
            //stu.CheckAge();
            //Console.WriteLine("After exception"); 
            #endregion

            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();
            //foreach (Type type in types)
            //{
            //    //Console.WriteLine(type.Name);
            //    //Console.WriteLine("Fields:");
            //    //foreach (FieldInfo field in type.GetFields())
            //    //{
            //    //    Console.WriteLine(field);
            //    //}
            //    //Console.WriteLine(type.Name);
            //    //Console.WriteLine("Properties:");
            //    //foreach (PropertyInfo property in type.GetProperties())
            //    //{
            //    //    Console.WriteLine(property);
            //    //}
            //    //Console.WriteLine(type.Name);
            //    //Console.WriteLine("Methods:");
            //    //foreach (MethodInfo method in type.GetMethods())
            //    //{
            //    //    Console.WriteLine(method);
            //    //}


            //}
            Type stuType = new Student().GetType();
            //foreach (var item in stuType.GetFields(BindingFlags.NonPublic | BindingFlags.Static))
            //{
            //    Console.WriteLine(item);
            //}
            //FieldInfo privateField = stuType.GetField("Age",BindingFlags.NonPublic | BindingFlags.Instance);
            //Student student = new Student();
            //privateField.SetValue(student,(byte)8);
            //Console.WriteLine(privateField.GetValue(student));
            //MethodInfo method = stuType.GetMethod("CheckAge");
            //method.Invoke(student,null);


            AboutReflection reflection = new AboutReflection("First data", "Second data", "Third data", "Fourth data", "Fifth data");
            Type aboutType = reflection.GetType();

            Array.ForEach(aboutType.GetFields(), f =>
            {
                Console.WriteLine(f.GetValue(reflection));
            });
            List<Student> list = new List<Student>();

            list.Add(new Student());
            list.Add(new Student());
            list.Add(new Student());
            list.Add(new Student());
            list.ForEach(x => Console.WriteLine(x.Firstname));

            foreach (var x in list)
            {
                Console.WriteLine(x.Firstname);
            }

        }
    }

    class Group
    {
        public int GroupProp { get; set; }
        public List<Student> Students;
        public Group()
        {
            Students = new List<Student>();
        }
    }

    class Student
    {
        //public int StudentProp { get; set; }
        byte Age = 20;
        static string test;
        static string test2;
        public string Firstname="Firstnames";
        public string Surname;
        public void CheckAge()
        {
            if (Age < 18)
            {
                //throw new StudentAgeOutOfRangeException("Student age is under 18");
                Console.WriteLine("Hey");
            }
        }
    }

    class AboutReflection
    {
        public string First;
        public string Second;
        public string Third;
        public string Fourth;
        public string Fifth;

        public AboutReflection(string first, string second, string third, string fourth, string fifth)
        {
            First = first;
            Second = second;
            Third = third;
            Fourth = fourth;
            Fifth = fifth;
        }
    }
}