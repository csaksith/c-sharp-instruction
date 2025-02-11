using Ch07GradeConverter;

namespace Ch7GradeConverter {
    internal class Program {
        static void Main(string[] args) {
            MyConsole.PrintLine("Welcome to the Letter Grade Converter~!");
            string choice = "y";
            while (choice=="y") {
                int numGrade = MyConsole.PromptInt("Enter numerical grade: ");
                if (numGrade>88) {
                    string letterGrade = "A";
                    MyConsole.PrintLine($"Letter Grade: {letterGrade}");
                }
                else if (numGrade>=80) {
                    string letterGrade = "B";
                    MyConsole.PrintLine($"Letter Grade: {letterGrade}");
                }
                else if (numGrade>=67) {
                    string letterGrade = "C";
                    MyConsole.PrintLine($"Letter Grade: {letterGrade}");
                }
                else if (numGrade>=60) {
                    string letterGrade = "D";
                    MyConsole.PrintLine($"Letter Grade: {letterGrade}");
                }
                else if (numGrade<60) {
                    string letterGrade = "D";
                    MyConsole.PrintLine($"Letter Grade: {letterGrade}");
                }
                else {
                    MyConsole.PrintLine("Error! This entry is required. Try again.");
                }

                choice=MyConsole.PromptString("Continue? (y/n): ");
                while (choice!="y"&&choice!="n") {
                    MyConsole.PrintLine("Error! Entry must be 'y' or 'n'. Try again.");
                choice=MyConsole.PromptString("Continue? (y/n): ");

            }
        }
        MyConsole.PrintLine("Goodbye!");
        }
}
}
