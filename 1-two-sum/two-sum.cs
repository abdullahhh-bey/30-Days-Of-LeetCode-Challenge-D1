
public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        // List<int> num = new List<int>();

        // foreach( int val in nums )
        // {
        //     int result = target - val;

        //     if(num.Contains(result))
        //     {
        //         int j = Array.IndexOf(nums, val);
        //         int i = num.IndexOf(result);
        //         return new int[] {j , i} ;
        //     } 

        //     num.Add(val);
        // }

        // return new int[] {};

        List<int> seen = new List<int>();

        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];

            if (seen.Contains(complement)) {
                // Get index of the complement in the original array
                int j = Array.IndexOf(nums, complement);
                return new int[] { j, i };
            }

            seen.Add(nums[i]); // Add current number to seen list
        }

        return new int[] { }; // No pair found

        
    }
}