using ConsoleLibrary;
using HangmanIT1.Model;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace HangmanIT1 {
    internal class Program {
        static void Main(string[] args) {
            MyConsole.PrintLine("~ Welcome to Hangman ~ ");
            MyConsole.PrintLine("=====================\n");
            MyConsole.PrintLine("~ Rules of Hangman ~");
            MyConsole.PrintLine("1. A random word will be generated, and you must guess the word, one letter at a time.");
            MyConsole.PrintLine("2. You get only 6 guesses before game over!");
            MyConsole.PrintLine("3. If you guess all the letters correctly, you win!");
            MyConsole.PrintLine("=====================\n");

            // create an instance of HangmanWords
            HangmanWords wordGenerator = new HangmanWords();

            // game variables initialization
            string choice = "y";
            while (choice=="y") {
                int incorrectGuesses = 0;
                bool wordGuessed = false;
                List<string> lettersGuessed = new List<string>();
                // get random word using getrandomword method
                string word = wordGenerator.GetRandomWord();
                string hiddenWord = wordGenerator.GetHiddenWord(word);

                while (incorrectGuesses!=6&&!wordGuessed) {
                    // display the current hangman image
                    MyConsole.PrintLine(GetHangmanImage(incorrectGuesses));
                    MyConsole.Print($"Random Word: {word}\n");
                    MyConsole.PrintLine($"Hidden Word: {hiddenWord}");

                    // prompt user to guess letter
                    string letterGuess = MyConsole.PromptString("\nGuess a letter: ");
                    MyConsole.PrintLine($"Letters Guessed: {letterGuess}");

                    // add guessed letter to the letters 
                    // validate the input is a single length + hasnt been guessed
                    if (!lettersGuessed.Contains(letterGuess)&&letterGuess.Length==1) {
                        lettersGuessed.Add(letterGuess);
                        // if statement for if letter guess is in the hidden word
                        if (word.Contains(letterGuess)) {
                            hiddenWord=UpdateHiddenWord(word,hiddenWord,letterGuess);
                            MyConsole.PrintLine("Correct guess~");
                            if (!hiddenWord.Contains("_")) {
                                wordGuessed=true;
                                MyConsole.PrintLine($"You guessed the correct word: {word}!");
                            }
                        }
                        else {
                            MyConsole.PrintLine("Incorrect guess! Try again. ");
                            MyConsole.PrintLine($"You have {5-incorrectGuesses} out of 6 guesses left!");
                            incorrectGuesses++;
                        }
                    }
                    else {
                        MyConsole.PrintLine("Invalid guess: either already guessed or not a single letter. Try again!");
                    }
                    MyConsole.PrintLine($"You guessed: {letterGuess}");
                }

                choice=MyConsole.PromptReqString("Play again? (y/n): ","y","n").ToLower();
            }
            MyConsole.PrintLine("\n~Come back soon ~");
        }

        // create for loop to display hangman stages 1-6
        //MyConsole.PrintLine("Testing hangman stages: \n");
        //for (int i = 0; i<=6; i++) {
        //    MyConsole.PrintLine($"Incorrect Guesses: {i}");
        //    MyConsole.PrintLine(GetHangmanImage(i));
        //    MyConsole.PrintLine(""); 
        //}

        //string theWord = "pizza";
        //for (int i = 0; i<theWord.Length; i++){
        //    MyConsole.PrintLine($"{theWord[i]}");
        //    if (theWord[i]=='p') {
        //        MyConsole.PrintLine($"P found... position {i}");
        //    }
        //}

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

        // method to reveal hidden word when user enters correct letter
        static string UpdateHiddenWord(string word,string hiddenWord,string letterGuess) {
            char[] hiddenArray = hiddenWord.Replace(" ","").ToCharArray();
            string newHiddenWord = "";
            // loop through the word and replace underscores with the correct letter
            for (int i = 0; i<word.Length; i++) {
                if (word[i].ToString()==letterGuess) {
                    hiddenArray[i]=letterGuess[0]; // use hidden array to replace underscore with correct letter.
                }
                newHiddenWord+=$"{hiddenArray[i]} ";
            }
            return newHiddenWord;
        }


    }
}

