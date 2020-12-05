using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg._255_generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.things = new List<string>();
            employee.things.Add("Things");
            employee.things.Add("BigThings");
            

            Employee<int> employee1 = new Employee<int>();
            employee1.things = new List<int>();
            employee1.things.Add(69);
            employee1.things.Add(10);

            foreach (string item in employee.things)
            {
                Console.WriteLine(item);
            }

            foreach (int item in employee1.things)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();
        }

        
    }
}
