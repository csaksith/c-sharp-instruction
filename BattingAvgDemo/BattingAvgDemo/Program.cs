namespace BattingAvgDemo {
    internal class Program {
        static void Main(string[] args) {
            Print("Welcome to the Batting Average Caclulator!\n");

            // while choice = "y"
            string choice = "y";
            while (choice=="y") {
                int nbrAtBat = PromptInt("Enter number of times at bat: ",1,30);
                // create array => atBat: int[nbrAtBat]
                int[] atBat = new int[nbrAtBat];
                int countAtBat = 0;
                int sumAtBat = 0;
                // for i = 0; i<nbrAtBat; i++ -- always start at 0 for an array
                for (int i = 0; i<nbrAtBat; i++) {
                    // prompt user => nbrAtBat: int
                    // prompt user => result: int (result for atBat)
                    int result = PromptInt("Result for at-bat: "+(i+1)+": ",0,4);
                    atBat[i]=result;
                    if (result>0) {
                        countAtBat++;
                    }
                    sumAtBat+=result;
                }
                // biz logic:
                // battingAvg: double = (count atBat>0) / nbrAtBat
                // sluggingPct: double = (atBatSum) / nbrAtBat
                double battingAvg = (double)countAtBat/nbrAtBat; // decimals typically for currency
                double sluggingPct = (double)sumAtBat/nbrAtBat;
                // display results - formatting: 3 decimal places
                Print("\nBatting Average: "+battingAvg.ToString("F3"));
                Print("Slugging Percent: "+sluggingPct.ToString("F3"));
                // prompt another player?
                Console.Write("Another player? (y/n): ");
                choice=Console.ReadLine().ToLower();
            }
            Print("Goodbye!~");
        }



        static int PromptInt(string prompt,int min,int max) {
            int result = 0;
            bool isValid = false;

            while (!isValid) {
                // get a valid input -- TryParse?
                // declare variable first (result)
                Console.Write(prompt);
                if (Int32.TryParse(Console.ReadLine(),out result)) {
                    // if valid - validate in range
                    if (result>=min&&result<=max) {
                        isValid=true;
                    }
                    else {
                        Print("Error: must be within range.");
                    }
                }
                else {
                    // if not valid - display a message
                    Print("Error: entry must be an integer.");
                }
            }
            return result;
        }
        

        static void Print(string message) {
            Console.WriteLine(message);
        }


    }
}