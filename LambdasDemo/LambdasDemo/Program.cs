using ConsoleLibrary;

namespace LambdasDemo {

    internal class Program {

        private static void Main(string[] args) {
            MyConsole.PrintLine("Welcome to the Lambda Demos~!\n");
            List<int> numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10 };
            // display the numbers from the list in one line in the console
            DisplayListAsString(numbers,"Original List");
            // create a new list called squaredNums1
            List<int> squaredNums1 = new List<int>() { };
            foreach (int number in numbers) {
                squaredNums1.Add(Square(number));
            }
            DisplayListAsString(squaredNums1,"Squared List (1) - using a for loop: ");

            // do this again using method as a parameter
            List<int> squares2 = numbers.Select(Square).ToList();
            DisplayListAsString(squares2,"Squared List (2) - using a method as a parameter ");

            // do this again using a lambda expression
            List<int> squares3 = numbers.Select(x => x*x).ToList();
            DisplayListAsString(squares3,"Squared List (3) - using a lambda expression ");
            // store the squared versions of all numbers
            // create a new list called divThree1
            List<int> divThree1 = new List<int>();
            foreach (int number in numbers) {
                if (IsDivisibleByThree(number)) {
                    divThree1.Add(number);
                }
            }
            DisplayListAsString(divThree1,"Numbers Divisible by Three List");
        // Create a new list called divThree2 using FindAll method
       List<int> divThree2 = numbers.FindAll(IsDivisibleByThree).ToList();

        DisplayListAsString(divThree2, "Numbers Divisible by Three List (2)");

        // Create a new list called divThree3 using a lambda expression
         List<int> divThree3 = numbers.Where(x => IsDivisibleByThree(x)).ToList();

        DisplayListAsString(divThree3, "Numbers Divisible by Three List (3)");
        }
        private static bool IsDivisibleByThree(int x) {
            return x%3==0;
        }

        private static int Square(int nbr) {
            return nbr*nbr;
        }

        private static void DisplayListAsString(List<int> numbers,string header) {
            string result = "========================================\n";
            result+=header+"\n";
            result+="========================================\n";
            foreach (var value in numbers) {
                result+=value.ToString()+" ";
            }
            result+="\n";
            MyConsole.PrintLine(result);
        }
    }
}