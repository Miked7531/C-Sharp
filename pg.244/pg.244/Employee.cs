using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg._244
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName + " " +"\nID:" + ID);
        }
        
        public void Quit()
        {
            Console.WriteLine("My name is Jim");
        }
    }
}
