namespace Ch7FactorialCalcDemo {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Factorial Calculator!~");
            // while - choice
            string choice = "y";
            while (choice=="y") {
                // get input theNumber: long
                // - 0 < theNumber < 10
                //long theNumber = GetLong("Enter an integer that's greater than 1 and less than 10: ",1,1000);
                //// compute the factorial with for loop - factorial: long
                //// for i = 1, i <= theNumber, i++ ==> factorial = factorial * i
                //long theFactorial = 1;
                //for (int i = 1; i<=theNumber; i++) {
                //    //theFactorial = theFactorial * i;
                //    theFactorial *= i;
                //}
                long theFactorial = 1;
                for (int i = 1; theFactorial>0; i++) {
                    theFactorial*=i;
                    Console.WriteLine("i: "+i+", factorial: "+theFactorial);
                }
                //Console.WriteLine("The factorial of "+theNumber+" is "+theFactorial+".");
                // starts with 1 not 0 because it will be = to 0
                Console.Write("Continue? (y/n): ");
                choice=Console.ReadLine().ToLower();
            }
            Console.WriteLine("Goodbye!!");
        }
        private static long GetLong(string prompt,long min,long max) {
            long result = 0;
            bool isValid = false;
            while (!isValid) {
                Console.Write(prompt);
                if (!long.TryParse(Console.ReadLine(),out result)) {
                    Console.WriteLine("Error: invalid whole number. Try again.");
                    continue;
                }

                if (result<min||result>max) {
                    Console.WriteLine("Error: input must be within range "+min+"-"+max+". Try again.");
                }
                else {
                    isValid=true;

                }
            }
            return result;
        }
    }
}
