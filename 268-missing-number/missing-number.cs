public class Solution {
    public int MissingNumber(int[] nums) {
        List<int> n = nums.ToList();

        int result = 0;

        for(int j = 1 ; j <= n.Count ; j++)
        {
            if(!n.Contains(j))
            {
                result = j;
               return result;
            }
        }

        return 0;

    }
}