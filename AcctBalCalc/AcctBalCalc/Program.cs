using ConsoleLibrary;

namespace AcctBalCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Account application ~\n");

            // initialize accounts
            CheckingAccount checking = new CheckingAccount(1000.00,1.00);
            SavingsAccount savings = new SavingsAccount(1000.00,.012);
            // 1.2% interst rate

            // display initial balances
            MyConsole.PrintLine("Starting Balances\n");
            MyConsole.PrintLine($"Checking: {checking.GetBalance():C}");
            MyConsole.PrintLine($"Savings: {savings.GetBalance():C}");




        }
    }
}
