public class Solution {
    public void MoveZeroes(int[] nums) {
        
        List<int> num = nums.ToList();
        int size = num.Count;
        int k = 0;

        for(int i = 0 ; i < size ; i++)
        {
            if(num[k] == 0)
            {
                num.Remove(num[k]);
                num.Add(0);
            } else{
                k++;
            }
        }
        
        for(int i = 0 ; i < size ; i++)
        {
            nums[i] = num[i];
        }

    }
}