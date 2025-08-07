public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var result = new List<IList<int>>();

        //using very different approach
        for(int i = 0 ; i < numRows ; i++)
        {
            //it adds a new List
            result.Add(new List<int>());
            for(int j = 0 ; j <= i ; j++ )
            {
                if( j == 0 || j == i)
                {
                    result[i].Add(1);
                }else{
                    //it will get the left and right index items of the previous inner list
                    int sum = result[i-1][(i+j)%(i+1)] + result[i-1][(i+j)%i];
                    result[i].Add(sum);
                }
            }
        }

        return result;
        
    }
}