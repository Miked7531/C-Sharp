using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg._226
{
    class Program
    {
        static void Main(string[] args)
        {
            Math numb = new Math();
            Console.WriteLine("Enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a decimal: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a string to convert to an integer: ");
            int z = Convert.ToInt32(Console.ReadLine());
            numb.myAdd(x);
            numb.myAdd(y);
            numb.myAdd(z);
            Console.ReadLine();
            
        }
    }
}
