using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
    public class Person
    {
        //string _middleName = "Granola Bar";
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get 
            { 
                return FirstName + " " + LastName; 
            }
        }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
