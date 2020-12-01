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
            Employee staff = new Employee();

            Console.WriteLine("Enter a first name: ");
            string userInput = Console.ReadLine();
            staff.FirstName = userInput;
            Console.WriteLine("Enter a last name: ");
            string userInput1 = Console.ReadLine();
            staff.LastName = userInput1;
            Console.WriteLine("Enter an ID for your name: ");
            int userID = Convert.ToInt32(Console.ReadLine());
            staff.ID = userID;


            
            staff.SayName();
            
            staff.Quit();

            Console.ReadLine();
        }
    }
}
