using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booldui
{
    class Program
    {
        static void Main(string[] args)
        {
            // age var
            Console.WriteLine("What is your age?:");
            int age1 = Convert.ToInt32(Console.ReadLine());
            // dui var

            Console.WriteLine("Do you have a DUI? Please enter true or false: ");
            bool dui = Convert.ToBoolean(Console.ReadLine());

            // speeding var
            Console.WriteLine("How many speeding tickets do you have?: ");
            int speed = Convert.ToInt32(Console.ReadLine());
            


            Console.WriteLine(age1 >= 15 && dui == false && speed < 3);

            Console.ReadLine();
        }
    }
}
