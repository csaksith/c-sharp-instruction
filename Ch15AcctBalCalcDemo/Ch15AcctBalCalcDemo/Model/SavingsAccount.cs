namespace Ch15AcctBalCalcDemo.Model {
    internal class SavingsAccount : Account {

        // initialize properties for SavingsAccount.cs
        public decimal MonthlyInterestRate { get; set; }
        public decimal MonthlyInterestPayment { get; set; }
        // assign parameters to constructor
        public SavingsAccount(decimal monthlyInterestRate) {
            this.MonthlyInterestRate = monthlyInterestRate;
        }
        public void ApplyInterestPaymentToBalance() {

            MonthlyInterestPayment=Balance*MonthlyInterestRate;
            Balance+=MonthlyInterestPayment;
        }

    }
}
