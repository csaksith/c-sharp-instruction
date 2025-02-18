namespace HangmanIT1.Model {
    internal class HangmanWords {
        // declare dictionary of words
        private List<string> words;
        public HangmanWords() {
        words = new List<string> { "pizza","sushi","steak","pasta","tacos" };
        }

        public string GetRandomWord() {
            Random random = new Random();
            int index = random.Next(words.Count);
            return words[index];
        }
    }
   
}
  
