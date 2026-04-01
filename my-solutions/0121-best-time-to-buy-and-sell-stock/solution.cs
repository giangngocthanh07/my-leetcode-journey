public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int minPrice = 10001;

        // O(N) Space
        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < minPrice) 
            {   
                minPrice = prices[i];
            }
            else if ((prices[i] - minPrice) > maxProfit)
            {
                maxProfit = prices[i] - minPrice;
            }
        }
        return maxProfit;
    }
}

// prices = [7, 1, 5, 3, 6, 4]

// if (prices[i] < minPrice) => minPrice = prices[i];
// else if ((prices[i] - minPrice) > maxProfit) => maxProfit = prices[i] - minPrice;

// 10^5 = 100.000 => O(N)
// 10^4 = 10.000



