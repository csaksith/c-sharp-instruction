using System.Diagnostics.Metrics;

namespace Ch04DemosNumberStringsDemo {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("2/8/2025 - Welcome to the Number and Strings Demos!");
            int dayOfWeek = 5;
            decimal price = 11.99m;
            int quantity = 3;
            char letter = 'A';
            bool isValid = false;
            quantity='b';
            double interestRate = .0367;

            // constants
            const int DaysInWeek = 7;
            const int DaysInNovember = 30;

            // arithmetic oeprators
            // adition
            decimal lineItemTotal = price*quantity;
            int count = 0;
            Console.WriteLine(count);
            count=count+1;
            Console.WriteLine("count = "+count);
            count++;
            Console.WriteLine("count = "+count);
            // division 
            int a = 9;
            int b = 2;
            int quotient = a/b;
            int remainder = a%b;
            Console.WriteLine("quotient = "+quotient);
            Console.WriteLine("remainder = "+remainder);

            double result = a/b;
            Console.WriteLine("result = "+result);

            double c = 9.0;
            double d = 2.0;
            // decimal math
            result=c/d;
            Console.WriteLine("result = "+result);

            int counter = 10;
            // increment by 1
            counter=counter+1;
            counter++;
            counter+=1;
            // add 5 to counter
            counter=counter+5;
            counter+=5;
            Console.WriteLine("counter = "+counter);
            // subtract 2 from counter
            counter-=2;
            Console.WriteLine("counter = "+counter);
            // casting converting integer to a double
            int e = 5;
            double f = e;

            double g = 6.7;
            // explicit cast force the cast from decimal to integer
            int h = (int)g;
            Console.WriteLine("h = "+h);
            // Math class
            interestRate=.0347825;
            Console.WriteLine("interestRate =  "+interestRate);
            // rounded to  4 decimal places
            interestRate=Math.Round(interestRate,4);
            Console.WriteLine("interestRate = "+interestRate);

            // random number class
            // create an instance of a random
            Random rand = new Random();
            int r1 = rand.Next();
            Console.WriteLine("r1 = "+r1);
            int dieRoll = rand.Next(1,7);
            Console.WriteLine("dieRoll = "+dieRoll);

            // strings
            string firstName = "Bob";
            string lastName = "Marley";
            string fullName = firstName+" "+lastName;
            Console.WriteLine(fullName);

            // escape sequence - tab, newLine, backslash
            string sentence = "abc\tdef\tghi";
            Console.WriteLine("sentence = "+sentence);

            string reposFolder = "c:\\repos";
            Console.WriteLine("repos = "+reposFolder);

            string rawMessage = """
                hello!
                nice to meet you.
                """;
            Console.WriteLine(rawMessage);

            // get input from the console
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            // while loop example
            // execut the 2 numbers and sum until user is done
            string choice = "y";
            while (choice=="y") {
                Console.WriteLine("Enter two whole numbers: ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                int n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("sum = "+(n1+n2));
                Console.WriteLine("Continue? (y/n)");
                choice=Console.ReadLine();
                // the loop will continue until the choice is set to "n"
            }

            // if statement
            // discount percent
            // if amount > 1000, discPct = .10
            // else if amount > 800, discPct = .08
            // else if amount > 500, discPct =.05
            // otherwise discPct = .00
            double amount = 900;
            double discPct = 0.0;
            if (amount>=1000) {
                discPct=.1;
            }
            else if (amount>=800) {
                discPct=.08;
            }
            else if (amount >=500) {
                discPct=.05;
            }
            else {
                discPct=.0;
                // technically you don't need this because we already definied it 
            }
       


            Console.WriteLine("Goodbye!~");

        }
    }
}
