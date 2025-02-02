using System;

class Program
{
    static void Main()
    {
Console.WriteLine("Welcome to the Letter Grade Converter");
string choice = "y";
while (choice == "y") 

{
Console.WriteLine("Enter numerical grade: ");
int grade;

//validate input
 while (!int.TryParse(Console.ReadLine(), out grade) || grade < 0 || grade > 100)
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
                Console.Write("Enter numerical grade: ");
            }

string letterGrade;
    if (grade >= 88){
        letterGrade = "A";   
    }
    else if (grade >= 80){
        letterGrade = "B";
    }
    else if (grade >= 68){
        letterGrade = "C";
    }
    else if (grade >= 60){
        letterGrade = "D";
    }
    else{
        letterGrade = "F";
    }
 
Console.WriteLine("Letter grade: "+ letterGrade);
Console.WriteLine("Continue? (y/n): ");
choice = Console.ReadLine().ToLower();
}
Console.WriteLine("Goodbye!");
    }
}