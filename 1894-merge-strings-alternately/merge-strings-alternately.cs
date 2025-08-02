public class Solution {
    public string MergeAlternately(string word1, string word2) {
        string result = "";
        bool turn = false;
        int j = 0;
        int k = 0;
        int size = word1.Length + word2.Length;


        //Doing this with List can be a good option
        
            for(int i = 0; i < size ; i++)
            {
                if(turn == false && k != word1.Length)
                {
                        result = result + word1[k];
                        turn = true;   
                        k++;   

                } else if(turn == true && j != word2.Length) {
                        result = result + word2[j];
                        turn = false;
                        j++;
                } else if(k < word1.Length)
                {
                    result = result + word1[k];
                    k++;
                } else if(j < word2.Length){
                    result = result + word2[j];
                    j++;
                }
            }  

        return result;

    }
}