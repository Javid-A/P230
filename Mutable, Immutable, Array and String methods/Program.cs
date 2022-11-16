#region ref out
//int num = 5;
////int num2 = num;

////num = 10;

//int[] arr = { 1, 2, 3, 4, 5 };
//int[] arr2 = arr;

//int noValue;
////arr[0] = 15;
////Console.WriteLine(arr2[0]);

////ChangeNumber(ref num);
////Console.WriteLine(num);
////num = 10;
////int num2 = num;
////num2 = 5;
////Console.WriteLine(num2);


////ChangeNumber(ref noValue);
////ChangeNumberWithOut(out num);
////Console.WriteLine(num);
////num = 10;
////int num2 = num;
////Console.WriteLine(num2);

////static void ChangeNumber(ref int num)
////{
////    num += 10;
////    //num = 20;
////    Console.WriteLine(num);
////}

////static void ChangeNumberWithOut(out int num)
////{
////    num = 20;
////    num += 100;
////    //Console.WriteLine(num);
////}


////int numOut;
////string numOutStr = Console.ReadLine();
////bool result = int.TryParse(numOutStr, out numOut);


////Console.WriteLine(numOut);
////if (result)
////{
////    Console.WriteLine(numOut);
////}
////else
////{
////    Console.WriteLine("Please enter valid number");
////} 
#endregion

#region Mutable Immutable
////int num = 5;
////num = 10;

////string name = "Albert";

////name += " Asadov";


////for (int i = 0; i < 10; i++)
////{
////    name += i;
////Console.WriteLine(name);
////}


//int[] arr = { 1, 2, 3 };

//arr[0] = 10;

////foreach (int item in arr)
////{
////    Console.WriteLine(item);
////}


//static void ChangeArr(ref int[] arr)
//{
//    arr = new int[3] { 5,10,15 };
//    Console.WriteLine("Inside method");
//    foreach (var item in arr)
//    {
//        Console.WriteLine(item);
//    }
//}

//ChangeArr(ref arr);

//Console.WriteLine(arr[0]);
#endregion


#region Array methods
//int[] arr = { 1, 2, 3, 4, 5 };

//int[] arr2 = new int[5];//{0,0,0,0,0}



//for (int i = 0; i < arr2.Length; i++)
//{
//    arr2[i] = i;
//}



//foreach (var item in arr2)
//{
//    Console.WriteLine(item);
//}

//Array.Clear(arr);

//int[] cloneArr = (int[])arr.Clone();
//arr[0] = 1000;
//foreach (var item in cloneArr)
//{
//    Console.WriteLine(item);
//}



//int[] sourceArr = { 1, 2, 3, 4 ,5,6,7,8};
//int[] destinationArr = new int[10];
//Array.Copy(sourceArr,2,destinationArr,5,2);

//foreach (var item in destinationArr)
//{
//    Console.WriteLine(item);
//}


//Array doubleArr = Array.CreateInstance(typeof(double),5);


//string name = "Rashid";
//string name2 = "Rashid";


//Console.WriteLine(name.Equals(name2));
//Console.WriteLine("Rashid"=="Rashid");


//int length = arr.GetLength(0);

//Console.WriteLine(length);


//Console.WriteLine(arr.GetType());

//int index = Array.LastIndexOf(arr,4);

//Console.WriteLine(index);


//Array.Sort(arr);



//Array.Reverse(arr,3,5);

//foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}

//{1,2,3,4,5,0}
//Array.Resize(ref arr,arr.Length+1);
//arr[5] = 6;

//foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}

#endregion


//int num = 5;


//int[] arr = { 1, 2 };
//Console.WriteLine(arr.ToString());





//string names= string.Concat("Ulviyya "," Mehrac", " Zarbali"," Oktay"); // "name1 name2 name3 name4"

//string price = "5";
//int price = 5;

//Console.WriteLine(names);
//Console.WriteLine(names.Contains("i Okta"));

//Console.WriteLine(names.EndsWith("ay"));

//string format = string.Format("{0:c}",price);

//Console.WriteLine(format);


//Console.WriteLine(string.Format("{0:M}",DateTime.Now));

string name = " ";

if (string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("It is whitespace");
}