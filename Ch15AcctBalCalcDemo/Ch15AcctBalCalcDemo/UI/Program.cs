using Ch15AcctBalCalcDemo.Model;
using ConsoleLibrary;

namespace Ch15AcctBalCalcDemo.UI {

    internal class Program {

        private static void Main(string[] args) {
            MyConsole.PrintLine("Welcome to the Account Balance Calculator!~\n");
            // initialize checkingAccount, savingsAccount
            CheckingAccount ca = new CheckingAccount(1.0m);
            ca.Balance=1000.0m;
            SavingsAccount sa = new SavingsAccount(.01m);
            sa.Balance=1000.0m;
            // Display starting Balances
            MyConsole.PrintLine("Starting Balance");
            DisplayBalances(ca,sa);
            MyConsole.PrintLine("Enter transactions for the month: \n");
            string choice = "y";
            while (choice=="y") {
                Account a;
                string action = MyConsole.PromptReqString("Withdrawal or Deposit? (w/d): ","w","d");
                string account = MyConsole.PromptReqString("Checking or Savings? (c/s): ","c","s");
                decimal amount = MyConsole.PromptDecimal("Amount?: ");
                // while choice == "y"
                // prompt action: string (w/d)
                // prompt account: string (c/s)
                // prompt amount: decimal
                // processTransaction
                if (account=="c"){
                    a=ca;
                }
                else {
                    a=sa;
                }
                if (action=="w") {
                    a.Withdraw(amount);
                }
                else {
                    a.Deposit(amount);
                }
                
                choice=MyConsole.PromptReqString("Continue (y/n): \n","y","n");
            }
            // processEndOfMonth - interest and fees
            // Display final balances
            sa.ApplyInterestPaymentToBalance();
            ca.SubtractFeeFromBalance();
            MyConsole.PrintLine("\nMonthly Payments and Fee");
            MyConsole.PrintLine("Checking Fee:              "+ca.MonthlyFee.ToString("c"));
            MyConsole.PrintLine("Savings Interest Payment:  "+sa.MonthlyInterestPayment.ToString("c"));

            MyConsole.PrintLine("\nFinal Balances");
            DisplayBalances(ca,sa);
        }


        // create method for DisplayBalances
        static void DisplayBalances(CheckingAccount ca,SavingsAccount sa) {
            MyConsole.PrintLine("Checking: "+ca.Balance.ToString("c"));
            MyConsole.PrintLine("Savings: "+sa.Balance.ToString("c")); // need to include .Balance or it will only show name of class
        }
    }
}