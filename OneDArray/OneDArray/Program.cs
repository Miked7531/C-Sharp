using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracdump
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] trucks = { "Chevy", "Toyota", "Ford", "Nissan" };
            Console.Write("Enter a number: ");
            var userRespone = Convert.ToInt32(Console.ReadLine());
            if (userRespone > 3 || userRespone < 0)
            {
                Console.Write("Invalid input");
            }
            else
            {
                Console.WriteLine(trucks[userRespone]);
            }

            Console.ReadLine();

            int[] numbers = { 23, 60, 1, 45 };
            Console.Write("Enter a number: ");
            var userResponse = Convert.ToInt32(Console.ReadLine());
            if (userResponse > 3 || userResponse < 0)
            {
                Console.Write("invalid input");
            }
            else
            {
                Console.WriteLine(numbers[userResponse]);

            }
            Console.ReadLine();

            List<string> var1 = new List<string>();
            var1.Add("We went to the beach");
            var1.Add("Then went to the bar");
            var1.Add("Didn't go to the car");
            Console.WriteLine("Input a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(var1[userInput]);
            Console.ReadLine();
        }
    }
}
