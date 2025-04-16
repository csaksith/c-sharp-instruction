
namespace PigDice {
    internal class DieClass {
        public static Random rand = new Random();
        // use static so we don't reset random number each roll
        public int Roll() {
            return rand.Next(1,7);
        }
    }
}
