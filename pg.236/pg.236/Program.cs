﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg._236
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee() { FirstName = "Sample", LastName = "Student" };

            emp.SayName();

            Console.ReadLine();
            

        }
    }
}
