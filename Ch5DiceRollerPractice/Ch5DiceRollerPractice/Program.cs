using ConsoleLibrary;

namespace Ch5DiceRollerPractice {
    internal class Program {
        static void Main(string[] args) {
            MyConsole.PrintLine("Welcome to the Dice Roller!~\n");
            Random random = new Random();
            // roll the dice? (y/n)
            string choice = MyConsole.PromptReqString("Roll the dice? (y/n): \n","y","n");
            while (choice=="y") {
                // die 1 random
                // die 2 random
                // sum of die 1 and die 2
                int total = DisplayResults(random);
                // if sum = 2 => snake eyes
                // if sum = 12 => box cars
                if (total ==2) {
                    MyConsole.PrintLine("Snake Eyes! o.o");
                }
                else if (total ==12) {
                    MyConsole.PrintLine("Boxcars! [].[]");
                }
                choice=MyConsole.PromptReqString("\nRoll again? (y/n): \n","y","n");
            }
            MyConsole.PrintLine("\nGoodbye!~");

        }
        // methods
        // display results
        public static int DisplayResults(Random random) {
            int die1 = RollDie(random);
            int die2 = RollDie(random);
            int total = die1+die2;
            MyConsole.PrintLine($"\nDie 1: {die1}");
            MyConsole.PrintLine($"Die 2: {die2}");
            MyConsole.PrintLine($"Total: {total}");
            return total;
        }

        // roll die
        private static int RollDie(Random random) {
            return random.Next(1,7);
        }

    }
}
