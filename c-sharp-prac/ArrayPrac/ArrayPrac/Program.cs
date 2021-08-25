using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] grades = new int[5];

            //grades[0] = 20;
            //grades[1] = 15;
            //grades[2] = 12;
            //grades[3] = 9;
            //grades[4] = 7;

            //Console.WriteLine("Grades at index 0 : {0}", grades[0]);

            //string input = Console.ReadLine();
            //// assign value to array grades at index 0
            //grades[0] = int.Parse(input);
            //Console.WriteLine("Grades at index 0 : {0}", grades[0]);
            //Console.ReadKey();

            //// another way of initializing an array
            //int[] gradesOfMathStudentsA = { 20, 12, 12, 8, 8 };

            //// third way of initializing an array
            //int[] gradesOfMathStudentsB = new int[] { 15,20,3,17,18,15};

            //Console.WriteLine("Length of gradesOfMathStudentsA: {0}", gradesOfMathStudentsA.Length);

            //Console.ReadKey();

            //int[] nums = new int[10];

            //for (int i = 0; i < 10; i++)
            //{
            //    nums[i] = i + 10;
            //}

            //for (int j = 0; j < 10; j++)
            //{
            //    Console.WriteLine("Element{0} = {1}", j, nums[j]);
            //}

            //int counter = 0;
            //foreach (int k in nums)
            //{
            //    Console.WriteLine("Element{0} = {1}", counter, k);

            //}

            //Console.ReadLine();

            ////create an array with 5 of your best friends
            ////create a foreach loop which greets all of them

            //string[] pals = { "joe", "blo", "livi", "jon", "jak" };
            //foreach (var peeps in pals)
            //{
            //    Console.WriteLine("Hey there {0}", peeps);
            //}

            Boolean valid = false;
            string inputValueType;

            Console.WriteLine("Enter a value: ");
            string inputValue = Console.ReadLine();

            Console.WriteLine("Select the Data type to validate the input you have entered");
            Console.WriteLine("Press 1 for string");
            Console.WriteLine("Press 2 for integer");
            Console.WriteLine("Press 3 for boolean");

            Console.Write("Enter :");
            int inputType = Convert.ToInt32(Console.ReadLine());

            switch (inputType)
            {
                //check for string
                valid = IsAllAlphabetic(inputValue);
                inputValue = string;
                    break;
        }
            Console.ReadLine();
        }
    }
}
