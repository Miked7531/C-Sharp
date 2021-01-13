using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pg._297_fileio
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\miked\Logs\log.txt";

            Console.WriteLine("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            //string[] lines = File.ReadAllLines(filePath); 

            List<string> lines = new List<string>();
            lines.Add(input.ToString());
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            
            File.WriteAllLines(filePath, lines);

            Console.ReadLine();
        }
    }
}
