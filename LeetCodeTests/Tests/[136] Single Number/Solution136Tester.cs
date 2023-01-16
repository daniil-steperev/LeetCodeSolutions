using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolutions.Solutions.SingleNumber;

namespace LeetCodeTests.Tests.SingleNumber
{
  [TestClass]
  public class Solution136Tester : AbstractSolutionTester<Solution136>
  {
    [TestMethod]
    public void SmallSingleNumberTest()
    {
      int[] testNums = { 2, 2, 1 };
      int singleNumber = 1;

      int methodSingleNumber = solution.SingleNumber(testNums);

      Assert.AreEqual(singleNumber, methodSingleNumber);
    }

    [TestMethod]
    public void BigSingleNumberTest()
    {
      int[] testNums = { 4, 1, 2, 1, 2 };
      int singleNumber = 4;

      int methodSingleNumber = solution.SingleNumber(testNums);

      Assert.AreEqual(singleNumber, methodSingleNumber);
    }
  }
}
