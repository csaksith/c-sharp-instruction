using ConsoleLibrary;

namespace csharp02162025practice {

    class Program {
        static void Main() {
            BankAccount myAccount = new BankAccount(); // myAccount is an instance
            myAccount.Deposit(100);
            myAccount.Deposit(150);

            MyConsole.PrintLine($"Final Balance: {myAccount.GetBalance()}");
        }
    }
    abstract class Shape {
        public abstract void Draw();
        // abstract method (no implementation)
    }
    class Circle : Shape {
        public override void Draw() {
            MyConsole.PrintLine("Drawing a circle!~");
        }

    }
    internal class BankAccount { 
        private double balance; // private means only this class can access it (encapsulation)

        public void Deposit(double amount) {
            if (amount>0) {
                balance+=amount;
                MyConsole.PrintLine($"Deposited {amount}, New Balance: {balance}");
            }
        }
        // method: deposit(double amount)
        // purpose: add money to the balance if the amount is greater than 0
        // encapsulation: the method provides controlled access
        // to balance so users can't invalid values (ex: negative numbers)
        public double GetBalance() {
            return balance;
        }

    }
}
