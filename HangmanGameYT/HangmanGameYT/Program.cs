using System;
using System.Collections.Generic; // List
using static System.Random;
using System.Text;
using ConsoleLibrary;
using System.Security.Cryptography;
using System.Globalization;

namespace HangmanGameYT {

    internal class Program {

        private static void printHangman(int wrong) {
            if (wrong==0) {
                MyConsole.PrintLine("\n+---+");
                MyConsole.PrintLine("    |");
                MyConsole.PrintLine("    |");
                MyConsole.PrintLine("    |");
                MyConsole.PrintLine("   ===");
            }
            else if (wrong==1) {
                MyConsole.PrintLine("\n+---+");
                MyConsole.PrintLine(" O  |");
                MyConsole.PrintLine("    |");
                MyConsole.PrintLine("    |");
                MyConsole.PrintLine("   ===");
            }
            else if (wrong==2) {
                MyConsole.PrintLine("\n+---+");
                MyConsole.PrintLine(" O  |");
                MyConsole.PrintLine(" |  |");
                MyConsole.PrintLine("    |");
                MyConsole.PrintLine("   ===");
            }
            else if (wrong==3) {
                MyConsole.PrintLine("\n+---+");
                MyConsole.PrintLine(" O  |");
                MyConsole.PrintLine("/|  |");
                MyConsole.PrintLine("    |");
                MyConsole.PrintLine("   ===");
            }
            else if (wrong==4) {
                MyConsole.PrintLine("\n+---+");
                MyConsole.PrintLine(" O  |");
                MyConsole.PrintLine("/|\\ |");
                MyConsole.PrintLine("    |");
                MyConsole.PrintLine("   ===");
            }
            else if (wrong==5) {
                MyConsole.PrintLine("\n+---+");
                MyConsole.PrintLine(" O  |");
                MyConsole.PrintLine("/|\\ |");
                MyConsole.PrintLine("/   |");
                MyConsole.PrintLine("   ===");
            }
            else if (wrong==6) {
                MyConsole.PrintLine("\n+---+");
                MyConsole.PrintLine(" O  |");
                MyConsole.PrintLine("/|\\ |");
                MyConsole.PrintLine("/ \\ |");
                MyConsole.PrintLine("   ===");
            }
        }

        private static int printWord(List<char> guessedLetters,String randomWord) {
            int counter = 0;
            int rightLetters = 0;
            MyConsole.Print("\r\n");
            foreach (char c in randomWord) {
                if (guessedLetters.Contains(c)) {
                    MyConsole.Print(c+" ");
                    rightLetters++;
                }
                else {
                    MyConsole.Print(" ");
                }
                counter++;
            }
            return rightLetters;
        }

        private static void printLines(String randomWord) {
            MyConsole.Print("\r");
            foreach (char c in randomWord) {
                Console.OutputEncoding=System.Text.Encoding.UTF8;
                MyConsole.Print("\u0305 ");
            }
        }

        private static void Main(string[] args) {
            MyConsole.PrintLine("Welcome to Hangman~");
            MyConsole.PrintLine("=======================");
            Random random = new Random();
            List<String> wordDictionary = new List<string> { "misha","nori","meow","jason" };
            int index = random.Next(wordDictionary.Count);
            String randomWord = wordDictionary[index];

            foreach (char x in randomWord) {
                MyConsole.Print("_ ");
            }

            int lengthOfWordsToGuess = randomWord.Length;
            int amountOfTimesWrong = 0;
            List<char> currentLettersGuessed = new List<char>();
            int currentLettersRight = 0;

            while (amountOfTimesWrong!=6&&currentLettersRight!=lengthOfWordsToGuess) {
                Console.Write("\nLetters guessed so far: ");
                foreach (char letter in currentLettersGuessed) {
                    Console.Write(letter+" ");
                }

                Console.Write("\nGuess a letter: ");
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) continue;  // Ensure valid input
                char letteredGuessed = input[0];

                if (currentLettersGuessed.Contains(letteredGuessed)) {
                    Console.Write("\nYou have already guessed this letter.");
                }
                else {
                    currentLettersGuessed.Add(letteredGuessed);
                    bool right = false;

                    foreach (char c in randomWord) {
                        if (letteredGuessed==c) {
                            right=true;
                            break;  // Stop checking as soon as we find a match
                        }
                    }

                    if (right) {
                        Console.WriteLine("\nCorrect guess!");
                        currentLettersRight=printWord(currentLettersGuessed,randomWord);
                        Console.Write("\r\n");
                        printLines(randomWord);
                    }
                    else {
                        amountOfTimesWrong++;
                        Console.WriteLine("\nWrong guess!");
                    }

                    printHangman(amountOfTimesWrong);
                    printLines(randomWord);
                }
            }

            Console.WriteLine("\r\nGame Over~");
        }
    }
}

