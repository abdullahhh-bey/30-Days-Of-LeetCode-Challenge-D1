public class Solution {
    public string ReverseVowels(string s) {

        //Changing the String to char Array
        //I can also change it to List<char> but the array is better in this case
        char[] str = s.ToCharArray();

        //Declared k for indexing of string from the back
        int k = str.Length - 1;

        //Logic is to Start from the 0th index and check if there is vowel, track from back and check if
        //there is any voiwel, if yes then swap them , do k-- and break the inner loop and 
        //check again fdor the outer loop 
        for(int i = 0 ; i <= k ; i++)
        {
            if(str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' 
            || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
            {
                for(int j = k ; j >= i ; j--)
                {
                    if(str[k] == 'a' || str[k] == 'e' || str[k] == 'i' || str[k] == 'o' || str[k] == 'u'
                    || str[k] == 'A' || str[k] == 'E' || str[k] == 'I' || str[k] == 'O' || str[k] == 'U')
                    {
                        char temp = str[i];
                        str[i] = str[k];
                        str[k] = temp;
                        k--;
                        break;
                    } else{
                        k--;
                    }
                }
            }
        }

        //it returns the char array as a string
        return new string(str);

    }
}