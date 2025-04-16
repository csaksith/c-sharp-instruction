using Ch07GradeConverter;

namespace Ch7GradeConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to the Letter Grade Converter~!");
            string choice = "y";
            while (choice == "y")
            {
                int numGrade = MyConsole.PromptInt("Enter numerical grade: ");

                // create Grade Object
                Grade grade = new Grade(numGrade);
                MyConsole.PrintLine($"Letter Grade: {grade.GetLetter()}");

                    choice = MyConsole.PromptString("Continue? (y/n): ");
                    while (choice != "y" && choice != "n")
                    {
                        MyConsole.PrintLine("Error! Entry must be 'y' or 'n'. Try again.");
                        choice = MyConsole.PromptString("Continue? (y/n): ");
                    }

                
            }
            MyConsole.PrintLine("Goodbye!");
        }
    }
}
