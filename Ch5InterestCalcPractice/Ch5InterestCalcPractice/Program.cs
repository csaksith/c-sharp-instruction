using ConsoleLibrary;

namespace Ch5InterestCalcPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to the Interest Calculator ~\n");

            string choice = "y";
            while (choice=="y") {
                // user input loan amount and interest rate
                // display loan amount in $, interest rate in %, and interest payment in $
                double loanAmt = MyConsole.PromptDouble("\nEnter loan amount: ");
                decimal loanRate = MyConsole.PromptDecimal("Enter interest rate: ");
                double loanPayment = (double)loanRate*loanAmt;
                MyConsole.PrintLine($"\nLoan Amount:\t"+loanAmt.ToString("c"));
                MyConsole.PrintLine($"Interest Rate:\t"+loanRate.ToString("p"));
                MyConsole.PrintLine($"Interest:\t"+loanPayment.ToString("c"));


                choice=MyConsole.PromptReqString("\nContinue? (y/n): ","y","n");
            }
            MyConsole.PrintLine("\nBye!");
        }
    }
}
