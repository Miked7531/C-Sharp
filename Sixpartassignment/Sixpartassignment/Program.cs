using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracdump
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bus = { "yellow", "blue", "green", "pink" };
            Console.WriteLine("Enter some text: ");
            string userInput = Console.ReadLine();

            foreach (string i in bus)
            {
                Console.Write(i.ToString() + " " + userInput + "\n");
            }

            Console.ReadLine();

            int k = 0;
            while (k < 5)
            {
                Console.WriteLine(k);
                k++; //loops forever if i remove the incrementing k
            }
            Console.ReadLine();

            for (int o = 0; o <= 10; o = o + 2)
            {
                Console.WriteLine(o);
            }
            Console.ReadLine();
        }
    }
}
