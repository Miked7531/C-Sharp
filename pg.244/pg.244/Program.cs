using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg._244
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee staff = new Employee() { FirstName = "Sample", LastName = "Student" };

            staff.SayName();

            Console.ReadLine();
        }
    }
}
