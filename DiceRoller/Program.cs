namespace DiceRoller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dice Roller");
            string choice = "y";
            while (choice == "y")
            {
                string dice = GetString("Roll the dice? (y/n) ");
                int d1 = GetDie("Die 1: ");
                int d2 = GetDie("Die 2: ");







                choice = GetString("Continue? (y/n): ");
            }
            Console.WriteLine("Goodbye!");
        }

        static int GetInt(string prompt)
        {
            Print(prompt, "");
            return Int32.Parse(Console.ReadLine());
        }
        static string GetString(string prompt)
        {
            Print(prompt, "");
            return Console.ReadLine();
        }
        static void Print(string msg, string endLine = "\n")
        {
            Console.Write(msg + endLine);
        }
        static Random random = new Random(); // declare a static Random instance to reuse 
        static int GetDie(string prompt)
        {
            int roll = (int)random.Next(1, 7); // generate a number between 1 and6
            Print(prompt + " " + roll);
            return roll;
        }
    }
}
