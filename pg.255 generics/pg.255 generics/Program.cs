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
            employee.AddOrUpdate(0, "Stuff");
            employee.AddOrUpdate(1, "Stuff");
            employee.AddOrUpdate(2, "Stuff");

            Employee<int> employee1 = new Employee<int>();
            employee1.AddOrUpdate(0, 50);
            employee1.AddOrUpdate(1, 69);
            employee1.AddOrUpdate(2, 69);

            
            
            Console.ReadLine();
        }

        
    }
}
