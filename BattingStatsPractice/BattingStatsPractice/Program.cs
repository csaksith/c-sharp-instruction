using ConsoleLibrary;

namespace BattingStatsPractice {
    internal class Program {
        static void Main(string[] args) {
            MyConsole.PrintLine("Welcome to Batting Average Calculator!!~\n");
            string choice = "y";
            while (choice=="y") {
                int numberAtBat = MyConsole.PromptInt("Enter number of times at bat: ",1,30);
                int[] atBat = new int[numberAtBat];
                int countAtBat = 0;
                int sumAtBat = 0;
                MyConsole.PrintLine("""
                0 = out, 1 = single, 2 = double, 3 = triple, 4 = home
                run
                """);
                double battingAvg = 0;
                double sluggingPct=0;
                for (int i = 0; i<numberAtBat; i++) {

                    int resultAtBat = MyConsole.PromptInt("Result for at-bat: "+(i+1)+":",0,4);

                    atBat[i]=resultAtBat;

                    if (resultAtBat>0) {
                        countAtBat++;
                    }
                    sumAtBat+=resultAtBat;
                }
                // batting avg = countAtBat / numberAtBat
                battingAvg=(double)countAtBat/numberAtBat;
                MyConsole.PrintLine($"Batting Average: {battingAvg.ToString("f3")}");

                // sluggingPct = atBatSum / numberAtBat
                sluggingPct=(double)sumAtBat/numberAtBat;
                MyConsole.PrintLine($"Slugging Percent: {sluggingPct.ToString("f3")}");
            }

            choice=MyConsole.PromptReqString("Another player? (y/n): ","y","n");
        }
    }
}

