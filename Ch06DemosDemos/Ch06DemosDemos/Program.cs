using Microsoft.VisualBasic;

namespace Ch06DemosDemos {
    internal class Program {
        static void Main(string[] args) {
            Print("Welcome to Chapter 6 Demos - Methods!");
            // get info for a movie (title, year, rating, director)
            string choice = "y";
            while (choice=="y") {
                string title =



            }

            Print("Goodbye!~");

        }

        static string GetString(string prompt,string str1,string str2) {
            string retStr = ""; // initialize return string
            bool success = false;
            while (!success) // keep looping until valid input is entered
            {
                retStr=GetString(prompt); 
            }

        }


        static string GetString(string prompt) {
            Print(prompt,"");
            return Console.ReadLine();
        }

        private static void Print(string msg,string endLine = "\n") {
            Console.WriteLine(msg+endLine);
        }
    }
}
