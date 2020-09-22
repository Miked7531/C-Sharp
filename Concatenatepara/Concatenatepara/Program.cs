using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenatepara
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence of your choice: ");
            string userInput = string.ToUpper(Console.ReadLine());

            Console.WriteLine("Enter another sentence of your choice: ");
            string userInput1 = Console.ReadLine();

            Console.WriteLine("Enter another sentence of your choice: ");
            string userInput2 = Console.ReadLine();

            Console.WriteLine("Enter another sentence of your choice: ");
            string userInput3 = Console.ReadLine();

            userInput += " "; userInput1 += " "; userInput2 += " "; userInput3 += " ";
            Console.ReadLine();
           
        }
    }
}
