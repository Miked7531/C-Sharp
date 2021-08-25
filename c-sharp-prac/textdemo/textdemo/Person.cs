using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textdemo
{
    class Person
    {
        public Person(string firstName, string lastName, string uRL)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            URL = uRL;
        }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string URL { get; set; }

        public override string ToString()
        {
            return "First Name: " + firstName + " Last Name: " + lastName + " URL: " + URL;
        }

    }
}
