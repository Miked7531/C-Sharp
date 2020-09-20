using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleappBool
{
    class Program
    {
        static void Main(string[] args)
        {   // while
            int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }
            Console.ReadLine();
            // do while
            int index1 = 6;
            do
            {
                Console.WriteLine(index1);
                index1++;
            } while (index <= 5);

            Console.ReadLine();
        }
    }
}
