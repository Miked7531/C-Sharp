using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg._227
{
    class Program
    {
        static void Main(string[] args)
        {
            twoTime math = new twoTime();

            Console.WriteLine("Enter two numbers, but don't worry about the second one: ");
            string[] userInput = Console.ReadLine().Split();

            int x = Convert.ToInt32(userInput[0]);
            int z = Convert.ToInt32(userInput[1]);

            int result = math.myNumb(x, z);
            Console.WriteLine(result);

            Console.ReadLine();
            


        }
    }
}
