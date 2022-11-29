namespace Generic__Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enum
            //Console.WriteLine(Categories.Fanta.GetType());

            //foreach (var item in Enum.GetNames(typeof(Categories)))
            //{
            //    Console.WriteLine(item);
            //}


            //foreach (var item in Enum.GetValues(typeof(Categories)))
            //{
            //    Console.WriteLine((byte)item);
            //}
            //start:
            //Enum.TryParse(typeof(Categories),Console.ReadLine(),out object result);

            //if(result == null)
            //{
            //    goto start;
            //}
            //Console.WriteLine((byte)result); 
            #endregion


            //Worst case
            //Product product = new Product();
            //product.Name = "Redbull";
            //product.Price = 5;
            //product.Quality = 100;
            //Console.WriteLine(product.Quality);
            //Product product1 = new Product();
            //product1.quality = "Awesome";
            //Console.WriteLine(product1.quality);

            //product1._quality = 'A';
            //Console.WriteLine(product1._quality);

            //Product<string> product3 = new Product<string>();
            //product3.Quality = "awesome";
            //Product<double> product4 = new Product<double>();
            //product4.Quality = 99.99;
            //Product<char> product5 = new Product<char>();
            //product5.Quality = 'A';

            //Product<int> product6 = new Product<int>(100);
            //Console.WriteLine(product6.Quality);


            //IntList list = new IntList();
            //list.SetData(15);
            //list.SetData(25);
            ////list.SetData(35);
            ////list.SetData(45);


            //foreach (var item in list.arr)
            //{
            //    Console.WriteLine(item);
            //}

            StudentList list = new StudentList();


            //list.SetData(new Student("Albert", "Asadov"));
            //list.SetData(new Student("Kamran", "Zeynalov"));
            //list.SetData(new Student("Rashid", "Bagirov"));
            //list.SetData(new Student("Ulviyya", "Rustamova"));

            //foreach (var item in list.arr)
            //{
            //    Console.WriteLine(item);
            //}

            //CustomList<string> stringList = new CustomList<string>();

            //stringList.SetData("Test");
            //stringList.SetData("Test1");
            //stringList.SetData("Test2");
            //stringList.SetData("Test3");
            //stringList.SetData("Test4");

            //foreach (var item in stringList.arr)
            //{
            //    Console.WriteLine(item);
            //}

            //CustomList<Student,int> studentList = new CustomList<Student,int>();
            //studentList.SetData(new Student("Albert", "Asadov"));
            //studentList.SetData(new Student("Kamran", "Zeynalov"));
            //studentList.SetData(new Student("Rashid", "Bagirov"));
            //studentList.SetData(new Student("Ulviyya", "Rustamova"));
            //studentList.Count = 20;
            //foreach (var item in studentList.arr)
            //{
            //    Console.WriteLine(item);
            //}

            CustomList<Student, int> perviz = new CustomList<Student, int>();
            CustomList<Student, int> kamran = new CustomList<Student, int>();

            perviz.SetData(new Student("Parviz", "surname"));
            perviz.SetData(new Student("Parviz", "Alizade"));
            perviz.SetData(new Student("Parviz2", "Alizade"));
            kamran.SetData(new Student("kamran", "Zeynalov"));
            Console.WriteLine("Parviz's array");
            foreach (var item in perviz.arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Kamran's array");
            foreach (var item in kamran.arr)
            {
                Console.WriteLine(item);
            }
            //ShowDynamicValue(new Student("name","surname"));

        }
        static T ShowDynamicValue<T>(T value) where T:class
        {
            Console.WriteLine(value);
            return value;
        }
        #region Enum
        //static void ShowEnums(Categories category,int num)
        //{
        //    switch (category)
        //    {
        //        case Categories.Cola:
        //            break;
        //        case Categories.Fanta:
        //            break;
        //        case Categories.Tea:
        //            break;
        //        case Categories.Water:
        //            break;
        //        case Categories.Coffee:
        //            break;
        //        case Categories.Redbull:
        //            break;
        //        default:
        //            break;
        //    }
        //} 
        #endregion

    }
}