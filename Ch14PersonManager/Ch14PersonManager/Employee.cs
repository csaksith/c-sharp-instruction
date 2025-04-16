namespace Ch14PersonManager {
    internal class Employee : Person {
        public string SSN { get; set; }

        // Employee constructor
        public Employee(string firstName,string lastName,string ssn)
            : base(firstName,lastName) {
            this.SSN=ssn;
        }

        // Override ToString method
        public override string ToString() {
            // Call the base ToString method to get the person's name and append the SSN
            return $"{base.ToString()} (SSN: {SSN})";
        }
    }
}