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
            decimal y = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter a number: ");
            var a = Console.ReadLine();
            Console.WriteLine("Enter another number: ");
            var b = Console.ReadLine();

            int result = numb.myAdd(x);
            Console.WriteLine(result);

            int result1 = numb.myAdd(y);
            Console.WriteLine(result1);

            int result2 = numb.myAdd(a,b);
            Console.WriteLine(result2);

            Console.ReadLine();
            
        }
    }
}
