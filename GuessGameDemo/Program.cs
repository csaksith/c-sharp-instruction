using System.ComponentModel.Design;

namespace GuessGameDemo
{
    internal class Program
    {
        // constants 
        const int MIN_VAL = 1;
        const int MAX_VAL = 100;
        static void Main(string[] args)
        {
            Print("Welcome to the Guessing Game!");
            Print("+++++++++++++++++++++++++++++");
            Print("");


            string choice = "y";
            Random rand = new Random();
            // while - choice = "y"
            while (choice == "y")
            {
                // play game
                // get random number (theNumber: int)
                int theNumber = rand.Next(MIN_VAL,MAX_VAL+1);
                // count: int = 0;
                int count = 0;
                int guess = 0;
                Print("I'm thinking of a number from " + MIN_VAL + " to " + MAX_VAL + ".\nTry to guess it.\n");
                Print("** DEBUG theNumber = " + theNumber);
                // play game until guess == theNumber
                while (guess != theNumber)
                {
                    // & get user's guess (guess: int) + incremement count 
                    guess = GetNumber("Enter number: ");
                    count++;
                    // & compare guess vs theNumber (diff: int = guess - theNumber)
                    int diff = guess - theNumber;
                    if (diff == 0)
                    {
                        // diff == 0 => WIN! + specialMsg 
                        DisplayWinnerMessage(count);
                        // & display message:
                        
                    }
                    else if (diff < -10)
                    {
                        // diff < -10 => way too low
                        Print("Way too Low! Guess again.");
                    }
                    else if (diff < 0)
                    {
                        // diff <0 => too low 
                        Print("Too low! Guess again.");
                    }
                    else if (diff > 10)
                    {
                        // diff > 10 => way too high
                        Print("Way too High! Guess again.");
                    }
                    else if (diff > 0)
                    {
                        // diff > 0 => too high
                        Print("Too High! Guess again.");
                    }
                }
                // prompt choice
                Print("");
                choice = GetRequiredString("Try again (y/n): ", "y", "n");
                Print("");
            }
            Print("Bye! Come back again soon! :)");
        }
        static void DisplayWinnerMessage(int count)
        {
            Print("You got it in " + count + " tries.");
            // specialMsg: count <=3, count <= 7, else..
            if (count <= 3)
            {
                Print("Great work! You are a mathematical wizard.");
            }
            else if (count <= 7)
            {
                Print("Not too bad! You've got some potential.");
            }
            else
            {
                Print("What took you so long? Maybe you should take some lessons.");
            }
        }
        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }

        static string GetRequiredString(string prompt, string val1, string val2)
        {
            string str = "";
            // bool success = false;
            // while true - on purpose!
            // method: used for the Try again prompt

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
        static int GetNumber(string prompt)
        {
            int nbr = 0;
            bool success = false;
            while (!success)
            {
                Console.Write(prompt);
                nbr = Int32.Parse(Console.ReadLine());
                if (nbr >= MIN_VAL && nbr <= MAX_VAL)
                {
                    success = true;
                }
                else
                {
                    Print("Error: entry must be between " + MIN_VAL + "and " + MAX_VAL);

                }
            }
            return nbr;
        }
    }
}
