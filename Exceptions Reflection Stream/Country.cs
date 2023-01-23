using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Reflection_Stream
{
    internal class Country<T> where T:Massive
    {
        List<T> LifeIsGone;
        int _totalPopulation;
        public int TotalPopulation
        {
            get
            {
                return _totalPopulation;
            }
        }
        public Country()
        {
            LifeIsGone = new List<T>();
            _totalPopulation = default;
        }
        public void Add(T type)
        {
            LifeIsGone.Add(type);
            _totalPopulation += type.Population;
        }

    }
}