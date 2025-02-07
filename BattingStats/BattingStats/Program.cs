namespace BattingStats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Batting Average Calculator!");
            // arrays exercise
            // user input number of times at bat
            // user input 0 - 4 for each bat

            // output result for at-bat
            // display batting average
            // total number of at bats / number of bats
            // display slugging percent
            // total number of bases / number of bats

            string choice = "y";
            while (choice == "y")
            {
                Console.Write("Enter number of times at bat: ");
                int atBat = Int32.Parse(Console.ReadLine());
                int[] atBatResults = new int[atBat];

                string[] baseResults = { "out", "single", "double", "triple", "home run" };

                for (int i = 0; i < baseResults.Length; i++)
                {
                    Console.Write(baseResults[i] + " = " + i + " ");
                }
                Console.WriteLine();

                for (int i = 0; i < atBat; i++)
                {
                    Console.Write("Result for at-bat " + (i + 1) + ": ");
                    int result;
                    // data validation
                    while (!int.TryParse(Console.ReadLine(), out result) || result < 0 || result > 4)
                    {
                        Console.WriteLine("Invalid Input: Please enter result between 0 and 4.");
                        continue;
                    }
                    // store results in an array
                    atBatResults[i] = result;
                }
                Console.WriteLine();
                int totalBases = 0;
                int hits = 0;
                foreach (int result in atBatResults)
                {
                    totalBases += result;
                    if (result > 0) // at least 1 hit
                        hits++;
                }
                Console.WriteLine("Hits: " + hits);
                Console.WriteLine("Total bases: " + totalBases);
                decimal batAvg = (decimal)hits / atBat;
                decimal slugPct = (decimal)totalBases / atBat;
                Console.WriteLine("Batting average: " + batAvg.ToString("0.00"));
                Console.WriteLine("Slugging percent: " + slugPct.ToString("0.00"));
                Console.WriteLine();
                Console.Write("Another player? (y/n) ");
                choice = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Goodbye!!~");
            Console.ReadLine();

        }

    }
}