using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_and_Comparison_op
{
    class Program
    {
        static void Main(string[] args)
        {
            // title
            Console.WriteLine("Anonymouse Income Comparison Program");
            Console.ReadLine();
            // person1
            Console.WriteLine("Person1");
            // hourly pay
            Console.WriteLine("Hourly Rate?:");
            double hour1 = Convert.ToDouble(Console.ReadLine());
            // hours week
            Console.WriteLine("Hours worked per week?:");
            double week1 = Convert.ToDouble(Console.ReadLine());
            // person2
            Console.WriteLine("Person2");
            // hourly pay
            Console.WriteLine("Hourly Rate?:");
            double hour2 = Convert.ToDouble(Console.ReadLine());
            // hours week
            Console.WriteLine("Hours worked per week?:");
            double week2 = Convert.ToDouble(Console.ReadLine());
            // Salary p1
            Console.WriteLine("Annual salary of Person 1:");
            int sal1 = Convert.ToInt32(Console.ReadLine());
            // Salary p2
            Console.WriteLine("Annual salary of Person 2:");
            int sal2 = Convert.ToInt32(Console.ReadLine());
            // p1 or p2 pay bool
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(sal1 > sal2);
            Console.ReadLine();
            

        }
    }
}
