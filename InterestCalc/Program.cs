namespace InterestCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Interest Calculator");

            string choice = "y";
            while (choice == "y")
            {
                Console.WriteLine("Enter loan amount: ");
                double loanAmt = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter interest rate: ");
                decimal intRate = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Loan amount: " + loanAmt);
                Console.WriteLine("Interest rate: " + (intRate * 100));
                double interest = loanAmt * (double)intRate;
                Console.WriteLine("Interest: " + interest);
                Console.WriteLine("Continue? (y/n): ");
                choice = Console.ReadLine();
            }


            Console.WriteLine("Goodbye!");
        }
    }
}
