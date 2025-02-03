using System;
using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Area and Perimeter Calculator");
        String choice = "y";
        while (choice == "y")
    {   
        Console.WriteLine("Enter length: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter width: ");
        double width = Convert.ToDouble(Console.ReadLine());

        double area = length*width;
        Console.WriteLine($"Area: "+ area.ToString("0.0"));

        double perimeter = (length*2)+(width*2);
        Console.WriteLine($"Perimeter: " + perimeter.ToString("0.0"));
    
        Console.WriteLine("Continue? (y/n): ");
        choice = Console.ReadLine().ToLower();
    }        
        Console.WriteLine("Goodbye!");
    }
}