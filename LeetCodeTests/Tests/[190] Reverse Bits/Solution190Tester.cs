using LeetCodeSolutions.Solutions.ReverseBits;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Tests.ReverseBits
{
  [TestClass]
  public class Solution190Tester : AbstractSolutionTester<Solution190>
  {
    [TestMethod]
    public void SmallNumberTest()
    {
      uint testNumber = 43261596;
      uint correctReversedNumber = 964176192;

      uint methodReversedNumber = solution.ReverseBits(testNumber);

      Assert.AreEqual(correctReversedNumber, methodReversedNumber);
    }

    [TestMethod]
    public void BigNumberTest()
    {
      uint testNumber = 4294967293;
      uint correctReversedNumber = 3221225471;

      uint methodReversedNumber = solution.ReverseBits(testNumber);

      Assert.AreEqual(correctReversedNumber, methodReversedNumber);
    }
  }
}
