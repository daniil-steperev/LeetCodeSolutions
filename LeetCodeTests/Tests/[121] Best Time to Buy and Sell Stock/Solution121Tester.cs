using LeetCodeSolutions.Solutions.BestTimeToBuyAndSellStock;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Tests._121__Best_Time_to_Buy_and_Sell_Stock
{
  [TestClass]
  public class Solution121Tester : AbstractSolutionTester<Solution121>
  {
    [TestMethod]
    public void ProfitBuyAndStockTest() 
    {
      int[] prices = { 7, 1, 5, 3, 6, 4 };
      int maxProfit = 5;

      int methodProfit = solution.MaxProfit(prices);

      Assert.AreEqual(maxProfit, methodProfit);
    }

    [TestMethod]
    public void NonProfitBuyAndStockTest()
    {
      int[] prices = { 7, 6, 4, 3, 1 };
      int maxProfit = 0;

      int methodProfit = solution.MaxProfit(prices);

      Assert.AreEqual(maxProfit, methodProfit);
    }

    [TestMethod]
    public void ProfitShortBuyAndStockTest()
    {
      int[] prices = { 2, 4, 1 };
      int maxProfit = 2;

      int methodProfit = solution.MaxProfit(prices);

      Assert.AreEqual(maxProfit, methodProfit);
    }

    [TestMethod]
    public void ProfitLongBuyAndStockTest()
    {
      int[] prices = { 3, 2, 6, 5, 0, 3 };
      int maxProfit = 4;

      int methodProfit = solution.MaxProfit(prices);

      Assert.AreEqual(maxProfit, methodProfit);
    }
  }
}
