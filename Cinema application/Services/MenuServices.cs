using Cinema_application.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_application.Services
{
    internal static class MenuServices
    {
        readonly static CinemaService _cinemaService;
        static MenuServices()
        {
            _cinemaService = new CinemaService();
        }
        
        public static void CreateHall()
        {
            SelectRowAndColumn(out int row, out int col);
        showEnum:
            ShowCategories();
            bool enumResult = Enum.TryParse(typeof(Categories), Console.ReadLine(), out object category);
            int minEnum = (int)Enum.GetValues(typeof(Categories)).Cast<Categories>().Min();
            int maxEnum = (int)Enum.GetValues(typeof(Categories)).Cast<Categories>().Max();
            if (!enumResult || !((int)category >= minEnum  && (int)category <= maxEnum))
            {
                Console.Write("Incorrect category.\t");
                goto showEnum;
            }

            _cinemaService.CreateHall(row, col, (Categories)category);
        }
        public static void EditHall()
        {
        current:
            _cinemaService.GetHalls();
            Console.WriteLine("Please enter hall number which you want to change");
            string currentHallNo = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(currentHallNo))
            {
                Console.Write("Please enter valid number.\t");
                goto current;
            }

        newNo:
            _cinemaService.GetHalls();
            Console.WriteLine("Please enter new hall number");
            string newNo = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(newNo))
            {
                Console.Write("Please enter valid number.\t");
                goto newNo;
            }

            bool result = _cinemaService.EditHall(currentHallNo, newNo.ToUpper());

            if (!result)
            {
                goto current;
            }
        }
        public static void GetHalls()
        {
            _cinemaService.GetHalls();
        }
        public static void GetSeats()
        {
        no:
            _cinemaService.GetHalls();
            Console.WriteLine("Please select hall");
            string hallNo = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(hallNo))
            {
                goto no;
            }

            bool result = _cinemaService.GetSeats(hallNo);
            if (!result)
            {
                goto no;
            }
        }
        public static void Reserve()
        {
        no:
            _cinemaService.GetHalls();
            Console.WriteLine("Please select hall");
            string hallNo = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(hallNo))
            {
                goto no;
            }
        start:
            SelectRowAndColumn(out int row, out int col);
            bool? result = _cinemaService.Reserve(hallNo, row, col);
            if (result == null)
            {
                Console.WriteLine("There is no hall with this number");
                goto no;
            }
            if(result == false)
            {
                Console.Write("Seat which you select has been already choosen");
                _cinemaService.GetHalls();
                goto start;
            }
        }

        static void SelectRowAndColumn(out int row, out int col)
        {
        row:
            Console.WriteLine("Please enter valid row number");
            bool rowResult = int.TryParse(Console.ReadLine(), out row);
            if (!rowResult || row <= 0)
            {
                goto row;
            }
        col:
            Console.WriteLine("Please enter valid column number");
            bool colResult = int.TryParse(Console.ReadLine(), out col);
            if (!colResult || col <= 0)
            {
                goto col;
            }
        }
        static void ShowCategories()
        {
            Console.WriteLine("Please select category:");
            foreach (object category in Enum.GetValues(typeof(Categories)))
            {
                Console.WriteLine($"{(int)category}. {category}");
            }
        }

    }
}
