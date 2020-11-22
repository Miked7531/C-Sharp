using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg._223_basic_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Math numb = new Math();
            Console.WriteLine("Let's do some basic math, please enter a number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            numb.myAdd(y);
            numb.mySub(y);
            numb.myMulti(y);
            Console.WriteLine();
            Console.ReadLine();
        }
        
    }
}
