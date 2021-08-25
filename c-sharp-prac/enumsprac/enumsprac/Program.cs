using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumsprac
{
    class Program
    {
        enum Days
        {
            //days of the week
            Monday, //0
            Tuesday, //1
            Wednesday, //2
            Thursday, //3
            Friday, //4
            Saturday, //5
            Sunday, //6
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enums of the week");
            foreach (string v in Enum.GetNames(typeof(Days)))
            {
                Console.WriteLine("{0} = {1:D}", v, Enum.Parse(typeof(Days), v));
            }
            try
            {
                Console.WriteLine("Enter the current day of the week using 1-7: ");
                string day1 = Console.ReadLine();
                Days day = (Days)Convert.ToInt32(day1);
                Console.WriteLine(day);
            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            finally
            {
                Console.ReadLine();
            }

            
            


        }
    }
}
