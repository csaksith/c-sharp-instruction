using ConsoleLibrary;

namespace Ch14PersonManager {
    internal class Program {
        static void Main(string[] args) {
            MyConsole.PrintLine("Welcome to the Person Manager~!\n");
            List<Person> list = new List<Person>();
            string create = "y";

            while (create=="y") {
                string choice = "c";
                while (choice=="c") {
                    choice=MyConsole.PromptString("Create customer or employee? (c/e): ");
                    if (choice=="c") {
                        string firstName = MyConsole.PromptString("Enter First Name: ");
                        string lastName = MyConsole.PromptString("Enter Last Name: ");
                        string customerNumber = MyConsole.PromptString("Enter Customer Number:");

                        // create new customer and add it to the list
                        Customer customer = new Customer(firstName,lastName,customerNumber);
                        // Add customer to the main list
                        list.Add(customer);
                    }
                    else if (choice=="e") {
                        string firstName = MyConsole.PromptString("Enter First Name: ");
                        string lastName = MyConsole.PromptString("Enter Last Name: ");
                        string ssn = MyConsole.PromptString("SSN: ");
                        Employee employee = new Employee(firstName,lastName,ssn);
                        // Add employee to the main list
                        list.Add(employee);
                    }
                    else {
                        MyConsole.PrintLine("Error! Entry must be 'c' or 'e' Try again.");
                    }

                    create=MyConsole.PromptString("Continue? (y/n): ");

                }
                MyConsole.PrintLine("\n=========People Summary=========");
                foreach (Person person in list) {
                    MyConsole.PrintLine(person.ToString());
                }
            }
        }
    }
}
