namespace TipCalcDemo {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Tip Calculator!");

            string choice = "y";
            while (choice=="y") {
                // prompt costOfMeal: decimal
                Console.Write("Cost of Meal: ");
                Console.WriteLine();
                // skipping validation - assuming user enters valid cost
                decimal costOfMeal = decimal.Parse(Console.ReadLine());
                // biz logic: 
                // - calculate tipAmt and totalAmt: decimal and total Amt: decimal for .15, .20, and .25
                // for decimal d = .15m; d <= .25m; d += .05
                for (decimal d = .15m; d<=.25m; d+=.05m) {
                    decimal tipAmt = costOfMeal*d;
                    decimal totalAmt = costOfMeal+tipAmt;
                    Console.WriteLine(d.ToString("p0"));
                    Console.WriteLine("Tip Amount: "+tipAmt.ToString("c"));
                    Console.WriteLine("Total Amount: "+totalAmt.ToString("c"));
                    Console.WriteLine();
                }
                Console.Write("Continue? (y/n) ");
                choice=Console.ReadLine().ToLower();
            }





            Console.WriteLine("Goodbye!");
        }
    }
}
