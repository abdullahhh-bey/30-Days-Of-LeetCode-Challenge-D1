public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        List<int> n1 = nums1.ToList();
        List<int> n2 = nums2.ToList();
        List<int> result = new List<int>();

        for(int i = 0 ; i < n1.Count ; i++)
        {
            if(n2.Contains(n1[i]))
            {
                result.Add(n1[i]);
                n2.Remove(n1[i]);
            }
        }

        int[] ansArray = result.ToArray();
        return ansArray;

    }
}