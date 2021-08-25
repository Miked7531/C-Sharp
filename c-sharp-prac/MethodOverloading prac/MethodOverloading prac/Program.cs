using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading_prac
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(5, 95);
            s1.Display();

            Student s2 = new Student(6, 100);

            Student s3 = s1 + s2;
            s3.Display();

            Student s4 = s1 + 5;
            s4.Display();

            if(s1 < s2)
            {
                Console.WriteLine("S1 < S2");
            }
            else
            {
                Console.WriteLine("S1 > S2");
            }

            int x = s1;
            Console.WriteLine(x);

            Console.ReadLine();
        }
    }
}
