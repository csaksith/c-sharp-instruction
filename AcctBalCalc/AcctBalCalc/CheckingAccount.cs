using System.Security.Cryptography.X509Certificates;

namespace AcctBalCalc {
    public class CheckingAccount : Account {
        public double monthlyFee { get; set; }

        // base constructor to set balance
        public CheckingAccount(double Balance,double monthlyFee) :
            base(Balance) {
            this.monthlyFee=monthlyFee;
        }
        public double AddMonthlyFee() {
            Balance-=monthlyFee;
            return Balance;
        }
    }
}
