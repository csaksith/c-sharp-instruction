namespace Ch7GuessingGame {
    internal class Program {

        static void Main(string[] args) {

            MyConsole.PrintLine("Welcome to the Guess the Number Game!");
            MyConsole.PrintLine("+++++++++++++++++++++++++++++++++++++\n");

            // game loop
            string choice = "y";
            while (choice=="y") {
                MyConsole.PrintLine("I'm thinking of a number from 1 to 100.\nTry to guess it.\n");



            }
            choice=MyConsole.PromptString("\nTry again? (y/n): ");

        }




        MyConsole.PrintLine("Bye ~ Come back soon!");
        }
}
}
