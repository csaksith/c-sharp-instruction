namespace GradeConverterDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Letter Grade Converter");

            String choice = "y";

            // upper or lowercase y is ok
            //while (choice.ToLower() == "y")
            while (choice == "y" || choice== "Y")
            {
                // prompt for input - numericGrade: int
                Console.Write("Enter numeric grade: ");
                // int numericGrade = Convert.ToInt32(Console.ReadLine());
                int numericGrade = Int32.Parse(Console.ReadLine());
                // do business logic
                string letterGrade = "F"; //do not need to do else F because already defaulted to "F"
                // display result - display letterGrade
                if (numericGrade >= 88)
                    letterGrade = "A";
                else if (numericGrade >= 80)
                    letterGrade = "B";
                else if (numericGrade >= 68)
                    letterGrade = "D";
                else if (numericGrade >= 60)
                    letterGrade = "D";

                Console.WriteLine("Letter grade: " +letterGrade);
                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine();

            }
            Console.WriteLine("Bye");
        }
    }
}
