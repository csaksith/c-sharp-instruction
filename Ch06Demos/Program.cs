namespace Ch06Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Chapter 6 Demos - Methods!");
            Print("Welcome to Chapter 6 Demos - Methods!");
            // get info for a movie (title, year, rating, director)
            string choice = "y";
            while (choice == "y")
            {
                string title = GetString("Enter movie title: ");
                int year = GetInt("Enter release year: ", 1900, 2050);
                string rating = GetString("Enter age rating: ");
                string director = GetString("Enter director: ");
                // instead of doing console.writeline and console.readline 
                //Print("Continue? (y/n): ");
                choice = GetString("Continue? (y/n): ", "y", "n");
            }//Console.WriteLine("Goodbye!");
            Print("Goodbye!");
        }
        static int GetInt(string prompt)
        {
            Print(prompt, "");
            return Int32.Parse(Console.ReadLine());
        }

        static int GetInt(string prompt, int min, int max)
        {
            bool success = false;
            int nbr = 0;
            while (!success)
            {
                Print(prompt, "");
                nbr = Int32.Parse(Console.ReadLine());
                if (nbr < min || nbr > max)
                {
                    Print("Error: out of range. Try Again.");
                }
                else
                {
                    success = true;
                }
            }
            return nbr;
        }
        // method: ensures that the user inputs one of two specific strings.
        static string GetString(string prompt, string str1, string str2)
        {
            string retStr = ""; // initialize the return string
            bool success = false; // track whether the input is valid
            while (!success) // keep looping until valid input is entered
            {
                retStr = GetString(prompt); // ask the user for input using the other GetString() method
                if (retStr.ToLower() == str1 || retStr.ToLower() == str2)
                {
                    success = true;
                }
                else
                {
                    Print("Error: Entry must be either '" + str1 + "' or '" + str2 + "'.Try again.");
                    //this is for choice = GetString("Continue? (y/n): ", "y", "n");
                }
            }
            return retStr;
        }
        // GetString method: accepts a prompt: string, returns a string from the console
        static string GetString(string prompt)
        {
            Print(prompt, "");
            return Console.ReadLine();
        }
        // method accepts one input variable, and returns void (returns no value)
        static void Print(string msg, string endLine = "\n")
        {
            Console.Write(msg + endLine);
        }
    }
}
