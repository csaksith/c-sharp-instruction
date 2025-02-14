using ConsoleLibrary;

namespace PigDiceDemo1 {
    internal class Program {
        static void Main(string[] args) {
            MyConsole.PrintLine("Welcome to Pig Dice \n");
            Random rand = new Random();
            string choice = "y";

            while (choice=="y") {
                int nbrGames = MyConsole.PromptInt("Number of games to play? "); // Ask for number of games each time
                int highScore = 0;
                int highScoreNumRolls = 0;

                for (int i = 0; i<nbrGames; i++) {
                    int roll = 0;
                    int score = 0;
                    int rollCount = 0;

                    while (roll!=1) {
                        roll=rand.Next(1,7);
                        rollCount++; // Increment roll count

                        if (roll!=1) {
                            score+=roll;
                        }

                        if (score>highScore) {
                            highScore=score;
                            highScoreNumRolls=rollCount;
                        }
                    }
                }

                // Display high score after all games are played
                MyConsole.PrintLine($"High score was {highScore}");
                MyConsole.PrintLine($"High score # of rolls was {highScoreNumRolls}");

                choice=MyConsole.PromptString("Try again? (y/n): "); // Prompt user to play again
            }

            MyConsole.PrintLine("Bye!");
        }
    }
}
