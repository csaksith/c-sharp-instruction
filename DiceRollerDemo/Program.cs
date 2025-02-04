namespace DiceRollerDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Print("Dice Roller!");
            Print("");

            // roll the dice?
            string choice = PromptChoice("Roll the dice? ");
            Print("");
            Random rand = new Random(); //  new means creating a new instance of an object
            // while choice == "y" or Y
            while (choice == "y")
            {
                // roll die 1
                int total = DisplayResults(rand);

                if (total == 2)
                {
                    Print("Snake Eyes!");
                }
                if (total == 12)
                {
                    Print("Boxcars!");
                }
                // prompt roll again?
                Print("");
                choice = PromptChoice("Roll again? (y/n): ");
                Print("");
            }
            Print("Goodbye");
        }

        private static string PromptChoice(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine().ToLower();
        }

        private static int DisplayResults(Random rand)
        {
            int die1 = RollDie(rand);
            // roll die 2
            int die2 = rand.Next(1, 7);
            int total = die1 + die2;
            // display total AND message, if necessary (total 2 or 12)
            Print("Dice 1: " + die1);
            Print("Dice 2: " + die2);
            Print("Total: " + total);
            return total;
        }

        private static int RollDie(Random rand)
        {
            return rand.Next(1, 7);
        }

        private static void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
