public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {

        //Converting the Arrays into LIST
        List<int> n1 = nums1.ToList();
        List<int> n2 = nums2.ToList();

        //It will store the result
        List<int> result = new List<int>();

        //Main logic is that i will go to each element of list1/array1
        //and check if it is present in list2/array2, it yes then i will check that 
        //if it is present in resultList, if yes then skip and if not then add it to result
        for(int i = 0 ; i < n1.Count ; i++)
        {
           if(n2.Contains(n1[i]) && !result.Contains(n1[i]))
           {
                    result.Add(n1[i]);
           }
        }

        //Converting the List into Aarray
        int[] n = result.ToArray();
        return n;
    }
}