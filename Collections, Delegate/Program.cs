using System.Collections;

namespace Collections__Delegate
{
    //public delegate void Divide(int num, int num2);
    public delegate bool Divide(int num, int num2);

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classwork
            //MainPrintFile main = new MainPrintFile(new Excel());

            //OnlineSheet sheet = new OnlineSheet("Word Online");
            //MainPrintFile online = new MainPrintFile(sheet);
            //IPrintable printable = new PDF(); 
            #endregion

            #region Collections
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add('c');
            //arrayList.Add(1);
            //arrayList.Add("test");
            //arrayList.Add(new PDF());


            //ArrayList anotherList = new ArrayList();
            //anotherList.Add(111);
            //anotherList.Add(new Excel());
            //anotherList.Add('a');
            //arrayList.AddRange(anotherList);
            ////arrayList.Remove(111);
            //arrayList.RemoveRange(1,3);

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.Write("Count: ");
            //Console.WriteLine(arrayList.Count);


            //SortedList sorted = new SortedList();
            //int[] arr = { 1, 2, 3, 4, 5 };
            //sorted.Add("P233","Murad, Jamil");
            //sorted.Add("P500",null);
            //sorted.Add("P230","Rashid, Kamran");
            //sorted.Add("P232","Albert, Narmin");
            //sorted.Add("P400", 1);

            //foreach (DictionaryEntry item in sorted)
            //{
            //    foreach (var student in item.Value.ToString().Split(", "))
            //    {
            //        Console.WriteLine(student);
            //    }
            //}

            //Test test = null;

            //Console.WriteLine(test?.MyProperty);
            ////sorted.RemoveAt(,);
            ////sorted.


            //Dictionary<string, string> pairs = new Dictionary<string, string>();

            //pairs.Add("USA","Kentucky, Los Angeles, California, New York");
            //bool result = pairs.TryAdd("USA","Kentucky, Los Angeles, California, New York");
            //pairs.Add("Azerbaijan","Kurdemir, Salyan, Saatli, Lachin");
            //pairs.Add("Turkiye","Ankara, Istanbul, Bursa, Izmir");
            //Console.WriteLine(result);
            //foreach (KeyValuePair<string,string> item in pairs)
            //{
            //    Console.WriteLine(item.Value);
            //}


            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("Albert");
            //queue.Enqueue("Jamil");
            //queue.Enqueue("Rashid");

            ////Console.WriteLine($"{queue.Dequeue()} zehmet olmasa yaxinlashin");
            ////Console.WriteLine("Novbeti: " + queue.Peek());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.TryPeek(out string result));

            //Stack<DateTime> stack = new Stack<DateTime>();
            //stack.Push(new DateTime(2022,5,1));
            //stack.Push(new DateTime(2022,4,1));
            //stack.Push(new DateTime(2022,3,1));

            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Peek()); 
            #endregion

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //DivideByNumber(7,4);
            NumberIssues(Dividable);
            Console.WriteLine("Is Greater");
            NumberIssues(IsGreater,70);
        }
        static void DivideByNumber(int num,int result = 0)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % num == result)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void NumberIssues(Divide divide,int num=2)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (divide(i, num))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool Dividable(int num,int divide)//5
        {
            return num % divide == 0;
        }

        static bool IsGreater(int num,int greater)
        {
            return num > greater;
        }
    }
    class Test
    {
        public int MyProperty { get; set; }
    }
}