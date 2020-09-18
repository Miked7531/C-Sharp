using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac1
{
    class Program
    {
        static void Main(string[] args)
        {
            // multi
            Console.WriteLine("Enter a number: ");
            long num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 * 50);

            Console.ReadLine();
            // add
            Console.WriteLine("Enter a number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num2 + 25);
            Console.ReadLine();

            // divide
            Console.WriteLine("Enter a number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num3 / 12.5);
            Console.ReadLine();

            // bool
            Console.WriteLine("Enter a number greater than fifty: ");
            int num4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num4 > 50);
            Console.ReadLine();

            // remainder
            Console.WriteLine("Enter a number: ");
            long num5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num5 % 7);
            Console.ReadLine();
        }
    }
}
