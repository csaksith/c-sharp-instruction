using System;
namespace Ch07ContactListExercise {
    internal class Program {
        static void Main(string[] args) {
            MyConsole.Print("Welcome to the Contact List App!~ \n");
            MyConsole.PrintLine("");
            string choice = "y";
            while (choice=="y") {
                string firstName = MyConsole.PromptString("Enter first name: ");
                string lastName = MyConsole.PromptString("Enter last name: ");
                string email = MyConsole.PromptString("Enter email: ");
                string phonenum = MyConsole.PromptString("Enter phone: ");
                MyConsole.PrintLine("");
                MyConsole.PrintLine("--------------------------------------------");
                MyConsole.PrintLine("---- Current Contact -----------------------");
                MyConsole.PrintLine("--------------------------------------------");
                MyConsole.Print("Name: \t \t");
                MyConsole.Print(firstName+" "+lastName);
                MyConsole.Print("\nEmail: \t \t");
                MyConsole.Print(email);
                MyConsole.Print("\nPhone Number: \t");
                MyConsole.Print(phonenum);
                MyConsole.PrintLine("\n--------------------------------------------");
                MyConsole.PrintLine("");
                choice = MyConsole.PromptString("Continue? (y/n): ");
            }




            MyConsole.Print("Goodbye!~");
        }
    }
}
