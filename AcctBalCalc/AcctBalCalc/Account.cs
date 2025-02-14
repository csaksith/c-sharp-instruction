using ConsoleLibrary;

namespace AcctBalCalc {
    public class Account : Balanceable, Withdrawable, Depositable {
        public double Balance { get; set; }
        public Account(double balance) {
            this.Balance=balance;
        }
        public void Deposit(double amount) {
            this.Balance+=amount;
        }
        public void Withdraw(double amount) {
            if (Balance<amount) {
                MyConsole.PrintLine("Insufficient Funds.");
            }
            else {
                this.Balance-=amount;
            }
        }

        public double GetBalance() {
            return Balance;
        }
        public void SetBalance(double amount) {
            Balance=amount;
        }


    }
}
