using System;
using System.Linq;

namespace Arraysort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades1 = { 30, 430, 23, 10 };
            int[] grades2 = { 30, 430, 23, 10 };

            if(Enumerable.SequenceEqual(grades1,grades2))
            {
                Console.WriteLine("equal");
            }
            
            
    }
    }
}
