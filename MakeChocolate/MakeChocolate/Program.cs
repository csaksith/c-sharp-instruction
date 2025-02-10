namespace MakeChocolate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int smallWeight = 1;
            const int bigWeight = 5;
            // int small and large quantity and goal in kilos
            Console.WriteLine("mAkE cHoCoLaTe!!!");
            Console.WriteLine();
            Console.WriteLine("enter the number of small chocolate bars: ");
            int small = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number of big chocolate bars: ");
            int big = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Goal kilos: ");
            int goal = Convert.ToInt32(Console.ReadLine());
            // method of public static int makeChocolate(int small, int big, int goal)
            int result = MakeChocolate(small, big, goal);
            // output is the number of bars using the large bars first then small
            if (result!=-1) {
                Console.WriteLine($"You need {result} small bars.");
            }
            else {
                Console.WriteLine("You don't have enough chocolate bars to meet the goal.");
            }
        }
        public static int MakeChocolate(int small,int big,int goal) {
            // caclulate the max number of big bars we can use without exceeding the goal
            // maximum big bars that we can use
            const int smallWeight = 1;
            const int bigWeight = 5;
            int maxBigBars = goal/bigWeight;
            // if there are more big bars than we can use
            if (maxBigBars >big) {
                maxBigBars = big;
            }
            // calculate remaining weight after using the big bars
            int remainingWeight = goal-(maxBigBars*bigWeight);
            Console.WriteLine("remaining weight = "+remainingWeight+" kilos");

            // check if we have enough small bars to meet the remaining weight
            if (remainingWeight<=small) {
                return remainingWeight;
            }
            else {
                return -1;
            }
        }
    }
}
