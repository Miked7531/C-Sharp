using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg._231
{
    class twoTime
    {
        public void myClazz(int x)
        {
            Console.WriteLine("Divided value is: " + x / 2);


        }
        
        public void myClazz(out int p, out int y, int x)
        {
            p = 30;
            y = 40;
            p += p;
            y += y + x;
        }
        
    }
}
