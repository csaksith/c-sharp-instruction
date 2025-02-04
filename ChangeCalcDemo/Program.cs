namespace ChangeCalcDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Change Calculator!");

            string choice = "y";
            while (choice == "y") {
            // while
            // get input - cents: int
            Console.WriteLine("Enter number of cents (0-99): ");
            int cents = Int32.Parse(Console.ReadLine());
            // biz logic:
            // - quarters: int = cents / 25 
            int quarters = cents / 25;
            // - cents = cents % 25
            cents = cents % 25;
            // - dimes: int = cents / 10
            int dimes = cents / 10;
            // - cents = cents % 10 
            cents %= 10;
            // - nickels: int = cents / 5
            int nickles = cents / 5;
            // - pennies: int = cents % 5
            int pennies = cents % 5;

            Console.WriteLine();
            Console.WriteLine("Quarters: " + quarters);
            Console.WriteLine("Dimes: " + dimes);
            Console.WriteLine("Nickels: " + nickles);
            Console.WriteLine("Pennies: " + pennies);
            Console.WriteLine();
            Console.WriteLine("Continue? (y/n): ");

        }

        Console.WriteLine("Goodbye!");
        }
}
}
