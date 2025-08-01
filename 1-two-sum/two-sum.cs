
public class Solution {
    public int[] TwoSum(int[] nums, int target) {


        List<int> num = new List<int>();

        for(int i = 0; i < nums.Length ; i++)
        {
            
            int result = target - nums[i];
            if(num.Contains(result))
            {
                int  j = num.IndexOf(result);
                return new int[] {i , j};
            } else{
                num.Add(nums[i]);
            }
        }
        
        //Rtturn if the pair is not found
        return new int[] {};
    }
}