using Cinema_application.Entities;
using Cinema_application.Repositories;
using Cinema_application.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_application.Services
{
    internal class CinemaService
    {
        readonly ICinemaRepository _repository;
        public CinemaService()
        {
            _repository = new CinemaRepository();
        }

        public bool CreateHall(int row, int column, Categories category)
        {
            string hallNo = _repository.CreateHall(row, column, category);
            Console.WriteLine($"{hallNo} successfully created");
            return true;
        }
        public bool EditHall(string currentHallNo,string newNo)
        {
            Hall existed = FindHall(currentHallNo);
            
            if(existed == null)
            {
                return false;
            }

            foreach (Hall hall in _repository.Halls)
            {
                if (hall.No.ToUpper() == newNo)
                {
                    return false;
                }
            }
            _repository.EditHallNo(existed,newNo);
            return true;
        }

        Hall FindHall(string currentHallNo)
        {
            foreach (Hall hall in _repository.Halls)
            {
                if (hall.No.ToLower() == currentHallNo)
                {
                    return hall;
                }
            }
            return null;
        }

        public void GetHalls()
        {
            _repository.GetHalls();
        }

        public bool GetSeats(string hallNo)
        {
            Hall hall = FindHall(hallNo);
            if(hall == null)
            {
                return false;
            }

            _repository.GetSeats(hall);
            return true;
        }

        public bool? Reserve(string hallNo, int row, int column)
        {
            Hall hall = FindHall(hallNo);
            if (hall == null) return null;

            if (hall.Seats[row - 1, column - 1].IsFull)
            {
                return false; // her iki halda false qayidir errorun sebebi belli olmur
            }
            
            if(row>hall.Seats.GetLength(0) || column > hall.Seats.GetLength(1))
            {
                return false;// her iki halda false qayidir errorun sebebi belli olmur
            }

            return _repository.Reserve(hall, row, column);
        }
    }
}
