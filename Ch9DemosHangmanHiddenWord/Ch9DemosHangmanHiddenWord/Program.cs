using ConsoleLibrary;

namespace Ch9DemosHangmanHiddenWord {
    internal class Program {
        private static void Main(string[] args) {
            MyConsole.PrintLine("Hangman Hidden Word Resolution! ~");

            // Define theWord
            string theWord = "superstitious";
            MyConsole.PrintLine($"The word is {theWord}.");

            // Generate hiddenWord (string with the same length as theWord, all underscores)
            string hiddenWord = new string('_',theWord.Length);
            MyConsole.Print($"HiddenWord = {hiddenWord}");

            // Display the hidden word with spaces separating the underscores
            DisplayHiddenWord(hiddenWord);

            // Resolve correctly guessed letter
            // Prompt user for a letter
            string letter = "";
            bool winner = false;
            while (!winner) {
                letter=MyConsole.PromptString("Guess a letter: ");
                char[] charsTheWord = theWord.ToCharArray();
                char[] charsHiddenWord = hiddenWord.ToCharArray();
                // Iterate over theWord to find any matches for letter
                for (int i = 0; i<charsTheWord.Length; i++) {
                    char c = charsTheWord[i];
                    if (letter.Equals(c.ToString())) {
                        MyConsole.PrintLine($"Letter Found! {i}");
                        // Resolve this character in hiddenWord
                        charsHiddenWord[i]=c;
                    }
                }
                hiddenWord=new string(charsHiddenWord);
                
                // Display the updated hidden word
                DisplayHiddenWord(hiddenWord);
            }
        }

        private static void DisplayHiddenWord(string hiddenWord) {
            MyConsole.PrintLine("\nDISPLAY HIDDEN WORD:");
            foreach (char c in hiddenWord) {
                MyConsole.Print(c+" ");
            }
            MyConsole.PrintLine(); // Add a new line after displaying the hidden word
        }
    }
}