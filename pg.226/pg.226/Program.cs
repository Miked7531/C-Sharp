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
            Console.WriteLine("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int result = numb.myAdd(x);
            Console.WriteLine(result);
            double result1 = Convert.ToInt32(numb.myAdd((int)y));
            Console.WriteLine(result1);
            int result2 = numb.myAdd(a - a);
            Console.WriteLine(result2);
            Console.ReadLine();
            
        }
    }
}
