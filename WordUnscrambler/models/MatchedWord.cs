namespace WordUnscrambler.models
{
    public struct MatchedWord
    {
        // Value types
        // Categorize variables together that makes sense
        public MatchedWord(string scrambledWord, string word)
        {
            ScrambledWord = scrambledWord;
            Word = word;
        }
        
        public string ScrambledWord { get; set; }
        
        public string Word { get; set; }
    }
}