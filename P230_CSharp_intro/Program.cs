//byte age = 30;

//if (age >= 17)
//{
//    Console.WriteLine("Universitete girish icazesi tesdiqlendi");
//}
//else
//{
//    Console.WriteLine("Universitete girish icazesi legv olundu");
//}


//int x = 5;
//int y = 8;

//x += y; // x=x+y // 5=5+8;
//Console.WriteLine(x);
//Console.WriteLine(y);


//x = 123123123;
//Console.WriteLine(x);


//byte age = 101;

//if (age == 100)
//{
//    Console.WriteLine("Universitete girish icazesi tesdiqlendi");
//}
//else if (age ==101)
//{
//    Console.WriteLine("Yash 101-e beraberdir");
//}
//else
//{
//    Console.WriteLine("Universitete girish icazesi legv olundu");
//}


//string drink = "cola zero none";

//switch (drink)
//{
//    case "fanta":
//        Console.WriteLine("You ordered fanta");
//        break;
//    case "sprite":
//        Console.WriteLine("You ordered sprite");
//        break;
//    //case "cola zero":
//    //    Console.WriteLine("You ordered cola zero");
//    //    break;
//    //case "cola":
//    //    Console.WriteLine("You ordered cola");
//    //    break;
//    case "cola":
//    case "cola zero":
//        Console.WriteLine("You ordered cola");
//        break;
//    default:
//        Console.WriteLine("Your order is incorrect");
//        break;
//}


//byte day = 8;
//switch (day)
//{
//    case 5:
//        Console.WriteLine("Friday");
//        break;
//    case 4:
//        Console.WriteLine("Thursday");
//        break;
//    case 3:
//        Console.WriteLine("Wednesday");
//        break;
//    case 2:
//        Console.WriteLine("Tuesday");
//        break;
//    case 1:
//        Console.WriteLine("Monday");
//        break;
//    case 6:
//        Console.WriteLine("Saturday");
//        break;
//    case 7:
//        Console.WriteLine("Sunday");
//        break;
//    default:
//        break;
//}

//for (int i = 10; i >0; i--)
//{

//    if (i% 2 != 0)
//    {
//        Console.WriteLine(i);
//    }
//}

//int number = 5;
//int count = 5;

//while (count>1)
//{
//    Console.WriteLine(number);
//    count--;
//}


//do
//{
//    Console.WriteLine("1. Create model");
//    Console.WriteLine("0. Exit");
//    Console.ReadLine();
//} while (true);


//string firstname = "Cemil";
//string surname = "Isayev";
//byte age = 23;

//var student = new
//{
//    firstname = "Cemil",
//    surname = "Isayev",
//    age = 23
//};


//Console.WriteLine(student.firstname);

// Array

//string[] student_names = { "Orxan", "Ulviyya", "Kamran"};



//for (int i = 0; i < student_names.Length; i++)
//{
//    Console.WriteLine(student_names[i]);
//}

//int[,] numbers = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 1, 2 } };

//Console.WriteLine(numbers[1,1]);


#region Cut eded olub olmadigini tapan alqoritm
//Console.WriteLine("Please choose number");
//string numStr = Console.ReadLine();

//int num = Convert.ToInt32(numStr);

//Console.WriteLine("Choosen number: " + num);


//if (num % 2 == 0)
//{
//    Console.WriteLine("Even");
//}
//else
//{
//    Console.WriteLine("Odd");
//}



#endregion


#region 3-e bolunur mu
//Console.WriteLine("Please choose number");

//string numStr = Console.ReadLine();

//int num = Convert.ToInt32(numStr);

//Console.WriteLine("------------------");

//if(num % 3 == 0)
//{
//    Console.WriteLine("Bolunur");
//}
//else
//{
//    Console.WriteLine("Bolunmur");
//} 
#endregion


#region 4-e ve 9-a bolunurmu
//Console.WriteLine("Please choose number");

//int num = Convert.ToInt32(Console.ReadLine());

//Console.Write("Result: ");

//if (num % 36 == 0)//num%4==0 && num % 9 == 0
//{
//    Console.Write("Bolunur");
//}
//else
//{
//    Console.Write("Bolunmur");
//} 
#endregion



#region Factorial
//Console.WriteLine("Please choose number to calculate factorial");

//int num = Convert.ToInt32(Console.ReadLine());
//int result = 1;

//for (int i = 1; i <= num; i++)
//{
//    result *= i;
//}

//Console.WriteLine("Result:\t" + result); 
#endregion