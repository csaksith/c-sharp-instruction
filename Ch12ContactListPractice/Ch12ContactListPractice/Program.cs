using ConsoleLibrary;

namespace Ch12ContactListPractice {

    internal class Program {

        private static void Main(string[] args) {
            MyConsole.PrintLine("\nWelcome to the Contact List Application~\n");
            // while loop to continue
            string choice = "y";
            while (choice=="y") {
                // user input
                // first name
                string firstName = MyConsole.PromptString("Enter first name: ");
                // last name
                string lastName = MyConsole.PromptString("Enter last name: ");
                // email
                string eMail = MyConsole.PromptString("Enter email: ");
                // phone number
                string phoneNumber = MyConsole.PromptString("Enter phone: ");
                // console output
                MyConsole.PrintLine();
                MyConsole.PrintLine("""
                    ----------------------------------------
                    ---- Current Contact -------------------
                    ----------------------------------------
                    """);
                // first and last name join
                MyConsole.PrintLine($"Name:\t\t{firstName} {lastName}");
                // email address
                MyConsole.PrintLine($"Email Address:\t{eMail}");
                // phone number
                MyConsole.PrintLine($"Phone Number:\t{phoneNumber}");
                MyConsole.PrintLine("----------------------------------------");
                // continue?
                choice=MyConsole.PromptReqString("\nContinue? (y/n): ","y","n");
            }

            MyConsole.PrintLine("Goodbye for now~");
        }
    }
}