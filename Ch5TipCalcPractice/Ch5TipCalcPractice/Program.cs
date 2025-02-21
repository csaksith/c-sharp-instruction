using ConsoleLibrary;

namespace Ch5TipCalcPractice {

    internal class Program {

        private static void Main(string[] args) {
            MyConsole.PrintLine("Welcome to the tip calculator~\n");
            string choice = "y";
            while (choice=="y") {
                decimal cost = MyConsole.PromptDecimal("Cost of meal: ");

                for (decimal tipPct = .15m; tipPct<=.25m; tipPct+=.05m) {
                    decimal tipAmt = cost*tipPct;
                    decimal totalAmt = tipAmt+cost;
                    MyConsole.PrintLine();
                    MyConsole.PrintLine(tipPct.ToString("P0"));
                    MyConsole.PrintLine($"Tip amount: {tipAmt.ToString("c")}");
                    MyConsole.PrintLine($"Tip amount: {totalAmt.ToString("c")}\n");
                }
                choice=MyConsole.PromptReqString("Continue? (y/n): \n","y","n");


                // user input cost of meal
                // display 15%, 20%, 25%
                // tip amount
                // total amount
                // continue? (y/n)

                MyConsole.PrintLine("Goodbye~");
            }
        }
    }
}