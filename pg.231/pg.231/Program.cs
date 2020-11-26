using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg._231
{
    public static class myCitats
    {
        public static string bigstatic(string name)
        {
            name = "jon";
            return name;
        }
        
    }
    

    public static class Program
    {
        static public void Main(string[] args)
        {
            twoTime math = new twoTime();

            Console.WriteLine("Enter a name, but it will always be jon: ");
            string nametime = myCitats.bigstatic(Console.ReadLine());

            Console.WriteLine("Enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            math.myClazz(x: userInput);

            math.myClazz(out int y, out int p, x: userInput);

            Console.WriteLine("Add {0}", y);
            Console.WriteLine("Add {0}", p);

            Console.WriteLine(nametime);

            Console.ReadLine();
        }

        
        
    }
}
