using System;

namespace nested_prac
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 9; i >= 0; i--)
            {
                if(i == 5)
                {
                    break;
                }
                for (int k = i; k >= 0; k--)
                {
                    if(k == 3)
                    {
                        break;
                    }
                    
                    Console.WriteLine(k + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
