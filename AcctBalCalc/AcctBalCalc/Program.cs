using ConsoleLibrary;

namespace AcctBalCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Account application ~\n");
            // monthly payment and fees
            const double MonthlyFee = 1.00;
            double MonthlyIntRate = .012;
            // initialize accounts
            CheckingAccount checking = new CheckingAccount(1000.00,MonthlyFee);
            SavingsAccount savings = new SavingsAccount(1000.00,MonthlyIntRate);
            // 1.2% interst rate

            // display initial balances
            MyConsole.PrintLine("Starting Balances\n");
            MyConsole.PrintLine($"Checking: {checking.GetBalance():C}");
            MyConsole.PrintLine($"Savings: {savings.GetBalance():C}");

            MyConsole.PrintLine("\nEnter the transaction for the month\n");
            string transactionType = MyConsole.PromptReqString("Withdrawal or Deposit? (w/d): ","w","d");
            string acctType = MyConsole.PromptReqString("Checking or Savings? (c/s): ","c","s");
            double amount = MyConsole.PromptDouble("Amount? ");

            string choice = "y";
            while (choice=="y") {
               
                if (transactionType=="w") {
                    if (acctType=="c") {
                        checking.Withdraw(amount);
                    }
                    else if(acctType=="s"){

                    }
                }
                //else (transactionType=="d"{ 
                //}
                // savings interest payment: 1.2% * balance
                // show final balance c & s
                choice = MyConsole.PromptReqString("Continue? (y/n): ","y","n");
                MyConsole.PrintLine("Monthly Payments and Fees \n");
                MyConsole.PrintLine("Checking Fee:              "+MonthlyFee.ToString("C"));
                //MyConsole.PrintLine("Savings Interest Payment: ");

                MyConsole.PrintLine("Final Balances");
                MyConsole.PrintLine($"Checking: {checking.GetBalance():C}");
                MyConsole.PrintLine($"Savings: {savings.GetBalance():C}");

            }


        }
    }
}
