using ConsoleLibrary;

namespace Ch16DiceRollerEx {
    internal class Program {
        static void Main(string[] args) {
            MyConsole.PrintLine("Welcome to the Dice Roller Game!");

            // initialize choice with prompt - Roll the dice? (y/n)
            string choice = MyConsole.PromptString("Roll the dice (y/n): ").ToLower();

            while (choice=="y"){
                // roll die1, die2
                Dice dice = new Dice();
                dice.Roll();
                // display total & specialMsg
                MyConsole.PrintLine(dice.GetRollResult());
                // prompt continue?
                choice=MyConsole.PromptString("Roll again? (y/n): ");
            }
            MyConsole.PrintLine("Bye!");

        }
    }
}
