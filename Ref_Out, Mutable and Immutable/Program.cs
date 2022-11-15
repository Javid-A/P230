#region Classwork
//static double Calculator(double num1, double num2, char op)
//{
//    switch (op)
//    {
//        case '+':
//            return num1 + num2;
//        case '-':
//            return num1 - num2;
//        case '/':
//            return num1 / num2;
//        case '*':
//            return num1 * num2;
//        default:
//            Console.WriteLine("Operator is incorrect");
//            return default;
//    }
//}

//static void CalculatorVoid(char op, double num1, double num2)
//{
//    double result = 0;
//    if(op == '+')
//    {
//        result = num1 + num2;
//        Console.WriteLine(result);
//    }else if (op == '-')
//    {
//        result = num1 - num2;
//        Console.WriteLine(result);
//    }
//    else if (op == '/')
//    {
//        result = num1 / num2;
//        Console.WriteLine(result);
//    }
//    else if (op == '*')
//    {
//        result = num1 * num2;
//        Console.WriteLine(result);
//    }
//    else
//    {
//        Console.WriteLine("Please enter valid number");
//    }
//}

//static void CalculatorV2()
//{
//    Console.WriteLine("Please enter valid number:");
//    string num1Str = Console.ReadLine();
//    double num1 = double.Parse(num1Str);
//    Console.WriteLine("Please enter second valid number:");
//    string num2Str = Console.ReadLine();
//    double num2 = double.Parse(num2Str);
//    Console.WriteLine("Please enter operator");
//    start:
//    string opStr = Console.ReadLine();
//    char op = char.Parse(opStr);

//    double result = 0;
//    if (op == '+')
//    {
//        result = num1 + num2;
//        Console.WriteLine(result);
//    }
//    else if (op == '-')
//    {
//        result = num1 - num2;
//        Console.WriteLine(result);
//    }
//    else if (op == '/')
//    {
//        result = num1 / num2;
//        Console.WriteLine(result);
//    }
//    else if (op == '*')
//    {
//        result = num1 * num2;
//        Console.WriteLine(result);
//    }
//    else
//    {
//        Console.WriteLine("Please enter valid operator again");
//        goto start;
//    }
//}

//double result = Calculator(5, 10, 'm');
//Console.WriteLine(result);

//CalculatorVoid('p', 10, 30);

//CalculatorV2(); 
#endregion



#region break, continue, return
//static void Test()
//{
//    return;
//    for (int i = 0; i <= 20; i++)
//    {
//        if (i == 2)
//        {
//            return;
//        }
//        if (i == 12 || i == 15)
//        {
//            continue;
//        }
//        Console.WriteLine(i);
//    }


//    Console.WriteLine("Calculation process");
//    int total = default;
//    int price1 = 20;
//    int price2 = 30;
//    total += price1 + price2;
//    Console.WriteLine(total);
//}

//Test(); 
#endregion


#region ref
//byte number1 = 254;
//byte number2 = 0;
//byte number3 = 100;

//char ch = 'a';
//string name = "Orxan Qubatov Orxan Qubatov";


//int number = 200;
//int number2 = number; // 200

//number = 300;
//number = 400;
//Console.WriteLine(number2);

//int[] arr = { 1, 2, 3, 4, 5 };

//int[] arr2 = arr; // 0x200302

//arr[0] = 200;

//Console.WriteLine(arr2[0]);




//static void ChangeNumber(10)//value 
//{
//    10 = 100;
//    Console.WriteLine(100);
//}



//static void ChangeNumber(0x600300)// address
//{
//    0x600300 = 100;
//    Console.WriteLine(0x600300);
//}



//static void ChangeNumber(ref int asdasda)//value // address
//{
//    asdasda = 100;
//    Console.WriteLine(asdasda);
//}



//int num = 10;
//int num2 = 12;


//ChangeNumber(ref num2);

//num = num2;//100

//Console.WriteLine(num); 
#endregion