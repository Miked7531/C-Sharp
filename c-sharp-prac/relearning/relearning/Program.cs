using System;

namespace relearning
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num3, num4, num5;

            //int num1;

            //num1 = 13;

            //int num2 = 100;
            //int sum = num1 + num2;
            //Console.WriteLine("num1 is " + num1);
            //Console.WriteLine("num1: " + num1 + " + num2: " + num2 + " is " + sum);

            //ASCII key input
            //Console.Write("Enter a string and press enter:");
            //string readInput = Console.ReadLine();
            //Console.WriteLine("You have entered {0}", readInput);

            //Console.Write("Enter a string and press enter:");
            //int asciiValue = Console.Read();
            //Console.WriteLine("ASCII value {0}:", asciiValue);
            //Console.ReadKey();

            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.Clear();
            //Console.WriteLine("Hello Mike");
            //Console.WriteLine("C# is pretty fun");

            //implicit conversion
            //int num = 12390532;
            //long bigNum = num;

            //float myFloat = 13.37F;
            //double myNewDouble = myFloat;

            //double myDouble = 13.37;
            //int myInt;
            //// explicit conversion
            //// cast double into int;
            //myInt = (int)myDouble;

            //// type conversion
            //string myString = myDouble.ToString();
            //string myFloatString = myFloat.ToString();
            //bool isSunShining = true;

            //string myBoolString = isSunShining.ToString();

            //Console.WriteLine(myBoolString);
            //Console.Read();

            //parsing string

            //string myString = "15";
            //string mySecondString = "13";
            //int num1 = Int32.Parse(myString);
            //int num2 = Int32.Parse(mySecondString);
            //int resultInt = num1 + num2;
            //string result = myString + mySecondString;

            //Console.WriteLine(resultInt);

            //define few variables
            int age = 31;
            string name = "Alfonso";
            string job = "Developer";

            // 1. string concatenation
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello my name is " + name + " , I am " + age + " years old");

            //2. string formatting.
            // string formatting uses index
            Console.WriteLine("String Formatting");
            Console.WriteLine("Hello my name is {0} , I am {1} years old. I'm a {2}", name, age, job);

            //3. string interpolation
            // string formatting using variables
            Console.WriteLine("String interpolation");
            Console.WriteLine($"Hello my name is {name} , I am {age} years old");
       
            Console.ReadLine();
        }
    }
}
