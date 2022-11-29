using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic__Collections
{
    internal class StudentList
    {
        private Student[] _arr;
        public Student[] arr { get => _arr; }
        public StudentList()
        {
            _arr = new Student[0];
        }

        public void SetData(Student value)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = value;
        }
    }
}
