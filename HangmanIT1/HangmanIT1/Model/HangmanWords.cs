using ConsoleLibrary;

namespace HangmanIT1.Model {
    internal class HangmanWords {
        // declare dictionary of words
        private List<string> words;
        // constructor for words
        public HangmanWords() {
            words=new List<string> { "pizza","sushi","steak","pasta","tacos","salad","ramen" };
        }
        // method to get random word from the list
        public string GetRandomWord() {
            Random random = new Random();
            int index = random.Next(words.Count);
            return words[index];
        }
        // method to convert random word to underscores
        public string GetHiddenWord(string word) {
            string hiddenWord = "";
            for (int i = 0; i<word.Length; i++) {
                hiddenWord+="_ ";
            }
            return hiddenWord;
        }
    }
}

