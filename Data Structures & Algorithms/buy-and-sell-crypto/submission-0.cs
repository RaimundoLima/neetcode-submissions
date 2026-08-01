public class Solution {
    public int MaxProfit(int[] prices) {
        int buy = 0;
        int sell =1;
        int result = 0; 
        while(sell<prices.Length)
        {
            if(prices[buy]<prices[sell])
            {
                int actualPrice = prices[sell]-prices[buy];
                if(actualPrice>result)
                    result=actualPrice;
                sell++;
                continue;
            }
            buy = sell;
            sell++;
            
        }
        return result;
    }
}
