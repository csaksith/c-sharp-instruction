namespace TempConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Temperature Converter");
            string choice = "y";
            while (choice.ToLower() == "y")
            {
                // prompt for temp input in fahrenheit
                Console.WriteLine("Enter degrees in Fahrenheit: ");
                double tempF = double.Parse(Console.ReadLine());
                // convert to celsius
                double tempC = ((tempF - 32) * (5.0 / 9));
                Console.WriteLine("Degrees in Celsius: " + tempC.ToString("0.00"));
                Console.WriteLine("Continue? (y/n): ");
                choice = Console.ReadLine();
            }
                Console.WriteLine("Goodbye");
            }
        }
    }
