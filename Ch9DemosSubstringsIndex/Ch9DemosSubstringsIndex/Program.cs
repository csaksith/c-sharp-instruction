using ConsoleLibrary;

namespace Ch9DemosSubstringsIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Hello, World!");

            string letters = "abcdefg";
            string first3Letters = letters.Substring(0,3);
            MyConsole.PrintLine($"first 3 letters: {first3Letters}");

            MyConsole.PrintLine($"next 3 letters: {letters.Substring(3,3)}");
            MyConsole.PrintLine($"next 3 letters: {letters.Substring(6,1)}"); // last character
            MyConsole.PrintLine($"next 3 letters: {letters.Substring(6,1)}");
            string fullName = "Robert Nesta Marley";
            // first, middle, and last anmes
            // where are the spaces?
            int firstSpace = fullName.IndexOf(" ");
            MyConsole.PrintLine($"firstSpace = {firstSpace}"); // 6
            int secondSpace = fullName.IndexOf(" ",firstSpace+1); // output would have been 6 again
            MyConsole.PrintLine($"secondSpace = {secondSpace}"); // 12
            
            string firstName = fullName.Substring(0,firstSpace);
            MyConsole.PrintLine($"firstName = {firstName}.");
            string middleName = fullName.Substring(firstSpace+1,(secondSpace-firstSpace-1));
            MyConsole.PrintLine($"middleName = {middleName}.");
            string lastName = fullName.Substring(secondSpace+1);
            MyConsole.PrintLine($"lastName = {lastName}.");
            MyConsole.PrintLine("Goodbye!");
        }
    }
}
