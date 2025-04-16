namespace Ch14PersonManagerDemo.Model {
    internal class Person {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person(string firstName, string lastName) {
            this.FirstName=firstName; 
            this.LastName=lastName;
        }
        
        // add virtual because it will be override later
        public virtual string ToString() {
            return $"Name: {FirstName} {LastName}\n";
        }

    }
}
