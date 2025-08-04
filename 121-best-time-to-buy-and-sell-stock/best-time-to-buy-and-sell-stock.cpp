class Solution {
public:
    int maxProfit(vector<int>& prices) {
        int bestBuy = prices[0];
        int maxProfit = 0;

        for(int i = 0 ; i < prices.size() ; i++)
        {
            //If the item is greater, then we have to count the profit and 
            //compare the profit from the previous greater profit ( if any )
            if(prices[i] > bestBuy)
            {
                int sum = prices[i] - bestBuy;
                maxProfit = max(maxProfit , sum);
            }

            //Always check for the Minimum value
            bestBuy = min(bestBuy , prices[i]);
        }

        //Return maxProfit
        return maxProfit;
    }
};