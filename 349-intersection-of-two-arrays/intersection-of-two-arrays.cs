public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        List<int> n1 = nums1.ToList();
        List<int> n2 = nums2.ToList();
        List<int> result = new List<int>();

        for(int i = 0 ; i < n1.Count ; i++)
        {
           if(n2.Contains(n1[i]) && !result.Contains(n1[i]))
           {
                    result.Add(n1[i]);
           }
        }

        int[] n = result.ToArray();
        return n;
    }
}