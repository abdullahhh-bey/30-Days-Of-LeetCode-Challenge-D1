public class Solution {
    public int MissingNumber(int[] nums) {
        List<int> n = nums.ToList();

        //Logic is to check each elemtn in the list 
        //If it didnt found, then return the elemtn
        for(int j = 1 ; j <= n.Count ; j++)
        {
            if(!n.Contains(j))
            {
               return j;
            }
        }

        //Return 0 if the result is not found
        return 0;

    }
}