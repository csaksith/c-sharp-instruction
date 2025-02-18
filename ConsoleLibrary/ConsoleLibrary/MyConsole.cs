namespace ConsoleLibrary {
    public class MyConsole {
        public static int PromptInt(string prompt) {
            int result = 0;
            bool isValid = false;
            while (!isValid) {
                Print(prompt);
                if (int.TryParse(Console.ReadLine(),out result)) {
                    isValid=true;
                }
                else {
                    PrintLine("Error: invalid integer");
                }
            }
            return result;
        }

        public static double PromptDouble(string prompt) {
            double result = 0;
            bool isValid = false;
            while (!isValid) {
                Print(prompt);
                if (Double.TryParse(Console.ReadLine(),out result)) {
                    isValid=true;
                }
                else {
                    PrintLine("Error - invalid double.");
                }
            }
            return result;
        }

        public static decimal PromptDecimal(string prompt) {
            decimal result = 0m;
            bool isValid = false;
            while (!isValid) {
                Print(prompt);
                if (Decimal.TryParse(Console.ReadLine(),out result)) {
                    isValid=true;
                }
                else {
                    PrintLine("Error - invalid decimal.");
                }
            }
            return result;
        }
        public static string PromptString(string prompt) {
            Print(prompt);
            return Console.ReadLine();
        }

        public static string PromptReqString(string prompt,string str1,string str2) {
            string result = "";
            bool isValid = false;
            while (!isValid) {
                result=PromptString(prompt);
                if (result.Trim()!="") {
                    if (result==str1||result==str2) {
                        isValid=true;
                    }
                    else {
                        PrintLine("Error - string must be either "+str1+" or "+str2);
                    }
                }
                else {
                    PrintLine("Error - Entry is required.");
                }
            }
            return result;
        }

        public static void Print(string message) {
            Console.Write(message);
        }
        public static void PrintLine(string message = "") {
            Console.WriteLine(message);
        }
    }
}