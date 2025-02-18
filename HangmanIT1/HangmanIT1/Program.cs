using ConsoleLibrary;
using HangmanIT1.Model;

namespace HangmanIT1 {
    internal class Program {
        static void Main(string[] args) {
            MyConsole.PrintLine("Welcome to Hangman ~ ");
            MyConsole.PrintLine("=====================\n");

            // create an instance of HangmanWords
            HangmanWords wordGenerator = new HangmanWords();
            // get random word using getrandomword method
            string randomWord = wordGenerator.GetRandomWord();
            MyConsole.Print($"Random Word: {randomWord}");
            // create for loop to display hangman stages 1-6
            //MyConsole.PrintLine("Testing hangman stages: \n");
            //for (int i = 0; i<=6; i++) {
            //    MyConsole.PrintLine($"Incorrect Guesses: {i}");
            //    MyConsole.PrintLine(GetHangmanImage(i));
            //    MyConsole.PrintLine(""); 

            //}
            MyConsole.PrintLine("\nBye~! ");
            Console.ReadLine();
        }
        static string[] hangmanStages = new string[] {
            // iteration 1 - drawing the hangman
            // using raw string literals
            // stage 0 - no incorrect answers
            """
            -----
            |   |
            |
            |
            |
            |
            ------
            """, 
            // stage 1 - 1 incorrect answer
            """
            -----
            |   |
            |   O
            |
            |
            |
            ------
            """,
             // stage 2 - 2 incorrect answers
            """
            -----
            |   |
            |   O
            |   |
            |
            |
            ------
            """,
             // stage 3 - 3 incorrect answers
            """
            -----
            |   |
            |   O
            |  /|
            |
            |
            ------
            """,
             // stage 4 - 4 incorrect answers
            """
            -----
            |   |
            |   O
            |  /|\
            |
            |
            ------
            """,
             // stage 5 - 5 incorrect answers
            """
            -----
            |   |
            |   O
            |  /|\
            |  /
            |
            ------
            """,
             // stage 6 - 6 incorrect answers
            """
            -----
            |   |
            |   O
            |  /|\
            |  / \
            |
            ------
            """ };
        public static string GetHangmanImage(int incorrectGuesses) {
            
            if (incorrectGuesses<0||incorrectGuesses>=hangmanStages.Length) {
                return "Invalid number of incorrect guesses!";
            }
            return hangmanStages[incorrectGuesses];

        }
    }
}
