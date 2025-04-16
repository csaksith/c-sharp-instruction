using System.Diagnostics;

namespace PigDice {
    internal class GameStats {
        int totalGame;
        int totalRolls;
        int highestScore;
        int mostRollsInGame;
        int[] overallRollFrequencies;
        Stopwatch stopwatch;
        int totalScore;

        public GameStats() {
            totalGame=0;
            totalRolls=0;
            highestScore=0;
            mostRollsInGame=0;
            totalScore=0;
            overallRollFrequencies=new int[7];
            stopwatch=new Stopwatch();
        }

        public void StartTrackingTime() {
            stopwatch.Start();
        }

        public void StopTrackingTime() {
            stopwatch.Stop();
        }

        public void UpdateStats(GameClass gameClass) {
            int score = gameClass.Play();
            int rolls = gameClass.rollsCount;
            int[] rollFrequencies = gameClass.GetRollFrequencies();

            totalGame++;
            totalRolls+=rolls;
            totalScore+=score;

            if (score>highestScore) {
                highestScore=score;
            }
            if (rolls>mostRollsInGame) {
                mostRollsInGame=rolls;
            }

            // update frequency count for total roll
            for (int i = 1; i<=6; i++) {
                overallRollFrequencies[i]+=rollFrequencies[i];
            }
        }
        public void DisplayStats() {
            MyConsole.PrintLine("\n=============================================");
            MyConsole.PrintLine($"Final Statistics: ");
            MyConsole.PrintLine($"Total Games Played: {totalGame}");
            MyConsole.PrintLine($"Highest Score: {highestScore}");
            MyConsole.PrintLine($"Total Score: {totalRolls}");
            MyConsole.PrintLine($"Most Rolls in a Single Game: {mostRollsInGame}");
           
        }

    }
}
