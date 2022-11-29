using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic__Collections
{
    internal class CustomList<T,U> where T:class where U:new()
    {
        private T[] _arr;
        public T[] arr { get => _arr; }
        public U Count { get; set; }
        public CustomList()
        {
            _arr = new T[0];
        }

        public void SetData(T value)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = value;
        }
    }

}
