using Cinema_application.Services;
using Cinema_application.Utilities;

namespace Cinema_application
{
    internal class Program
    {
        static void Main(string[] args)
        {


            char selection;
            Console.WriteLine("Welcome our Cinema");
            do
            {
                Console.WriteLine("1. Create hall");
                Console.WriteLine("2. Edit hall no");
                Console.WriteLine("3. Get all halls");
                Console.WriteLine("4. Get all seats");
                Console.WriteLine("5. Reserve seat");
                Console.WriteLine("0. Exit");
            selection:
                selection = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (selection)
                {
                    case '1':
                        MenuServices.CreateHall();
                        Console.Clear();
                        break;
                    case '2':
                        MenuServices.EditHall();
                        Console.Clear();
                        break;
                    case '3':
                        MenuServices.GetHalls();
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    case '4':
                        MenuServices.GetSeats();
                        Console.Clear();
                        break;
                    case '5':
                        MenuServices.Reserve();
                        Console.Clear();
                        break;
                    case '0':
                        break;
                    default:
                        Console.WriteLine("Please choose correct number");
                        Console.Clear();
                        goto selection;
                }
            } while (selection != '0');

            #region Additional
            //string fullname;
            //do
            //{
            //    Console.WriteLine("First of all please enter your fullname");
            //    fullname = Console.ReadLine();
            //    if (string.IsNullOrWhiteSpace(fullname))
            //    {
            //        AccountService.IsEntered = false;
            //    }
            //    else
            //    {
            //        AccountService.IsEntered = true;
            //    }

            //} while (!AccountService.IsEntered);

            //Console.Clear();
            //Console.WriteLine("Welcome our Cinema");
            //char selection;
            //do
            //{
            //    Console.WriteLine("1. Create hall");
            //    Console.WriteLine("2. Edit hall no");
            //    Console.WriteLine("3. Get all halls");
            //    Console.WriteLine("4. Get all seats");
            //    Console.WriteLine("5. Reserve seat");
            //    Console.WriteLine("0. Exit");
            //selection:
            //    selection = Console.ReadKey().KeyChar;
            //    Console.WriteLine();
            //    switch (selection)
            //    {
            //        case '1':
            //            MenuServices.CreateHall();
            //            Console.Clear();
            //            break;
            //        case '2':
            //            MenuServices.EditHall();
            //            Console.Clear();
            //            break;
            //        case '3':
            //            MenuServices.GetHalls();
            //            Thread.Sleep(3000);
            //            Console.Clear();
            //            break;
            //        case '4':
            //            MenuServices.GetSeats();
            //            Console.Clear();
            //            break;
            //        case '5':
            //            MenuServices.Reserve();
            //            Console.Clear();
            //            break;
            //        case '0':
            //            break;
            //        default:
            //            Console.WriteLine("Please choose correct number");
            //            Console.Clear();
            //            goto selection;
            //    }
            //} while (selection != '0');
            #endregion
        }
    }
}