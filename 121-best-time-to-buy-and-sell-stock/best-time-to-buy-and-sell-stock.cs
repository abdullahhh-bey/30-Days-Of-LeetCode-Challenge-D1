public class Solution {
    public int MaxProfit(int[] prices) {
        //Better Option to use C#
        //Assuming that the 0th index is the minimum value
        int bestBuy = prices[0];
        int maxProfit = 0;

        for(int i = 0 ; i < prices.Length ; i++)
        {
            //If the item is greater, then we have to count the profit and 
            //compare the profit from the previous greater profit ( if any )
            if(prices[i] > bestBuy)
            {
                int sum = prices[i] - bestBuy;
                maxProfit = Math.Max(maxProfit , sum);
            }

            //Always check for the Minimum value
            bestBuy = Math.Min(bestBuy , prices[i]);
        }

        //Return maxProfit
        return maxProfit;

    }
}