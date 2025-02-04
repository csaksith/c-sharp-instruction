namespace ChangeCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Change Calculator");

            string choice = "y";
            while (choice == "y")
            {
                Console.WriteLine("Enter number of cents (0-99): ");
                int cents = Convert.ToInt32(Console.ReadLine());

                int quarters = cents / 25;
                Console.WriteLine("Quarters: " + quarters);
                cents = cents % 25;

                int dimes = cents / 10;
                Console.WriteLine("Dimes: " + dimes);
                cents = cents % 10;

                int nickels = cents / 5;
                Console.WriteLine("Nickels: " + nickels);
                cents = cents % 5;

                int pennies = cents / 1;
                Console.WriteLine("Pennies: " + pennies);


                Console.WriteLine("Continue? (y/n): ");
                choice = Console.ReadLine();
            }

            Console.WriteLine("Goodbye!");
        }
    }
}
