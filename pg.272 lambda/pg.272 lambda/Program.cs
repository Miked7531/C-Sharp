using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg._272_lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Joe", "Blow", 1));
            employees.Add(new Employee("Joe", "Doe",2));
            employees.Add(new Employee("Jane", "Doe",3));
            employees.Add(new Employee("Beth", "Blow",4));
            employees.Add(new Employee("Janice", "Smith",5));
            employees.Add(new Employee("Mr", "Smith",6));
            employees.Add(new Employee("Mr", "Anderson",7));
            employees.Add(new Employee("Alex", "Lion",8));
            employees.Add(new Employee("Sophia", "King",9));
            employees.Add(new Employee("Ding", "Dong",10));

            //foreach loop making a joe list
            var result = from x in employees
                         where x.Name == "Joe"
                         select x;
            foreach (var employee in result)
            {
                Console.WriteLine(employee.ID + ", " + employee.Name + ", " + employee.Name1);
            }


            var result1 = employees.Where(z => z.Name == "Joe").ToList();

            foreach (var employee in result1)
            {
                Console.WriteLine(employee.ID + ", " + employee.Name + ", " + employee.Name1);
            }

            var newNumb = employees.Where(z => z.ID > 5).ToList();

            foreach (var emp in newNumb)
            {
                Console.WriteLine(emp.ID + ", " + emp.Name + ", " + emp.Name1);
            }
            

            Console.ReadLine();

        }
    }
}
