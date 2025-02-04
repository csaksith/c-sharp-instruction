using System.Numerics;

namespace TravelTimeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Travel Time Calculator!");

            string choice = "y";
            while (choice == "y")
            {
                // while choice == y or Y
                // get input: miles, mph
                Console.WriteLine("Enter miles: ");
                double miles = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter mph: ");
                double mph = Double.Parse(Console.ReadLine());

                // biz logic: hours and minutes (whole numbers)
                // totaltime: dfouble = miles/mph
                // hours: int = (int)totaltime (casting)
                // minutes: int = (int)((miles % mph) * 60)
                double totalTime = miles / mph;
                int hours = (int)totalTime;
                int remainder = (int)(miles % mph);
                int minutes = (int) (remainder / mph * 60);


                // Console.WriteLine(remainder);
                Console.WriteLine("Hours: "+ hours);
                Console.WriteLine("Minutes: " + minutes);


                // display output

                // prompt continue



                Console.WriteLine("Continue? (y/n): ");
                choice = Console.ReadLine().ToLower();

                Console.WriteLine("Goodbye!");
            }
        }
    }
}