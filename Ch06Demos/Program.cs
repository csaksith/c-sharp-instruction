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
                choice = GetString("Continue? (y/n): ");
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
}
