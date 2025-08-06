public class Solution {
    public int MaxSubArray(int[] nums) {

        //Approach is very simplE
        //Variable to store the sum of two or more numbers
        int sum = 0;
        //It iwll store the max sum
        int maxSum = 0;

        //Used for validation
        bool neg = false;
        int max = -1000000;

        //Validation method , this is for the  arrays that have only negative numbers
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



        //Main Logic starts from here
        //Check for each item, add it to sum, check if the sum is greater than zero, if yes them compare
        //COmpoare it to the previous maximum value
        //If sum is smaller than zero or equal to zero, reset the sum because it is not necessary
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