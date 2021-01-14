using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg._314_datetime
{
    class Program
    {
        public static void Main(string[] args)
        {
            // storing todays date in a variable
            var today = DateTime.Today;
            try
            {
                // get user age
                Console.WriteLine("Please enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0)
                {
                    throw new ExtraException();
                }
                // simple equation stored into a variable
                var bday = today.Year - age;
                Console.WriteLine("You were born on the year of {0}.", bday);
            }
            catch (ExtraException)
            {
                Console.WriteLine("You ain't cheating time.");
                Console.ReadLine();
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Enter a more realistic number please.");
            }
            catch (Exception)
            {
                Console.WriteLine("You hate to see it.");
            }
            Console.ReadLine();
        }
    }
}
