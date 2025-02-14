using ConsoleLibrary;
using System.Security.Cryptography.X509Certificates;

namespace AnimalCounter {

    internal class Program {

        private static void Main(string[] args) {
            MyConsole.PrintLine("Welcome to the Animal Counter~\n");
            Alligator a = new Alligator();
            MyConsole.PrintLine("Counting alligators...");
            count(a,3);

            MyConsole.PrintLine("\nCounting sheep...");
            Sheep s = new Sheep();
            s.Name="Blackie";
            count(s,2);
        }

        
        public static void count(ICountable c,int maxCount) {
            for (int i = 1; i<=maxCount; i++) {
                c.IncrementCount(); // increment the count for the object
                MyConsole.PrintLine(c.GetCountString()); // print count string
            }

        }
    }
}