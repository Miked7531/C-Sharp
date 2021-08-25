using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_prac
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //List<int> ages = new List<int>();

            //ages.Add(23);

            Console.ReadLine();

            DemonstrateTextFileStorage();
            
            Console.WriteLine();
            Console.WriteLine("Press enter to shut down...");
            Console.ReadLine();
        }

        private static void DemonstrateTextFileStorage()
        {
            List<Person> people = new List<Person>();
            List<LogEntry> logs = new List<LogEntry>();
            string peopleFile = @"C:\Temp\people.csv";
            string logFile = @"C:\Temp\logs.csv";

            PopulateLists(people, logs);

            OriginalTextFileProcessor.SavePeople(people, peopleFile);

            var newPeople = OriginalTextFileProcessor.LoadPeople(peopleFile);

            foreach (var p in newPeople)
            {
                Console.WriteLine($"{ p.FirstName}{p.LastName} (IsAlive = {p.IsAlive})");
            }
        }


        private static void PopulateLists(List<Person> people, List<LogEntry> logs)
        {
            people.Add(new Person { FirstName = "Tim", LastName = "Dirst" });
            people.Add(new Person { FirstName = "Bob", LastName = "Smith", IsAlive = false });
            people.Add(new Person { FirstName = "Greg", LastName = "Gone" });

            logs.Add(new LogEntry { Message = "I blew up", ErrorCode = 6969 });
            logs.Add(new LogEntry { Message = "I'm somewhere", ErrorCode = 1337 });
            logs.Add(new LogEntry { Message = "I am tired", ErrorCode = 2222 });    
        }
    }
}
