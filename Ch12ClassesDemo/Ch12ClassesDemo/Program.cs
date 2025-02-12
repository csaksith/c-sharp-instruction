namespace Ch12ClassesDemo {
    internal class Program {
        
        static void Main(string[] args) {
            Console.WriteLine("Welcome to Chapter 12 - Class Demo!");

            // capture input for properties of a movie
            string title = PromptString("Movie Title: ");
            int year = PromptInt("Year: ");
            string ageRating = PromptString("Age Rating: ");
            string director = PromptString("Director: ");

            Movie newMovie = ?????

            // stpre this movie and capture a new one
            // repeat until user is done entering movies
            // display all movies


            Console.WriteLine("BYE!");
        }

        static int PromptInt(string prompt){
            int result = 0;
            bool isValid = false;
            while (!isValid) {
                Print(prompt);
                if (Int32.TryParse (Console.ReadLine(),out result)){
                    isValid = true;
                }
                else{
                    PrintLine("Error - invalid int");
                }
            }
            return result;
        }

        static string PromptString(string prompt) {
            Print(prompt);
            return Console.ReadLine();
        }

       static void Print(string msg){
            Console.Write(msg);
        }

        static void PrintLine(string msg){
            Console.WriteLine(msg);
        }
    }
}
