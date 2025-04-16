namespace PigDice {
    internal class GameClass {
        public DieClass die;
        public int totalScore;
        public int rollsCount;
        public int[] rollFrequencies;
        public GameClass() {
            die=new DieClass();
            totalScore=0;
            rollsCount=0;
            rollFrequencies=new int[7];
            // index 1-6 represents dice numbers
        }
        public int Play() {
            Console.WriteLine("\nStarting a new game.... Rolling the die!~");
            bool isValid = false;
            while (!isValid) {
                int roll = die.Roll();
                rollsCount++;
                rollFrequencies[roll]++; // increment count at the rolled number index
                Console.WriteLine($"Rolled: {roll}");
                if (roll==1) {
                    Console.WriteLine($"Game over! Total Score: {totalScore}, Rolls: {rollsCount}");
                    break;
                }
                totalScore+=roll;
            }
            return totalScore;
        }
        public int GetRollsCount() {
            return rollsCount;
        }
        public int[] GetRollFrequencies() {
            return rollFrequencies;
        }
    }
}


