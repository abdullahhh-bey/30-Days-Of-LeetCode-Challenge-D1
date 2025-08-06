public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int[] num = new int[m+n];

        //it will be used to iterate nums1
        int i = nums1.Length - n - 1; //2
        //It will be used to iterate nums2
        int j = n - 1;
        //used to iterate new array -> num
        int k = m + n - 1;

        while(i >= 0 && j >= 0)
        {
            if(nums1[i] >= nums2[j])
            {
                num[k] = nums1[i];
                k--;
                i--;
            } else{
                num[k] = nums2[j];
                k--;
                j--;
            }
        }

        while( i > j)
        {
            num[k] = nums1[i];
            k--;
            i--;   
        }

        while( j > i)
        {
            num[k] = nums2[j];
            k--;
            j--;   
        }

        for(int z = 0 ; z < num.Length ; z++)
        {
            nums1[z] = num[z];
        }


    }
}