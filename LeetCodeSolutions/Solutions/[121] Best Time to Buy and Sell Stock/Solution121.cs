namespace LeetCodeSolutions.Solutions.BestTimeToBuyAndSellStock
{
  public class Solution121
  {
    public int MaxProfit(int[] prices)
    {
      int maxProfit = 0;
      int bestBuyPrice = prices[0];
      int bestSellPrice = 0;

      for (int i = 1; i < prices.Length; i++)
      {
        if (i != prices.Length - 1 && prices[i] < bestBuyPrice)
        {
          bestBuyPrice = prices[i];
          bestSellPrice = 0;
          continue;
        }

        if (prices[i] > bestBuyPrice && prices[i] > bestSellPrice)
        {
          bestSellPrice = prices[i];
        }

        if (bestSellPrice - bestBuyPrice > maxProfit)
        {
          maxProfit = bestSellPrice - bestBuyPrice;
        }
      }

      return maxProfit;
    }
  }
}
