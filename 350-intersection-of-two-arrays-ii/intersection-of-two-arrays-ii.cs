public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        List<int> n1 = nums1.ToList();
        List<int> n2 = nums2.ToList();
        List<int> result = new List<int>();

        //Similar Previous Logic but now we wont check the resultList for the element it exists, 
        //We just add the element it it is presemt in both arrrays/List
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