
namespace Ch15AcctBalCalcDemo.Model {
    internal class CheckingAccount : Account{
        // property declaration
        public decimal MonthlyFee {  get; set; }
        // create constructor to initialize the MonthlyFee propety
        public CheckingAccount(decimal monthlyFee) { 
        this.MonthlyFee = monthlyFee; // assign parameter
        }
        // use camelCase for parameters
        public void SubtractFeeFromBalance() {
            Balance-=MonthlyFee;
        }


    }
}
