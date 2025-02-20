using ConsoleLibrary;
using HangmanIT2.Model;

namespace HangmanIT2 {

    internal class Program {

        private static void Main(string[] args) {
            MyConsole.PrintLine("~Welcome to Hangman!~\n");

            //// iteration 2: testing GetHangmanMethod
            //int incorrectGuesses = 0;
            //MyConsole.PrintLine("Testing GetHangmanMethod");
            //// for loop to run through all stages
            //for (int i = 0; i<=6; i++) {
            //    MyConsole.PrintLine($"incorrectGuesses - Hangman Stage {i}");
            //    MyConsole.PrintLine(GetHangmanImage(i));
            //    MyConsole.PrintLine();
            //}

            // iteration 6 setting up loop for game
            // while loop for string choice 
            string choice = "y";
            while (choice=="y") {
                // creating an instance of HangmanWords class
                // object allows you to call methods from HangmanWords class
                HangmanWords wordGenerator = new HangmanWords();
                string word = wordGenerator.GetRandomWord();
                MyConsole.PrintLine($"\nDebug Purposes - word is {word}.\n");
                string hiddenWord = wordGenerator.GetHiddenWord(word);
                MyConsole.PrintLine(hiddenWord);
                // while loop for guessing word
                bool correctWord = false;
                string guessLetter = "";
                int incorrectGuess = 0;
                while (!correctWord&&incorrectGuess<6) {
                    // user input guess letter
                    guessLetter=MyConsole.PromptString("\nGuess a letter! (Choose wisely!): ");
                    // loop through "word" if character matches "guessLetter"
                    // if word contains guess letter
                    if (word.Contains(guessLetter)) {
                        // convert hiddenWord into character array
                        hiddenWord=wordGenerator.DisplayHiddenWord(word,hiddenWord,guessLetter[0]);
                        MyConsole.PrintLine(hiddenWord);
                    }
                    if (!hiddenWord.Contains("_")) {
                        correctWord=true;
                        MyConsole.PrintLine("\n~Congrats girly you won~");
                    }
                   
                    else if (!word.Contains(guessLetter)) { 
                        incorrectGuess++;
                        MyConsole.PrintLine($"\nYikes you have {6-incorrectGuess} out of 6 guesses left!");
                        MyConsole.PrintLine(hangmanImage[incorrectGuess]);
                    }
                    if (incorrectGuess==6) {
                        MyConsole.PrintLine("\nYikes you lost, try again!");
                        MyConsole.PrintLine($"The correct word was {word}.");
                    }
                }
                // if word does not guess letter 
                // increment guess count
                // display hangman
                // choice = continue? (y/n)
                choice=MyConsole.PromptReqString("Play again? (y/n): ","y","n");
            }
            // iteration 3: testing instance of random word
            // initialize object
            // declare variable 'wordGenerator' of type HangmanWords
            // new HangmanWords() calls the constructor HangmanWords class, 
            // creating a new instance (object) of the class 
            //HangmanWords wordGenerator = new HangmanWords();
            //// GetRandomWord method is applied to wordGenerator object then assigned to the word "variable
            //string word = wordGenerator.GetRandomWord();
            //MyConsole.PrintLine(word);
            //// iteration 4 - revealing correct letter and replacing underscores
            //string hiddenWord = wordGenerator.GetHiddenWord(word);
            //MyConsole.PrintLine(hiddenWord);



            MyConsole.PrintLine("\nSee you next time!~");
        }

        private static string[] hangmanImage = new string[] {
                // 0
                """
                -----
                |   |
                |
                |
                |
                |
                -------
                """,
                // 1
                """
                -----
                |   |
                |   O
                |
                |
                |
                -------
                """,
                // 2
                """
                -----
                |   |
                |   O
                |   |
                |
                |
                -------
                """,
                // 3
                """
                -----
                |   |
                |   O
                |  /|
                |
                |
                -------
                """,
                // 4
                """
                -----
                |   |
                |   O
                |  /|\
                |
                |
                -------
                """,
                // 5
                """
                -----
                |   |
                |   O
                |  /|\
                |  /
                |
                -------
                """,
                // 6
                """
                -----
                |   |
                |   O
                |  /|\
                |  / \
                |
                -------
                """,
            };

        // GetHangmanImage method
        // if statement of display hangman depending on the number of incorrect guesses.
        public static string GetHangmanImage(int incorrectGuesses) {
            if (incorrectGuesses<=hangmanImage.Length) {
                return hangmanImage[incorrectGuesses];
            }
            else {
                return "Invalid number of incorrect guesses!";
            }
        }
    }
}