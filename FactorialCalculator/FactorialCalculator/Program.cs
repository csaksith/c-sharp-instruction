namespace FactorialCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Factorial Calculator!!");
            Console.WriteLine("");
            string choice = "y";
            while (choice == "y")
            {
                // initialize integer and factorial number
                int i;
                int integer = 1;
                int fact = 1;

                {
                    Console.Write("Enter an integer that's greater than 0 and less than 10: ");
                    integer = Int32.Parse(Console.ReadLine());
                    //executes i = 1 once, then i <= integer defines the conditoin, and i++ is executed every time after
                    for (i = 1; i <= integer; i++)
                    { fact = fact * i; }

                    Console.WriteLine("The factorial of " + integer + " is " + fact + ".");

                    Console.Write("Continue? (y/n): ");
                    choice = Console.ReadLine();
                }
                // user input integer between 0 - 10
                // output of factorial of integer 
                // continue? 

            }
            Console.WriteLine("Goodbye!!");
        }
    }
}
