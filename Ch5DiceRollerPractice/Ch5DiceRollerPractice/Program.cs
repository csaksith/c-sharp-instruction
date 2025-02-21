// Namespace declaration, grouping related code together.
using ConsoleLibrary;

namespace Ch5DiceRollerPractice {
    internal class Program {
        // The Main method is the entry point of the program.
        static void Main(string[] args) {
            // Welcoming the user to the Dice Roller program.
            MyConsole.PrintLine("Welcome to the Dice Roller!~\n");

            // Creating an instance of the Random class to generate random numbers.
            Random random = new Random();

            // Asking the user if they want to roll the dice, accepting only "y" or "n".
            string choice = MyConsole.PromptReqString("Roll the dice? (y/n): \n","y","n");

            // Looping as long as the user wants to roll the dice.
            while (choice=="y") {
                // Rolling two dice, calculating their total, and displaying the results.
                int total = DisplayResults(random);

                // Checking if the total is a special combination (snake eyes or boxcars).
                if (total==2) {
                    // Snake Eyes: both dice show 1.
                    MyConsole.PrintLine("Snake Eyes! o.o");
                }
                else if (total==12) {
                    // Boxcars: both dice show 6.
                    MyConsole.PrintLine("Boxcars! [].[]");
                }

                // Asking the user if they want to roll the dice again.
                choice=MyConsole.PromptReqString("\nRoll again? (y/n): \n","y","n");
            }

            // Farewell message when the user decides to stop.
            MyConsole.PrintLine("\nGoodbye!~");
        }

        // Method to roll two dice, display their results, and return their total.
        public static int DisplayResults(Random random) {
            // Rolling the first die (generating a random number between 1 and 6).
            int die1 = RollDie(random);
            // Rolling the second die.
            int die2 = RollDie(random);
            // Calculating the total of both dice.
            int total = die1+die2;

            // Displaying the results of each die and their total.
            MyConsole.PrintLine($"\nDie 1: {die1}");
            MyConsole.PrintLine($"Die 2: {die2}");
            MyConsole.PrintLine($"Total: {total}");

            // Returning the total to the caller.
            return total;
        }

        // Method to simulate rolling a die by generating a random number between 1 and 6.
        private static int RollDie(Random random) {
            // random.Next(1, 7) generates a random number from 1 (inclusive) to 7 (exclusive).
            return random.Next(1,7);
        }
    }
}
