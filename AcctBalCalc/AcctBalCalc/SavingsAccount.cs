namespace AcctBalCalc {
    public class SavingsAccount : Account {
        public double MonthlyIntRate { get; set; }
        public SavingsAccount(double Balance,double MonthlyIntRate) :
            base(Balance) {
            this.MonthlyIntRate=MonthlyIntRate;
        }
        public double ApplyMonthlyInterest() {
            double interest = MonthlyIntRate*Balance;
            Balance+=interest;
            return interest;
        }
    }
}
