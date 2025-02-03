// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the Temperature Converter");

string choice = "y"; 
while (choice == "y"){
    Console.WriteLine("Enter degrees in Fahrenheit: ");
    double tempF = double.Parse(Console.ReadLine());
    double tempC = (tempF - 32)*(5.0/9);
    Console.WriteLine("Degrees in Celsius: " + tempC.ToString("0.00"));  
     Console.WriteLine("Continue? (y/n): ");
     choice = Console.ReadLine();
   }

Console.WriteLine("Goodbye!");
