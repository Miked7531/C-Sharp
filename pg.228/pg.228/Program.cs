using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg._228
{
    class Program
    {
        static public void Main(string[] args)
        {
            twoTegs royal = new twoTegs();

            Console.WriteLine("Enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            int userInput1 = Convert.ToInt32(Console.ReadLine());

            royal.myOp(userInput, userInput1);

            royal.myOp(x: 3, y: 7);
            Console.ReadLine();
            
             

            
        }
    }
}
