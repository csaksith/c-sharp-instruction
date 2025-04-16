using ConsoleLibrary;

namespace Ch8CountryListManagerPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to the Country List Manager ~\n");

            MyConsole.PrintLine("""
                COMMAND MENU
                1 - List countries
                2 - Add a country
                3 - Exit
                """);

            MyConsole.PromptInt("Enter menu number\n",1,3);
            List<string> countries = new List<string>();

            int menuNum = 0;
            while (menuNum!=3) {
               menuNum=MyConsole.PromptInt("Enter menu number: \n",1,3);
            }



            MyConsole.PrintLine("\nGoodbye.");
        }
    }
}
