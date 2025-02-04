namespace TravelTimeCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Travel Time Calculator");
        string choice = "y";
            while (choice == "y")
            {
                Console.WriteLine("Enter miles: ");
                double miles = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter miles per hour: ");
                double mph = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Estimated travel time");
                Console.WriteLine("----------------------");

                double totalTime = miles / mph;
                int hours = (int)totalTime; // get whole number of hours
                int minutes = (int)((totalTime - hours) * 60); // get the decimal part and convert to minutes
                Console.WriteLine("Hours: " + hours);

                // Get the remaining minutes after dividing miles by mph
                Console.WriteLine("Minutes: " + minutes);

                Console.WriteLine("Continue? (y/n): ");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Goodbye!!");
        }
    }
}