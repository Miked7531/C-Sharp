using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg._204
{
    class Program
    {
        static void Main(string[] args)
        {
            //part one

            string[] bus = { "yellow", "blue", "green", "pink" };
            Console.WriteLine("Enter some text: ");
            string userInput = Console.ReadLine();

            foreach (string i in bus)
            {
                Console.Write(i.ToString() + " " + userInput + "\n");
            }

            Console.ReadLine();
            //part two
            // this loops forever if you swap ++ for --
            int q = 1;
            for (int i = 0; i < q; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            //step three
            int[] numberArray = { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.WriteLine(numberArray[i]);
            }
            Console.ReadLine();
            // step three
            string[] alphaArray = { "bill", "bob", "jack", "jill", "sam" };
            for (int j = 0; j <= 2; j++)
            {
                Console.WriteLine(alphaArray[j]);
            }
            Console.ReadLine();

            //step four
            
            List<string> strList = new List<string>();
            strList.Add("bob");
            strList.Add("bill");
            strList.Add("billy");
            Console.WriteLine("Guess a name: ");
            string userGuess = Console.ReadLine();
            bool found = false;
            for (int i = 0; i < strList.Count; i++)
            {
                if (userGuess == strList[i])
                {
                    Console.WriteLine(i);
                    found = true;
                    break;
                }
                
            }
            if (!found)
            {
                Console.WriteLine("Your input is not on the list.");
            }
            
            Console.ReadLine();

            //part five
            List<string> twinsList = new List<string>()
            {
                "sally",
                "billy",
                "jane",
                "bob",
                "bob"
            };
            Console.WriteLine("Guess a name: ");
            string userTwins = Console.ReadLine();
            found = false;
            for (int i = 0; i < twinsList.Count; i++)
            {
                if (userTwins == twinsList[i])
                {
                    Console.WriteLine(i);
                    found = true;
                    
                }

            }
            if (!found)
            {
                Console.WriteLine("Your input is not on the list.");
            }
            Console.ReadLine();

            //part six
            List<string> empList = new List<string>();
            List<string> twoList = new List<string>()
            {
                "jane",
                "bert",
                "bill",
                "bill",
                "bill",
                "john"
            };
            foreach (string name in twoList)
            {
                if (empList.Contains(name))
                {
                    Console.WriteLine("{0} has already been seen in the list.", name);
                }
                else
                {
                    empList.Add(name);
                    Console.WriteLine("{0} has not been seen in the list.", name);
                }
            }
            Console.ReadLine();
            




        }
    }
}
