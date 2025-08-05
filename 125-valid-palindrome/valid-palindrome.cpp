class Solution {
public:
    bool isPalindrome(string s) {
        //Converting into Lowercase
        //Removed the non-alphanumerci characters
        s = regex_replace(s, regex("[^a-zA-Z0-9]"), "");
        transform(s.begin(), s.end(), s.begin(), ::tolower);

        //Declared a List of characters for storing the reverse of cleanedStr
        vector<char> reverseStr;
        vector<char> updated;

        //converted the string into list for comparison
        reverseStr.assign(s.begin(), s.end());

        //Validation
        if (reverseStr.size() == 0 || reverseStr.size() == 1) {
            return true;
        }

        //Main logic is to copy the s in reverse and store it in updated list
        for (int i = s.length() - 1; i >= 0; i--) {
            updated.push_back(reverseStr[i]);
        }

        //Compare both list but before comparison
        //COnvert the List to Array and then to string
        string original(reverseStr.begin(), reverseStr.end());
        string reversed(updated.begin(), updated.end());

        if (original == reversed) {
            return true;
        }
        else {
            return false;
        }
    }
};