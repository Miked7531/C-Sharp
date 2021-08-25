using System;

namespace _2d_and_jagged_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] grades = {
                {5,4,7,3 },
                {7,3,2,6 },
                {5,3,7,3 }
            };
            
            Console.WriteLine(grades.GetLength(0));
            Console.WriteLine(grades.GetLength(1));
            
            for (int i = 0; i < grades.GetLength(0); i++)
            {
                for (int k = 0; k < grades.GetLength(1); k++)
                {
                    Console.Write(grades[i,k] + " ");
                }
                Console.WriteLine();
            }
            
        }   
    }
}
