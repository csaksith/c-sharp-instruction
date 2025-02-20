namespace HangmanIT2.Model {
    internal class HangmanWords {
        // intialize list words
        public List<string> words;
        // constructor for list words
        public HangmanWords() {
            words=new List<string> { "banana","elephant","guitar","puzzle","octopus","mountain","sunflower","chocolate","penguin","butterfly" };

        }
        // method to get random word off list
        // SB QUESTION *** using static I GET THIS ERROR An object reference is required for the non-static field, method, or property 'HangmanWords.words'
        public string GetRandomWord() {
            Random random = new Random();
            // using index to randomize the word array to return
            int index = random.Next(words.Count);
            return words[index];
        }
        // make word into only underlines 
        public string GetHiddenWord(string words) {
            // start with blank string for hidden word
            string hiddenWord = "";
            // create a for loop to print the amount of _ and spaces depending on the length of the word
            for (int i = 0; i<words.Length; i++) {
                hiddenWord+="_ ";
            }
            return hiddenWord;
        }
        // iteration 5
        // method to reveal hidden word by correct letter
        // checks if the guessed letter exists in 'word'
        // replaces the corresponding underscore in 'hiddenWord' with the guessed letter
        // returns the updated hiddenWord
        public string DisplayHiddenWord(string words,string hiddenWord,char guessedLetter) {
            // convert the hidden word (underscores) into char array
            // removes the spaces and also converts to character array
            char[] updatedHiddenWord = hiddenWord.Replace(" ","").ToCharArray();

            // loop through each letter of actual word
            for (int i = 0; i<words.Length; i++) {
                // if guess letter matches the actual word - replace underscore with letter
                if (words[i]==guessedLetter) {
                    updatedHiddenWord[i]=guessedLetter; // replace with letter
                }
            }
            // convert char array back to string with spaces in between letters
            return string.Join(" ",updatedHiddenWord);

        }
    }
}

