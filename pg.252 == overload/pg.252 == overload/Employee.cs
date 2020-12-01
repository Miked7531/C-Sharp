using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg._252____overload
{
    class Employee : IDMatrix
    {
        public int z, x, y, w;
        public Employee(int z, int x, int y, int w)
        {
            this.z = z; this.x = x; this.y = y; this.w = w;
        }
        IDMatrix m1 = new IDMatrix(20, 10, 14, 10);
        Employee m2 = new Employee(5, 6, 7, 2);


        

        public static bool operator == (IDMatrix m1, Employee m2)
        {
            return true;
        }
        public static bool operator != (IDMatrix m1, Employee m2)
        {
            return false;
        }
    }
}
