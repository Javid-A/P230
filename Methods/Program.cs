#region Homeworks

//Console.WriteLine("Bir eded secin");
//string numStr = Console.ReadLine();
//int n = Convert.ToInt32(numStr);

//while (n % 2 == 0)
//{
//    n /= 2;

//}
//if (n == 1)
//{
//    Console.WriteLine("Quvvetidir");
//}
//else
//{
//    Console.WriteLine("Quvveti deyil");
//}
//Console.WriteLine("bir eded daxil edin");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("bir eded daxil edin");
//int num2 = Convert.ToInt32(Console.ReadLine());
//for (int i = num1+1; i < num2; i+=4)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine("bir eded daxil edin");
//int num = Convert.ToInt32(Console.ReadLine());
//int i = 70;
//if (num > i) 
//{
//    num = num - i;
//    num *= 3;
//}
//else
//{
//    num -= i;
//}
//Console.WriteLine(num);

//int X = 20;
//int Y = 40;
//int Z = 40;

//if (X > Y && X > Z)
//{
//    Console.WriteLine(X);
//}
//else if (Y > X && Y > Z)
//{
//    Console.WriteLine(Y);
//}
//else
//{
//    Console.WriteLine(Z);
//}



//Console.WriteLine("n ededini daxil edin");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("m ededini daxil edin");
//int m = Convert.ToInt32(Console.ReadLine());

//int count = 0;
//if (n % 2 == 0)
//{
//    n++;
//}
//for (int i= n; i <= m ; i+=2)
//{
//    count++;
//}

//Console.WriteLine(count);
#endregion

//for (int i = 0; i < 50; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}

//Console.WriteLine("3-e bolunenler");
//for (int i = 0; i < 50; i++)
//{
//    if (i % 3 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}

//Console.WriteLine("7-ye bolunenler");
//for (int i = 0; i < 50; i++)
//{
//    if (i % 7 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}


//static void SayHello()
//{
//    Console.WriteLine("Hello");
//}

//static void Write(string name)
//{
//    Console.WriteLine(name);
//}

//static int Sum(int num1, int num2)
//{
//    return num1+ num2;
//}

//Write("Mehrac"); // Console.WriteLine("Mehrac");
//Write("Ulviyya");
//string name = "Orxan";
//Write(name);

//int num = Sum(5,15);
//int num2 = Sum(125,17);
//int num3 = Sum(50,25);

//Console.WriteLine(num);
//Console.WriteLine(num2);
//Console.WriteLine(num3);


//static void ShowRange(int start,int end, int divide)
//{
//    Console.WriteLine(divide + "-a bolunenler");
//    for (int i = start; i < end; i++)
//    {
//        if (i % divide == 0)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}

//static void SumTest(int num, int num2)
//{
//    Console.WriteLine(num+num2);
//}

//SumTest(90, 10);

//ShowRange(0,10,2);
//ShowRange(0,100,3);
//ShowRange(50,330,7);

//static double Total(int price1, int price2,int price3)
//{
//    double total = price1 + price2 + price3;
//    //Console.WriteLine(total);
//    return total;
//}


//double total = Total(15, 20, 30);
////Console.WriteLine(Total(15, 20, 30));
////Console.WriteLine("Vergisiz: ");
////Console.WriteLine(total);
//total *= 1.18;
//Console.WriteLine("Vergili");
//Console.WriteLine(total);



class Program
{
    static void Main(string[] args)
    {
        //int num = Add();
        //Console.WriteLine(num);
        //Console.WriteLine(Add(10));
        //Console.WriteLine(Add(20,50));
        //Console.WriteLine(Add("Albert"));
        //Console.WriteLine(Add("Oktay","Mammadli"));


        //Default(99,99);
        //Default(surname: "Isayev", name:"Jamil");
        //Default("Jamil",23);
        //Default(23, "Jamil");

        string fullname = "Kamran Zeynalov";

        double[] doubleArray = { 10.2, 20.9, 90.7 };
        foreach (double number in doubleArray)
        {
            Console.WriteLine(number);
        }
        foreach (char letter in fullname)
        {
            if(letter == 'a')
            {
                Console.WriteLine("A herfi movcuddur");
            }
        }
        //for (int i = 0; i < fullname.Length; i++)
        //{
        //    Console.WriteLine(fullname[i]);
        //}
    }

    //static int Add()
    //{
    //    return 5+10;
    //}
    //static int Add(int num)
    //{
    //    return num +10;
    //}

    //static int Add(int number,int number2)
    //{
    //    return number + number2;
    //}


    //static string Add(string name)
    //{
    //    return name;
    //}

    //static string Add(string name, string surname)
    //{
    //    return name + " " + surname;
    //}

    // Methodun return type-i onun imzasi sayilmir!!!
    //static int Test(int num)
    //{
    //    return num;
    //}
    //static string Test(int num)
    //{
    //    return num.ToString();
    //}

    //static void Default(int num,int num2)
    //{
    //    Console.WriteLine(num + num2);
    //}

    //static void Default(string name, string surname)
    //{
    //    Console.WriteLine(name + " " + surname);
    //}

    //static void Default(string name, int age)
    //{
    //    Console.WriteLine(name + " " + age);
    //}

    //static void Default(int age, string name)
    //{
    //    Console.WriteLine(age + " " + name);
    //}
}