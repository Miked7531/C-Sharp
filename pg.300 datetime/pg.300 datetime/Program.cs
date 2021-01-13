using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg._300_datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            DateTime currentTime = DateTime.Now;
            DateTime userInput = currentTime.AddHours(x);
            Console.WriteLine(string.Format("{0} {1}", currentTime, userInput));

            Console.ReadLine();
        }
    }
}
