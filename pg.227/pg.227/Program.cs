using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg._227
{
    class Program
    {
        static void Main(string[] args)
        {
            twoTime math = new twoTime();
            List<string> userList = new List<string>();
            Console.WriteLine("========================================================="); // first number
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();

            Console.WriteLine("========================================================="); // second number, but if no user input then use default value
            Console.WriteLine("Enter another number if you want or press enter: ");
            string input1 = Console.ReadLine();

            userList.Add(input);
            userList.Add(input1);  
 

            if (input1 == "")
            {
                int result = math.myNumb(Convert.ToInt32(input));
                Console.WriteLine(result);
            }
            else
            {
                int input2 = Convert.ToInt32(input1);
                int result = math.myNumb(Convert.ToInt32(input), input2);
                Console.WriteLine(result);
            }
            

            Console.ReadLine();
            


        }
    }
}
