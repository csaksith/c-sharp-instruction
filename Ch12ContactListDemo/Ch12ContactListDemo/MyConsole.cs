namespace Ch12ContactListDemo {
    public class MyConsole {
        public static int PromptInt(string prompt) {
            int result = 0;
            bool isValid = false;
            while (!isValid) {
                Print(prompt);
                if (Int32.TryParse(Console.ReadLine(),out result)) {
                    isValid=true;
                }
                else {
                    PrintLine("Error: invalid integer");
                }
            }
            return result;
        }
        public static string PromptString(string prompt) {
            Print(prompt);
            return Console.ReadLine();
        }
        public static void Print(string message) {
            Console.Write(message);
        }
        public static void PrintLine(string message) {
            Console.WriteLine(message);
        }
    }
}
