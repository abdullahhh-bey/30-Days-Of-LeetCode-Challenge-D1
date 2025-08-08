public class Solution {
    public int Search(int[] nums, int target) {
        //Simply using binary search ( the most commom method to find key in array , sorted array)
        int start = 0;
        int end  = nums.Length - 1;

        //Dividing the array into two parts and them checking the mid first and them comparing the
        //mid from target
        while(start <= end)
        {

            int mid = (start+end)/2;

            if(nums[mid] == target)
            {
                return mid;
            } else if(nums[mid] > target)
            {
                end = mid - 1;
            } else{
                start = mid + 1;
            }

        }

        //return - if the target is not found
         return -1;    

    }
}