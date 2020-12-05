using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg._272_lambda
{
    public class Employee
    {
        private string firstName;
        private string lastName;

        public Employee(string firstName, string lastName, int Id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            ID = Id;
        }

        public string Name
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string Name1
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int ID { get; set; }

    }
}
