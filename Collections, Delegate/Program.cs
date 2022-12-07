using System.Collections;

namespace Collections__Delegate
{
    //public delegate void Divide(int num, int num2);
    public delegate bool Divide(int num, int num2);
    public delegate void AbbreviationDel(string name, string surname);
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

            //List<int> list = new List<int>();
            //list.Add(6);
            //list.Add(7);
            //list.Add(5);
            //list.Add(8);
            //IEnumerable<int> taken = list.OrderByDescending(x=>x).Skip(2).Take(2);

            //foreach (int item in taken)
            //{
            //    Console.WriteLine(item);
            //}
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
            //NumberIssues(Dividable);
            //Console.WriteLine("Is Greater");
            //NumberIssues(IsGreater,70);


            //AbbreviationDel del = new AbbreviationDel(Abbreviation);
            //AbbreviationDel del2 = new AbbreviationDel(WriteConsole);
            //Console.WriteLine(del("Javid", "Asadullayev"));
            //del += del2;
            //del -= del2;
            //del.Invoke("Javid", "Asadullayev");
            //del += delegate (string word1, string word2)
            //{
            //    Console.WriteLine("Anonymous");
            //};

            //del.Invoke("Javid", "Asadullayev");
            //del2("Javid", "Asadullayev");
            //() =>
            //{
                //Lambda expression
            //}
            //Sum()
            //{
            //
            //}


            Action action = new Action(() =>
            {
                Console.WriteLine("Action delegate");
            });
            Action action2 = new Action(delegate ()
            {
                Console.WriteLine("Anonymous");
            });

            Action action3 = new Action(ActionMethod);

            //action3 += ActionMethod;
            //action3();

            //Action<int, string, char> actionParameters = new Action<int, string, char>((intNumber,stringWord,charCharacter) =>
            //{
            //    Console.WriteLine(intNumber);
            //    Console.WriteLine(stringWord);
            //    Console.WriteLine(charCharacter);
            //});
            //actionParameters(5,"El cekin",'e');
            //Action<int> action4 = new Action<int>(num =>
            //{
            //    Console.WriteLine(num);
            //});
            //action4(5);

            //Func<int,string> func = new ((num) =>
            //{
            //    return num.ToString();
            //});

            //Func<string, char> func2 = (word) =>
            //{
            //    return word[0];
            //};

            //Predicate<int> isGreater = (num) => num > 10;
            //Console.WriteLine(isGreater(5)) ;
        }

        static void ActionMethod()
        {
            Console.WriteLine("Method");
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

        static void Abbreviation(string name, string surname)
        {
            Console.WriteLine($"{name}.{char.ToUpper(surname[0])}");
        }
        static void WriteConsole(string word1, string word2)
        {
            Console.WriteLine($"{word1} {word2}");
        }
    }
    class Test
    {
        public int MyProperty { get; set; }
    }
}