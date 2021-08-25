using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac1
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentTemperature = 70;
            int roomTemperature = 70;

            if(currentTemperature == roomTemperature)
            {
                Console.WriteLine("It is exactly room temperature.");
            }
            else
            {
                Console.WriteLine("It is not exactly room temperature.");
            }
            Console.ReadLine();
            
        }
    }
}
