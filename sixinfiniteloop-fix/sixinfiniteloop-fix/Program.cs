using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sixinfiniteloop_fix
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++; //loops forever if i remove the incrementing i
            }
            Console.ReadLine();
        }
        
    }
}
