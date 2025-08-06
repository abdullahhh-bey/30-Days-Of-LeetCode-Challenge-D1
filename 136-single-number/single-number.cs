public class Solution {
    public int SingleNumber(int[] nums) {

        //Using XOR as to find the single element
        //MAin logic is that By using Xor, i would be able to subtract element from next elementt
        //and then at the end i would have the element that appreared only once
        int element = 0;


        //validation
        if(nums.Length == 1 )
        {
            return nums[0];
        }


        //Main logic where ^ denotes XOR
        // 1 ^ 1 = 0
        // 0 ^ 0 = 0
        // 1 ^ 0 = 1
        // 0 ^ 1 = 1
        for(int  i = 0 ; i < nums.Length; i++ )
        {
            element = element ^ nums[i];
        }

        return element;


    }
}