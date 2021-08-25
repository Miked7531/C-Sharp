using System;

namespace SearchArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = { 30, 430, 23, 10 };

            Console.WriteLine(Array.IndexOf(grades, 23));
        }
    }
}
