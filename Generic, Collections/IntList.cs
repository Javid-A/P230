using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic__Collections
{
    internal class IntList
    {
        private int[] _arr;
        public int[]  arr { get => _arr;}
        public IntList()
        {
            _arr = new int[0];
        }

        public void SetData(int value)
        {
            if (value > 0)
            {
                Array.Resize(ref _arr, _arr.Length + 1);
                _arr[_arr.Length - 1] = value;
            }
        }
    }
}
