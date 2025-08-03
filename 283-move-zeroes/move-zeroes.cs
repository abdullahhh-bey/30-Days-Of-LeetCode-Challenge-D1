public class Solution {
    public void MoveZeroes(int[] nums) {
        
        //I was comfortable using List, could be done without them
        List<int> num = nums.ToList();
        //took the size of original array/list for loop iteration
        int size = num.Count;
        int k = 0;

        //Logic is to iterate every element and find 0, if 0 found , remove it from
        //its psition and add it to the back ( at last ) 
        //If the item is non zero, do k++
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

        
        //updating the array ( making it similar to list )
        for(int i = 0 ; i < size ; i++)
        {
            nums[i] = num[i];
        }

    }
}