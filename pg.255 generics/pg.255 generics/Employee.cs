using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg._255_generics
{
    class Employee<T>
    {
        public T things { get; set; }

        public T[] _things = new T[10];

        public void AddOrUpdate(int index, T item)
        {
            if (index >= 0 && index < 10)
                _things[index] = item;
        }

        public T GetData(int index)
        {
            if (index >= 0 && index < 10)
                return _things[index];
            else
                return default(T);
        }

    }
}
