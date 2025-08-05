using System.Text.RegularExpressions;

public class Solution {
    public bool IsPalindrome(string s) {
        //Converting into Lowercase
        //Removed the non-alphanumerci characters
        string cleanedStr = Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLower();
        //Declared a array of characters for storing the reverse of cleanedStr
        List<char> reverseStr = new List<char>();
        List<char> updated = new List<char>();

        reverseStr = cleanedStr.ToList();

        if(reverseStr.Count == 0 || reverseStr.Count == 1)
        {
            return true;
        }


        for(int  i = cleanedStr.Length - 1 ; i >= 0 ; i-- )
        {
            updated.Add(reverseStr[i]);
        }

    

        if(new string(reverseStr.ToArray()) == new string(updated.ToArray()))
        {
            return true;
        } else{
            return false;
        }

    }
}