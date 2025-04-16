namespace Ch14PersonManager {
    internal class Customer : Person {
        public string CustomerNumber { get; set; }

        // Customer constructor
        public Customer(string firstName,string lastName,string customerNumber)
            : base(firstName,lastName) {
            this.CustomerNumber=customerNumber;
        }

        // Override ToString method
        public override string ToString() {
            // Call the base ToString method to get the person's name
            return $"{base.ToString()} (Customer Number: {CustomerNumber})";
        }
    }
}