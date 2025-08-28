public class Solution {
    public bool WordPattern(string pattern, string s) {
        //We will use disctionary because here we need to map the letter
        //to exactly one word and vice versa

        //At first, checking the Count of both strings
        string[] words = s.Split(' ');
        if(words.Length != pattern.Length)
            return false;

        Dictionary<char, string> charToWord = new Dictionary<char,string>();
        Dictionary<string, char> wordToChar = new Dictionary<string,char>();

        for(int i = 0 ; i < pattern.Length ; i++){
            char letter = pattern[i];
            string word = words[i];

            if(charToWord.ContainsKey(letter)){
                if(charToWord[letter] != word){
                    return false;
                }
            } else {
                if(wordToChar.ContainsKey(word)){
                    return false;
                }

                charToWord[letter] = word;
                wordToChar[word] = letter; 
            }
        }

        //return true if no duplication exists
        return true;

    }
}