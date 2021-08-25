using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chainconstr_prac
{
    public class NewEmployee
    {
        public string firstName;
        public string lastName;
        public string empID;
        public string position;
        public string team;

        public NewEmployee():this("Default firstName","Default lastName")
        {
            Console.WriteLine("Reserving new record for the upcoming employee.");
        }
        public NewEmployee(string firstName):this(firstName,"Default lastName")
        {
            this.firstName = firstName;
            Console.WriteLine("Creating new record for the upcoming employee, with firstName!");
        }
        public NewEmployee(string firstName, string lastName) :this(firstName, lastName, "23323", "C# Dev", "The C# squad")
        {
            this.lastName = lastName;
            this.firstName = firstName;
            Console.WriteLine("Creating new record for the upcoming employee, with firstName and lastName!");
        }
        public NewEmployee(string firstName, string lastName, string empID, string position, string team)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.empID = empID;
            this.position = position;
            Console.WriteLine("Creating new record for the upcoming employee, with firstName, lastName, empID, position and team!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First construct!");
            NewEmployee a = new NewEmployee();
            Console.WriteLine("Second construct!");
            NewEmployee b = new NewEmployee("Danny");
            Console.WriteLine("Third construct!");
            NewEmployee c = new NewEmployee("Danny", "Seeb");
            Console.ReadLine();

        }
    }
}
