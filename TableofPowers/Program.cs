namespace TableofPowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Squares and Cubes Table");

            string choice = "y";
            while (choice == "y")
            {
                Console.WriteLine("Enter an integer: ");
                int integer = Int32.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Number\tSquared\tCubed");
                Console.WriteLine("======\t=======\t=====");
                int number = 1;
                while (number <= integer)
                {
                    Console.WriteLine($"{number}\t{number * number}\t{number * number * number}");
                    number++;
                }
                Console.WriteLine("Continue? (y/n): ");
                choice = Console.ReadLine().ToLower();
            }
            Console.WriteLine("Goodbye!");
        }
    }
}
