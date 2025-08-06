public class Solution {
    public int MaxSubArray(int[] nums) {
        int sum = 0;
        int maxSum = 0;
        bool neg = false;
        int max = -100000;

        for(int i = 0 ; i < nums.Length ; i++)
        {
            if(nums[i] < 0)
            {
                max = Math.Max(max , nums[i]);
            } else{
                neg = true;
            }
        }

        if(neg == false)
        {
            return max;
        }



        for(int i = 0 ; i < nums.Length ; i++)
        {
            sum += nums[i];
            if(sum > 0)
            {
                maxSum = Math.Max(maxSum , sum);
            } else{
                sum = 0;
            }
        }

        return maxSum;

    }
}