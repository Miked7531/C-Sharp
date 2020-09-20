using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace branchassignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // title
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            // ask package weight
            Console.WriteLine("Please enter the package weight:");
            int pweight = Convert.ToInt32(Console.ReadLine());
            if (pweight > 50)
            {
                Console.Write("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }else
            {
                // w,h,l values
                Console.WriteLine("Please enter the package width:");
                double pwidth = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the package height.");
                double pheight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the package length.");
                double plength = Convert.ToDouble(Console.ReadLine());
                {
                    if (pwidth + pheight + plength > 50)
                    {
                        Console.Write("Package too big to be shipped via Package Express.");
                        Console.ReadLine();
                    }else
                    {
                        // shipping total
                        double total = ((pwidth * pheight * plength) * pweight / 100);
                        Console.Write("Your estimated total for shipping this package is:" + Convert.ToDecimal(total));
                        Console.ReadLine();
                    }
                }
            }
            {

            }
        }
    }
}
