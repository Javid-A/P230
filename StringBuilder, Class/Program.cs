using System.Text;

namespace StringBuilder__Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ClassWork
            //int num;
            //int[] arr = new int[0];
            //bool result = int.TryParse(Console.ReadLine(), out num);

            //if (result)
            //{
            //    if (num > 0 && num <= 50)
            //    {
            //        CreateArray(ref arr, num, 3, 0);
            //    }
            //    else if (num > 50 && num <= 100)
            //    {
            //        CreateArray(ref arr, num, 5, 50);

            //    }
            //    else if (num > 100)
            //    {
            //        CreateArray(ref arr, num, 8, 100);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please enter valid number (>0)");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Please enter valid number");
            //}

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Total sum of remainder
            //int num = 333;
            //int sum = 0;
            //while (num > 0)
            //{
            //    int remainder = num % 10;//3 3
            //    sum += remainder;//3  6
            //    num /= 10;//num=num/10; 33 3
            //}

            //Console.WriteLine(sum);

            //Console.WriteLine(TotalRemainder());
            #endregion

            #region String methods & StringBuilder
            //Console.WriteLine(ConcatElements());

            //string str = "Hello P230 what's up";

            //string remove = str.Remove(5,5);
            //Console.WriteLine(remove);

            //string newStr = str.Replace("p230", "P300",ignoreCase:true,null);
            //Console.WriteLine(newStr);

            //char[] arr = str.ToCharArray();

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}


            //string newStr = str.Substring(0,15) + "...";
            //Console.WriteLine(newStr);

            //Console.WriteLine(str.Trim());
            //Console.WriteLine(str.ToUpper());


            //string products = "milk, coffee, cola, tea, water";

            //string[] arr = products.Split(", ");


            ////foreach (var item in arr)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //string newProductList = string.Join("==>", arr);
            //Console.WriteLine(newProductList);
            //StringBuilder builder = new StringBuilder();
            //builder.Append("Hello");
            //builder.Append("World");
            //builder.AppendLine("P230");
            //builder.Append("test");

            //builder.Insert(10, "InserValue");
            //Console.WriteLine(builder); 
            #endregion


            //House house = new House();
            //house.SquareMeter = 200;
            //house.Address = "Nizami street 127";
            //house.Room = 6;
            //house.IsRented = false;
            //house.MonthlyRentPrice = 1700;
            //house.Floor = 2;
            //house.Floor = 10;


            //Console.WriteLine("House 1 data: "+ house.Floor);
            //House house1 = new House();
            //house1.SquareMeter = 320;
            //house1.Address = "Nizami street 200";
            //house1.Room = 8;
            //house1.IsRented = true;
            //house1.MonthlyRentPrice = 2000;
            //house1.Floor = 3;

            //Console.WriteLine("House 2 data: "+ house1.MonthlyRentPrice);

            House house = new House(5,200,2,2000,"Hasan Aliyev",true);
            House house2 = new House(6,300,3,3000,"Hasan Aliyev",false);
            //House house3 = new House(3,2); // exception
            //Console.WriteLine(house2.IsRented);

            house2.Rented();
            
        }

        static void CreateArray(ref int[] arr,int num,byte divide, byte start)
        {
            int size = (num - start) / divide;
            if (start > 100)
            {
                size ++;
            }
            Array.Resize(ref arr, size);
            int index = 0;
            for (int i = start + 1; i <= num; i++)
            {
                if (i % divide == 0)
                {
                    arr[index] = i;
                    index++;
                }
            }
        }

        static int TotalRemainder()
        {
            int num = 333;
            int sum = 0;
            while (num > 0)
            {

                int remainder = num % 10;//3 3
                sum += remainder;//3  6
                num /= 10;//num=num/10; 33 3
            }

            return sum;
        }

        static string ConcatElements(params string[] namesArg)
        {
            string names = string.Empty;

            foreach (string name in namesArg)
            {
                names += string.Concat(name);
            }
            return names;
        }


        static string ReturnBuilder()
        {
            StringBuilder builder = new StringBuilder();

            return builder.ToString();
        }
    }
}