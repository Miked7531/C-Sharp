using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg._214_error_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> userNumbers = new List<int>()
                {
                10,
                20,
                30,
                40,
                50
                };
                Console.WriteLine("Enter a number to divide 10,20,30,40,50 with: ");
                int userDivide = Convert.ToInt32(Console.ReadLine());
                foreach (int number in userNumbers)
                {
                    Console.WriteLine(number / userDivide);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a number divisible by those in the list.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
