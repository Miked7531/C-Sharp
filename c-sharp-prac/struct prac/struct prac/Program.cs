using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_prac
{
    class Program
    {
        public struct Number
        {
            public decimal Amount { get; set; }
        }
        static void Main(string[] args)
        {
            Number myNum = new Number();
            myNum.Amount = 22.22m;

            Console.WriteLine(myNum.Amount);
            Console.ReadLine();
        }
    }
}
