using Ch14PersonManagerDemo.Model;
using ConsoleLibrary;

namespace Ch14PersonManagerDemo.UI {
    internal class Program {
        static void Main(string[] args) {
            MyConsole.PrintLine("Welcome to the Person Manager");
            string choice = "y";
            // while choice = "y"
            while (choice=="y") {
                // prompt personType: string (c or e)
                string personType = MyConsole.PromptReqString("Create customer or employee (c/e): ","c","e");
                // prompt firstName: string
                // prompt lastName: string
                string firstName = MyConsole.PromptString("First name: ");
                string lastName = MyConsole.PromptString("Last name: ");
                // create new instance of person
                Person p;
                if (personType=="c") {
                    // prompt customer (customerNbr: string) or employee (ssn: string) info
                    string customerNumber = MyConsole.PromptString("Customer Number: ");
                    // create instance of customer
                    Customer c = new Customer(firstName, lastName, customerNumber);
                    p = c;
                    // set instance of person to a customer
                }
                else {
                    string ssn = MyConsole.PromptString("SSN: ");
                    Employee e = new Employee(firstName, lastName, ssn);
                    p=e;
                    // set instance of person to a employee
                }
                MyConsole.PrintLine("");
                MyConsole.PrintLine("You entered a new "+p.GetType().Name);
                MyConsole.PrintLine(p.ToString());
                // print person summary
                // prompt continue
                MyConsole.PrintLine("");
                choice=MyConsole.PromptReqString("Continue? (y/n): ","y","n");
            }
            MyConsole.PrintLine("Bye~");
        }
    }
}
