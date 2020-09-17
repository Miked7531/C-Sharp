using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Program
    {
        static void Main(string[] args)
        {
            // intro
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();
            // first 3 questions
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            int yourPage = int.Parse(Console.ReadLine());
            Console.WriteLine("Your name is: " + yourName + " your course is: " + yourCourse + " your page number is: " + yourPage);
            Console.ReadLine();
            // bool time
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            bool yourExp = bool.Parse(Console.ReadLine());
            Console.ReadLine();
            // feedback
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            Console.ReadLine();
            // hours studied
            Console.WriteLine("How many hours did you study today?");
            Console.ReadLine();
            // closing
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly.");
            Console.ReadLine();

            //Console.WriteLine(rainingStatus);
            //Console.ReadLine();
        }
    }

