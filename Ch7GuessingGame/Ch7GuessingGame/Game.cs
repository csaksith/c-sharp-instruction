
namespace Ch7GuessingGame {
    internal class Game {
        // game set up
        public const int min = 1;
        public const int max = 100;
        public int guess;
        public int count;

        public Game() {
            Random rand = new Random();
            answer=rand.Next(min,max);
            count=0;
        }
        public void Play() {
            MyConsole.PrintLine("I'm thinking of a number from 1 to 100.\nTry to guess it.\n");
            int guess = 0;
            while (guess!=answer) {
                MyConsole.PrintLine("DEBUG* Answer = "+answer);

                guess=MyConsole.PromptInt("Enter number: ");
                count++;
                CheckGuess(guess);
            }
        }

        public void CheckGuess(int guess) {
            int diff = guess-answer;
            // win conditions
            if (diff==0) {
                MyConsole.PrintLine("\n~WINNER WINNER!~");
                MyConsole.PrintLine("You got it in "+count+" tries.\n");
                if (count<=3) {
                    MyConsole.Print("Great work! You are a mathematical wizard~\n");
                }
                else if (count>3||count<=7) {
                    MyConsole.Print("Not too bad! You've got some potential.\n");
                }
                else {
                    MyConsole.Print("What took you so long? Maybe you should take some lessons.\n");
                }
            }
            // try again prompts
            else if (diff<-10) {
                MyConsole.PrintLine("Way too low! Guess again.");
            }
            else if (diff<0) {
                MyConsole.PrintLine("Too low! Guess again.");
            }
            else if (diff>10) {
                MyConsole.PrintLine("Way too high! Guess again.");
            }
            else if (diff>0) {
                MyConsole.PrintLine("Too high! Guess again.");
            }
            else {
                MyConsole.PrintLine("Error! Invalid integer.");
            }

        }

    }
}


