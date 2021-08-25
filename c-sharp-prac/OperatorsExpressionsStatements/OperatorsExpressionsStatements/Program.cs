using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExpressionsStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable declaration
            int x, y, a, b;

            // assignment operator
            x = 3;
            y = 2;
            a = 1;
            b = 0;

            // there are many mathematical operators ...

            // addition operator
            x = 3 + 4;

            // subtraction operator
            x = 4 - 3;

            //multiplication operator
            x = 10 * 5;

            // division operator
            x = 10 / 5;

            // order of operations using parenthesis
            x = (x + y) * (a - b);

            //there are many operators used to evaluate values ...

            //equality operator
            if (x == y)
            {

            }

            //greater than operator
            if (x > y)
            {

            }

            // less than operator
            if (x < y)
            {

            }

            //greater or equal to operator
            if (x >= y)
            {

            }

            // there are two "Conditional" operators as well that can
            // be used to expand / enhance an evaluation ...
            // and they can be combined together multiple times.

            // conditional AND operator
            if ((x > y) && (a > b))
            {

            }
            
            // conditional Or operator
            if ((x > y) || (a > b))
            {

            }

            //also, here's the in-line conditional operator we 
            // learned about in the previous lesson...
            string message = (x == 1) ? "Car" : "Boat";

            //member access and method invocation
            Console.WriteLine("Hi");

           
        }
    }
}
