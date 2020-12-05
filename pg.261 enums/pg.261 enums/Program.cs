using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg._261_enums
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
                Console.WriteLine("Enter the current day of the week: ");
                string userInput = Convert.ToString(Console.ReadLine());
                var day1 = (Days)Enum.Parse(typeof(Days), userInput);
                Days day = day1;
                
                Console.WriteLine(day);
            }
            catch (Exception)
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
