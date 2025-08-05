using System.Text.RegularExpressions;

public class Solution {
    public bool IsPalindrome(string s) {
        //Converting into Lowercase
        //Removed the non-alphanumerci characters
        string cleanedStr = Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLower();
        //Declared a List of characters for storing the reverse of cleanedStr
        List<char> reverseStr = new List<char>();
        List<char> updated = new List<char>();

        //converted the string into list for comparison
        reverseStr = cleanedStr.ToList();

        //Validation
        if(reverseStr.Count == 0 || reverseStr.Count == 1)
        {
            return true;
        }

        //Main logic is to copy the s in reverse and store it in updated list
        for(int  i = cleanedStr.Length - 1 ; i >= 0 ; i-- )
        {
            updated.Add(reverseStr[i]);
        }

    
        //Compare both list but before comparison
        //COnvert the List to Array and then to string
        if(new string(reverseStr.ToArray()) == new string(updated.ToArray()))
        {
            return true;
        } else{
            return false;
        }

    }
}