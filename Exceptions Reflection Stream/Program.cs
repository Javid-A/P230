using System.Reflection;
using System.Text;

namespace Exceptions_Reflection_Stream
{
    internal class Program
    {
        static async Task Main(string[] args)
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

            #region Reflection
            //Assembly assembly = Assembly.GetExecutingAssembly();
            //Type[] types = assembly.GetTypes();
            ////foreach (Type type in types)
            ////{
            ////    //Console.WriteLine(type.Name);
            ////    //Console.WriteLine("Fields:");
            ////    //foreach (FieldInfo field in type.GetFields())
            ////    //{
            ////    //    Console.WriteLine(field);
            ////    //}
            ////    //Console.WriteLine(type.Name);
            ////    //Console.WriteLine("Properties:");
            ////    //foreach (PropertyInfo property in type.GetProperties())
            ////    //{
            ////    //    Console.WriteLine(property);
            ////    //}
            ////    //Console.WriteLine(type.Name);
            ////    //Console.WriteLine("Methods:");
            ////    //foreach (MethodInfo method in type.GetMethods())
            ////    //{
            ////    //    Console.WriteLine(method);
            ////    //}


            ////}
            //Type stuType = new Student().GetType();
            ////foreach (var item in stuType.GetFields(BindingFlags.NonPublic | BindingFlags.Static))
            ////{
            ////    Console.WriteLine(item);
            ////}
            ////FieldInfo privateField = stuType.GetField("Age",BindingFlags.NonPublic | BindingFlags.Instance);
            ////Student student = new Student();
            ////privateField.SetValue(student,(byte)8);
            ////Console.WriteLine(privateField.GetValue(student));
            ////MethodInfo method = stuType.GetMethod("CheckAge");
            ////method.Invoke(student,null);


            //AboutReflection reflection = new AboutReflection("First data", "Second data", "Third data", "Fourth data", "Fifth data");
            //Type aboutType = reflection.GetType();

            //Array.ForEach(aboutType.GetFields(), f =>
            //{
            //    Console.WriteLine(f.GetValue(reflection));
            //});
            //List<Student> list = new List<Student>();

            //list.Add(new Student());
            //list.Add(new Student());
            //list.Add(new Student());
            //list.Add(new Student());
            //list.ForEach(x => Console.WriteLine(x.Firstname));

            //foreach (var x in list)
            //{
            //    Console.WriteLine(x.Firstname);
            //} 
            #endregion

            #region Stream
            //string path = @"C:\Users\Lenovo\Desktop";

            //string streamPath = Path.Combine(path, "P230C#", "Stream", "StreamWrite");
            //string p230CPath = Path.Combine(path, "P230C#");

            //string filePath = Path.Combine(streamPath, "text.txt");
            //try
            //{
            //    //DirectoryInfo directoryInfo = Directory.CreateDirectory(streamPath);
            //    //Console.WriteLine(directoryInfo.Parent);
            //    //Directory.Delete(p230CPath,true);
            //    //Console.WriteLine(Directory.Exists(streamPath));

            //    //if (!File.Exists(filePath))
            //    //{
            //    //    File.Create(filePath);
            //    //}
            //    //else
            //    //{
            //    //    Console.WriteLine("Already exists");
            //    //}
            //    //string content = "This is our last c# lesson";
            //    //File.WriteAllText(filePath,content);
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}


            //StreamWriter stream = new StreamWriter(filePath, true);

            //stream.Write("test");
            //stream.Write("test1");
            //stream.Write("test2");
            //for (int i = 0; i < 10; i++)
            //{
            //    stream.WriteLine(i);

            //}

            //stream.Flush();

            //stream.Close();

            //StreamReader stream = new StreamReader(filePath);

            //Console.WriteLine(stream.ReadToEnd());

            //stream.Close();
            //FileStream stream = new FileStream();

            //using (StreamReader stream = new StreamReader(filePath))
            //{
            //    Console.WriteLine(stream.ReadToEnd());
            //} 
            #endregion




            //Thread thread = new Thread(Write0);
            //Thread thread1 = new Thread(Write1);

            //thread.Start();
            //thread1.Start();

            //Task task = Task.Run(() =>
            //{
            //    for (int i = 0; i < 10000; i++)
            //    {
            //        Console.WriteLine(i);
            //    }
            //});
            //Console.Read();
            //Boiling();
            //Cooking();
            //Cleaning();

            //Task task = Task.WhenAll(Boiling(), Cooking(), Cleaning());

            //task.ContinueWith(t =>
            //{
            //    Console.WriteLine("Start eating");

            //});

            //await Cooking();
            //await Cleaning();
            //await Boiling();

            //Console.WriteLine("Start eat");
            //Console.ReadLine();
            HttpClient client = new HttpClient();
            string sourceCode = await client.GetStringAsync("https://www.google.com");
            
            Console.WriteLine("Test");

        }

        static async Task<string> Boiling()
        {
            string task = await Task.Run(() =>
            {
                Console.WriteLine("Start boiling");
                Thread.Sleep(10000);
                Console.WriteLine("Boiling end");
                return "Done";
            });
            string tea = await Task.Run(() =>
            {
                Console.WriteLine("Start tea");
                Thread.Sleep(4000);
                Console.WriteLine("Tea end");
                return "Done";
            });
            return "Boiling and Tea end";
        }

        static async Task<string> Cleaning()
        {
            string task = await Task.Run(() =>
            {
                Console.WriteLine("Start cleaning");
                Thread.Sleep(2000);
                Console.WriteLine("Cleaning end");
                return "Done";
            });


            return "Cleaning end";
        }

        static async Task<string> Cooking()
        {
            string task = await Task.Run(() =>
            {
                Console.WriteLine("Start cooking");
                Thread.Sleep(5000);
                Console.WriteLine("Cooking end");
                return "Done";
            });
            return task;
        }
        //static void Write0()
        //{
        //    for (int i = 1; i <= 10000; i++)
        //    {
        //        Thread.Sleep(100);
        //        Console.Write(0);
        //    }
        //}
        //static void Write1()
        //{
        //    for (int i = 1; i <= 10000; i++)
        //    {
        //        Thread.Sleep(100);
        //        Console.Write(1);
        //    }
        //}
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
        public string Firstname = "Firstnames";
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