public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        //We can easily do that with two nested for loops but the condition here does not support it
        //We cannot even use the Division Operator because it fails to divide the zero

        int[] result = new int[nums.Length];

        //Using common approach - first find prefix & add it to result array and then find the suffix
        //and multity it to the prefix of ith item
        //it would be like
        //result[ith] = prodiuct of left items of result[i] * product of right items of result[i]

        //Assume first index a 1
        result[0] = 1;
        for(int i = 1 ; i < nums.Length ; i++)
        {
            result[i] = result[i-1] * nums[i-1];
        }

        //Assuming Suffix as 1 
        int suffix = 1;
        for(int j = nums.Length - 1 ; j >= 0 ; j--)
        {
            result[j] = result[j] * suffix;
            suffix *= nums[j];
        }

        //Return the Updated Array
        return result;



        return result;

    }
}