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
        public int myAdd(decimal y)
        {
            return Convert.ToInt32(y * y);
        }
        public int myAdd(string a, string b)
        {
            int sub = Convert.ToInt32(a);
            int dub = Convert.ToInt32(b);
            int tub = sub - dub;

            return tub;
        }
    }
}
