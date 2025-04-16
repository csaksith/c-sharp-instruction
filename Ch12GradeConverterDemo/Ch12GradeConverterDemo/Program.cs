using Ch12GradeConverterDemo;
using ConsoleLibrary;
MyConsole.PrintLine("Welcome to the Grade Converter~");

string choice = "y";
while (choice=="y") {
    // ** ChangeRequest: need My.Console.PromptInt(string prompt, int min,int max)
    // prompt numericGrade: int
    int numericGrade = MyConsole.PromptInt("Enter Numerical Grade: ",0,100);
    // create instance of Grade class
    Grade grade = new Grade(numericGrade);
    // print the letterGrade: string
    MyConsole.PrintLine("Letter grade: "+grade.GetLetter());
    // ** CR: PromptString - validates empty string, y, n
    choice=MyConsole.PromptReqString("Continue? (y/n): ").ToLower();


    MyConsole.PrintLine("Goodbye~");
}
