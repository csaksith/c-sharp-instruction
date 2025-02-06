namespace Ch7ExceptionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to the Chapter 7 Exceptions and data validation!");

            Console.Write("Enter an integer: ");
            int nbr1 = 0;
            while (true)
            {
                if (!Int32.TryParse(Console.ReadLine(), out nbr1))
                {
                    Console.WriteLine("Error: enter whole number.");

                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("You entered: " + nbr1);
                Console.WriteLine("Goodbye!");

            }
        }
    }
