namespace GuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print("Welcome to the Guess the Number Game!!");
            Print("++++++++++++++++++++++++++++++++++++++");
            Print("");
            Print("I'm thinking of a number from 1 to 100.");
            Print("Try to guess it.");
            Print("");
            Random rand = new Random();
            int num = Num(rand); // put random num outside loop so it doesn't regenerate random number everytime. 
            string choice = "y";
            while (choice == "y")
            {
                int attempts = 0;
                {
                    while (true) // loops until the correct guess
                    {
                        // enter number (guess)

                        int guess = GetGuess();
                        Print("Number: " + num);
                        attempts++;
                        if (guess >= num + 10)
                        {
                            Print("Way Too High!");
                        }
                        else if (guess <= num - 10)
                        {
                            Print("Way Too Low!");
                        }
                        else if (guess < num)
                        {
                            Print("Too Low!");
                        }
                        else if (guess > num)
                        {
                            Print("Too High!");
                        }

                        else
                        {
                            if (attempts <= 3)
                            {
                                Print("You got it in " + attempts + " tries.");
                                Print("Great work! You are a mathematical wizard.");
                            }
                            else if (attempts <= 7)
                            {
                                Print("You got it in " + attempts + " tries.");
                                Print("Not too bad! You've got some potential.");
                            }
                            else
                            {
                                Print("You got it in " + attempts + " tries.");
                                Print("What took you so long? Maybe you should take some lessons.");
                            }

                        }
                        // increment count
                        // output message 
                        // try again? 
                        
                    }
                    Print("Try again? (y/n): ");
                    choice = Console.ReadLine().ToLower();
                }
            }
            Print("Goodbye!!");
            static int Num(Random rand)
            {
                return rand.Next(1, 101);
            }
            static void Print(string msg) 
            { 
                Console.WriteLine(msg); 
            }
            static int GetGuess()
            {
                Print("Enter number: ");
                return int.Parse(Console.ReadLine());
            }
        }
    }
}
