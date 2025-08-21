public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int k = 0;
        int c = 0;
        int[] updated = new int[nums.Length];

        for(int i = 0; i < nums.Length ; i++)
        {
            if(nums[i] != val){
                updated[c++] = nums[i];
                k++;
            }
        }

        for(int j = 0; j < nums.Length ; j++){
            nums[j] = updated[j];
        }

        return k;

    }
}