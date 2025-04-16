namespace Ch14PersonManager {
    public class Person {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName,string lastName) {
            this.FirstName=firstName;
            this.LastName=lastName;
        }
        // changed from override to virtual so it can be overrided later
        public virtual string ToString() {
            return $"{FirstName} {LastName}";
        }
    }
}
