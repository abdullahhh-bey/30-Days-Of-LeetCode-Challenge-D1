public class Solution {
    public int MaxProfit(int[] prices) {
        //Converting array to List
        List<int> pricesList = prices.ToList();
        //Assuming that the 0th index is the minimum value
        int bestBuy = pricesList[0];
        int maxProfit = 0;

        for(int i = 0 ; i < pricesList.Count ; i++)
        {

            //If the item is greater, then we have to count the profit and 
            //compare the profit from the previous greater profit ( if any )
            if(pricesList[i] > bestBuy)
            {
                int sum = pricesList[i] - bestBuy;
                maxProfit = Math.Max(maxProfit , sum);
            }

            //Always check for the Minimum value
            bestBuy = Math.Min(bestBuy , pricesList[i]);
        }

        //Return maxProfit
        return maxProfit;

    }
}