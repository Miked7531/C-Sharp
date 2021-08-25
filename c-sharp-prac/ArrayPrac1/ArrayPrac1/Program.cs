using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrac1
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.In.ReadLine());
            int[] grades = new int[size];
            
            for (int i = 0; i < grades.Length; i++)
            {
                grades[i] = Convert.ToInt32(Console.In.ReadLine());
            }

            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write(grades[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
