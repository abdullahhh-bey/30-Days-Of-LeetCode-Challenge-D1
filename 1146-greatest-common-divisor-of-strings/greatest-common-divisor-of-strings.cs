public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        int size1 = str1.Length;
        int size2 = str2.Length;

        if(str1 + str2 != str2 + str1)
        {
            return "";
        }

        if(size2 != 0)
        {
            while(size2 != 0 )
            {
                int temp = size2;
                size2 = size1 % size2;
                size1 = temp;
            }

            string result = str1.Substring(0, size1);
            return result;

        } else{
            return "";
        }    



    }
}