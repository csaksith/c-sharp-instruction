using ConsoleLibrary;

namespace Ch12GuessingGameDemo
{
    internal class Program
    {

        // constants
        const int MIN_VAL = 1;
        const int MAX_VAL = 100;
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to the Guessing Game!");
            MyConsole.PrintLine("+++++++++++++++++++++++++++++");
            MyConsole.PrintLine("");

            string choice = "y";
            Random rand = new Random();
            while (choice == "y")
            {
                // play game
                int theNumber = rand.Next(MIN_VAL, MAX_VAL + 1);
                int count = 0;
                int guess = 0;
                MyConsole.PrintLine("I'm thinking of a number from " + MIN_VAL + " to " + MAX_VAL + ".\nTry to guess it.\n");
                MyConsole.PrintLine("** DEBUG: theNumber = " + theNumber);
                // play game until guess == theNumber
                while (guess != theNumber)
                {
                    guess = MyConsole.PromptInt("Enter number: ");
                    count++;
                    int diff = guess - theNumber;
                    Game game = new Game();
                    game.Diff=diff;
                    game.Count=count;
                    // calling the method on an INSTANCE not the class itself
                    // have to have an INSTANCE of a class so use "game" instead of "Game"
                    game.DisplayGuessMsg();
                }
                // prompt choice
                MyConsole.PrintLine("");
                choice = MyConsole.PromptReqString("Try again? (y/n) ", "y", "n");
                MyConsole.PrintLine("");
            }

            Print("Bye - come back again soon!");
        }



        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }

        static string GetRequiredString(string prompt, string val1, string val2)
        {
            string str = "";
            // while true - on purpose!!!
            while (true)
            {
                Console.Write(prompt);
                str = Console.ReadLine().Trim();
                if (str == "")
                {
                    Print("Error - entry is required.");
                }
                else if (str != val1 && str != val2)
                {
                    Print("Error - entry must be either " + val1 + " or " + val2);
                }
                else
                {
                    break;
                }
            }
            return str;
        }
    }
}

