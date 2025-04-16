namespace Ch14PersonManagerDemo.Model {
    internal class Customer : Person {
        public string CustomerNumber { get; set; }
        // camel format for method parameters
        // pascal case for class name, method name, and properties
        public Customer(string firstName,string lastName,string customerNumber) :
            base(firstName,lastName) {
            this.CustomerNumber=customerNumber;
        }

        public override string ToString() {
            return $"{base.ToString()} Customer Number: {CustomerNumber}"; 
        }
    }
}
