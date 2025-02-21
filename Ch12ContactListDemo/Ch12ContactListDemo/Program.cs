namespace Ch12ContactListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to Ch 12 Contact List ~ DEMO ~\n");
            string choice = "y";
            while (choice=="y") {
                // prompt firstName, lastName, email, phone
                string firstName = MyConsole.PromptString("Enter first name: ");
                string lastName = MyConsole.PromptString("Enter last name: ");
                string email = MyConsole.PromptString("Enter email: ");
                string phone = MyConsole.PromptString("Enter phone: ");
                // create a contact instance
                //  instance is a specific object created from a class, with its own unique data.
                Contact C = new Contact(firstName, lastName, email, phone);
                // displayContact - call it by the instance of the class/
                MyConsole.PrintLine(C.DisplayContact());
                // prompt continue
                choice=MyConsole.PromptString("Continue? (y/n): ").ToLower().Trim();
            }
            MyConsole.PrintLine("Goodbye~");

        }
    }
}
