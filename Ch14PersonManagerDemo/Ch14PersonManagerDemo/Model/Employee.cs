namespace Ch14PersonManagerDemo.Model {
    internal class Employee : Person {
        public string Ssn { get; set; }
        public Employee(string firstName,string lastName,string ssn) :
        base(firstName,lastName) {
            this.Ssn=ssn;
        }
        public override string ToString() {
            // ssn = xxx-xx-####
            string ssnMasked = "xxx-xx-"+Ssn.Substring(7);
            return $"{base.ToString()}SSN: {ssnMasked}";
        }
    }
}
