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
            employee.things = "Things";
            employee.things = "BigThings";
            

            Employee<int> employee1 = new Employee<int>();
            employee1.things = 69;
            employee1.things = 10;

            
            
            
            Console.ReadLine();
        }

        
    }
}
