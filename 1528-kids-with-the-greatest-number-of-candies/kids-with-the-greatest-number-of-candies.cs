public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        
        int n = candies.Length;
        //New bool array of n size
        bool[] result = new bool[n];
        int k = 0;
        //Getting the Max Number in the Array
        List<int> cList = candies.ToList();
        cList.Sort();
        int MaxNumber = cList[n - 1];

        //Logic to add extra candyu to each element and compare it with MaxNumber
        for( int  i = 0; i < n; i++)
        {
            int sum = candies[i] + extraCandies;
            if(sum >= MaxNumber)
            {
                result[k] = true;
                k++;
            } else{
                result[k] = false;
                k++;
            }
        }

        return result;
        
    }
}