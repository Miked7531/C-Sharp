using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg._310
{
    public class NewEmployee
    {
        public string firstName;
        public string lastName;
        public string id;
        public string team;

        public NewEmployee():this("Default firstName","Default lastName")
        {
            Console.WriteLine("Record for new employees");
        }
        public NewEmployee(string firstName):this(firstName, "Default lastName")
        {
            this.firstName = firstName;
            Console.WriteLine("Record of new employee, with firstName");
        }
        public NewEmployee(string firstName, string lastName) :this(firstName, lastName, "full name default","hurray")
        {
            this.lastName = lastName;
            this.firstName = firstName;
            Console.WriteLine("Record of new employee, with both first and last name");
        }
        public NewEmployee(string firstName, string lastName, string id, string team)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            this.team = team;
            Console.WriteLine("Record of new employee, with firstName, lastName, id, and team.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First record");
            NewEmployee a = new NewEmployee();
            Console.WriteLine("Second record");
            NewEmployee b = new NewEmployee("Bob");
            Console.WriteLine("Third record");
            NewEmployee c = new NewEmployee("Bob", "Bobby");

            const string fishName = "Bob's bait and tackle";

            var newCustomer = "Bill";

            Console.WriteLine("Welcome to {0}. {1} really likes this place.", fishName, newCustomer);

            Console.ReadLine();
        }
    }
}
