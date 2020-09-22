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
            string userInput = Console.ReadLine();
            
            Console.WriteLine("Enter another sentence of your choice: ");
            string userInput1 = Console.ReadLine();

            Console.WriteLine("Enter another sentence of your choice: ");
            string userInput2 = Console.ReadLine();

            Console.WriteLine("Enter another sentence of your choice: ");
            string userInput3 = Console.ReadLine();

            var concatInputs = userInput.ToUpper() + " " + userInput1 + " " + userInput2 + " " + userInput3;
            Console.Write(concatInputs);
            Console.ReadLine();
        }
    }
}
