namespace GuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Guess the Number Game!!");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("");
            Console.WriteLine("I'm thinking of a number from 1 to 100.");
            Console.WriteLine("Try to guess it.");
            Console.WriteLine("");
            Random rand = new Random();
            int num = Num(rand); // put random num outside loop so it doesn't regenerate random number everytime. 
            string choice = "y";
            while (choice == "y")
            {
                // enter number (guess)
                Console.WriteLine("Enter number: ");
                int guess = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Guess: " + guess);
                Console.WriteLine("Random Number: " + num);
                if (guess == num)
                {
                    Console.WriteLine("Great work! You are a mathematical wizard.");
                }
                // increment count
                // output message 
                // try again? 
                Console.WriteLine("Try again? (y/n): ");
                choice = Console.ReadLine().ToLower();
            }
            Console.WriteLine("Goodbye!!");
        }
        static int Num(Random rand)
        {
            return rand.Next(1, 100);
        }

    }
}
