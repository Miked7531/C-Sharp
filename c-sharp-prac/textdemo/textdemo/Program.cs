using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace textdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\miked\Logs\Test.txt";

            //string[] lines = File.ReadAllLines(filePath); // an array instead of list not good

            List<string> lines = new List<string>();
            List<Person> people = new List<Person>();


            //foreach (string line in lines)
            //{
            //    Console.WriteLine(line);
            //}

            //lines.Add("John, doe, www.poo.com");
            //File.WriteAllLines(filePath, lines);

            lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                Person p = new Person(items[0], items[1], items[2]);
                people.Add(p);
                
            }
            List<string> outContents = new List<string>();

            foreach (Person p in people)
            {
                Console.WriteLine(p);
                outContents.Add(p.ToString());
            }

            string outFile = @"C:\Users\miked\Logs\test.txt";
            File.WriteAllLines(outFile, outContents);

            Console.ReadLine();
        }
    }
}
