using ConsoleLibrary;

namespace Ch12GradeConverterPractice {
    internal class Program {
        static void Main(string[] args) {
            MyConsole.PrintLine("Welcome to the Letter Grade Converter!!~\n");

            string choice = "y";
            while (choice=="y") {
                // user inputs numerical grade
                int numGrade = MyConsole.PromptInt("Enter numerical grade: ",0,100);
                // create instance of Grade class 
                Grades grade = new Grades(numGrade);
                // display letter grade 
                MyConsole.PrintLine("Letter grade: "+grade.GradeConverter());
                // continue? (y/n):
                choice=MyConsole.PromptReqString("\nContinue? (y/n): \n","y","n");
            }
            MyConsole.PrintLine("Goodbye for now!!~");
        }
    }
}
