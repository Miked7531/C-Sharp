using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace pg._226
{
    class Math
    {
        public int myAdd(int x)
        {
            return x + x;
        }
        public decimal myAdd(decimal y)
        {
            return y * y;
        }
        public int myAdd(string a)
        {
            int sub = Convert.ToInt32(a);
            return sub;
        }
    }
}
