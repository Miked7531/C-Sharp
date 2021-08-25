using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace c_sharp_prac
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello: Michael Davidson");
            //Console.WriteLine("========================");

            //Console.WriteLine(Convert.ToInt32(-1+4*6));
            //Console.WriteLine(Convert.ToInt32((35+5)%7));
            //Console.WriteLine(Convert.ToInt32(14+-4*6/11));
            //Console.WriteLine(Convert.ToInt32(2+15/6*1-7%2));

            //Console.WriteLine("Input the first number: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Input a second number: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int temp = number1;
            //number1 = number2;
            //number2 = temp;
            //Console.WriteLine("After swapping: ");
            //Console.WriteLine("First number: "+number1);
            //Console.WriteLine("Second number: "+number2);

            //Console.WriteLine("Input the first number to multiply: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input the second number to multiply: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input the third number to multiply: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //int result = num * num1 * num2;
            //Console.WriteLine(result);

            //Console.WriteLine("=======================");
            //Console.WriteLine("Enter a number: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter a second number: ");
            //int y = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            //Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
            //Console.WriteLine("{0} x {1} = {2}", x, y, x * y);
            //Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
            //Console.WriteLine("{0} mod {1} = {2}", x, y, x % y);

            //int input;
            //int result;

            //Console.WriteLine("Calculator");
            //Console.WriteLine("Enter a number to find its multiplication table up to 10: ");
            //input = Convert.ToInt32(Console.ReadLine());

            //result = input * 1;
            //Console.WriteLine("The table is: {0} x {1} = {2}", input, 1, result);
            //result = input * 2;
            //Console.WriteLine(": {0} x {1} = {2}", input, 2, result);
            //result = input * 3;
            //Console.WriteLine(": {0} x {1} = {2}", input, 3, result);
            //result = input * 4;
            //Console.WriteLine(": {0} x {1} = {2}", input, 4, result);
            //result = input * 5;
            //Console.WriteLine(": {0} x {1} = {2}", input, 5, result);
            //result = input * 6;
            //Console.WriteLine(": {0} x {1} = {2}", input, 6, result);
            //result = input * 7;
            //Console.WriteLine(": {0} x {1} = {2}", input, 7, result);
            //result = input * 8;
            //Console.WriteLine(": {0} x {1} = {2}", input, 8, result);
            //result = input * 9;
            //Console.WriteLine(": {0} x {1} = {2}", input, 9, result);
            //result = input * 10;
            //Console.WriteLine(": {0} x {1} = {2}", input, 10, result);

            //double number1, number2, number3, number4;
            //Console.WriteLine("Enter the first number: ");
            //number1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter the second number: ");
            //number2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter the third number: ");
            //number3 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter the fourth number: ");
            //number4 = Convert.ToDouble(Console.ReadLine());

            //double result = (number1 + number2 + number3 + number4) / 4;
            //Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4}", number1, number2, number3, number4, result);

            //Console.WriteLine("Enter a number: ");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter another number: ");
            //int y = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter another number: ");
            //int z = Convert.ToInt32(Console.ReadLine());

            //int first = (x + y) * z;
            //int second = x * y + y * z;
            //Console.WriteLine("Result of numbers {0}, {1}, {2}, (x+y)*z is {3}",x,y,z,first);
            //Console.WriteLine("Result of second equation x * y + y * z is {0}", second);

            //Console.WriteLine("Enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //if(age < 25)
            //{
            //    Console.WriteLine("You look older than 25");
            //}
            //else
            //{
            //    Console.WriteLine("You do look young");
            //}

            //Console.WriteLine("Enter a number: ");
            //int input = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("{0} {0} {0} {0}", input);
            //Console.WriteLine("{0}{0}{0}{0}", input);
            //Console.WriteLine("{0} {0} {0} {0}", input);
            //Console.WriteLine("{0}{0}{0}{0}", input);

            //Console.WriteLine("Enter a number: ");
            //int input = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("{0}{0}{0}", input);
            //Console.WriteLine("{0} {0} ", input);
            //Console.WriteLine("{0} {0} ", input);
            //Console.WriteLine("{0} {0} ", input);
            //Console.WriteLine("{0}{0}{0}", input);

            //Console.WriteLine("Enter the degree in celsius: ");
            //int celsius = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Kelvin = {0}", celsius + 273);
            //Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);

            //    Console.WriteLine(remove_char("w3resource", 1));
            //    Console.WriteLine(remove_char("w3resource", 9));
            //    Console.WriteLine(remove_char("w3resource", 0));

            //    Console.WriteLine(first_last("w3resource"));
            //    Console.WriteLine(first_last("Python"));
            //    Console.WriteLine(first_last("x"));

            //    string str;
            //    int l = 0;
            //    Console.WriteLine("Input a string : ");
            //    str = Console.ReadLine();
            //    if (str.Length>=l)
            //    {
            //        var s = str.Substring(0, 1);
            //        Console.WriteLine(s + str + s);
            //    }

            //    Console.ReadLine();
            //}
            //public static string remove_char(string str, int n)
            //{
            //    return str.Remove(n, 1);

            //}
            //public static string first_last(string ustr)
            //{
            //    return ustr.Length > 1
            //        ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;

            string filePath = @"C:\Users\miked\Logs\Test.txt";

            // string[] lines = File.ReadAllLines(filePath);

            //List<string> lines = new List<string>();
            //List<Person> people = new List<Person>();

            //lines = File.ReadAllLines(filePath).ToList();
            //foreach (string line in lines)
            //{
            //    string[] items = line.Split(',');
            //    Person p = new Person(items[0], items[1], items[2]);
            //    people.Add(p);

            //}
            //List<string> outContents = new List<string>();
            //foreach (Person p in people)
            //{
            //    Console.WriteLine(p);
            //    outContents.Add(p.ToString());
            //}

            //string outFile = @"C:\Users\miked\Logs\Test.txt";
            //File.WriteAllLines(outFile, outContents);

            //specify the data source.
            string[] students = new string[] { "Lacey", "Trisha", "Gavin", "Josh", "Jon", "Landon", "Kyndreshia" };

            //define the query expression.
            IEnumerable<string> studentQuery = from student in students where student.Length >= 6 select student;

            //execute the query.
            foreach (string s in studentQuery)
            {
                Console.Write(s + " ");
            }



            Console.ReadLine();
        }

        


    }
}
