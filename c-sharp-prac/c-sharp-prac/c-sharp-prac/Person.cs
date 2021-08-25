using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_prac
{
    class Person
    {
        public Person(string firstName, string lastName, string url)
        {
            FirstName = firstName;
            LastName = lastName;
            Url = url;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Url { get; set; }

        public override string ToString()
        {
            return "First Name: " + FirstName + " Last Name: " + LastName + " URL: " + Url;
        }
    }
}
