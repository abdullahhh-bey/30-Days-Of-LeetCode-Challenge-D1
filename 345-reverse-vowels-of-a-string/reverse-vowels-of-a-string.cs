public class Solution {
    public string ReverseVowels(string s) {
        char[] str = s.ToCharArray();
        int k = str.Length - 1;
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
        return new string(str);

    }
}