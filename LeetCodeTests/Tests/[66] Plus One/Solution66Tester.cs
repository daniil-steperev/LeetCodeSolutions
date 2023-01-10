using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolutions.PlusOne;

namespace LeetCodeTests.Tests.PlusOne
{
  [TestClass]
  public class Solution66Tester : AbstractSolutionTester<Solution66>
  {
    [TestMethod]
    public void ThreeDigitsTest()
    {
      int[] digits = { 1, 2, 3 };
      int[] correctOutput = { 1, 2, 4 };

      int[] methodOutput = solution.PlusOne(digits);

      CollectionAssert.AreEqual(correctOutput, methodOutput);
    }

    [TestMethod]
    public void FourDigitsTest()
    {
      int[] digits = { 4, 3, 2, 1 };
      int[] correctOutput = { 4, 3, 2, 2 };

      int[] methodOutput = solution.PlusOne(digits);

      CollectionAssert.AreEqual(correctOutput, methodOutput);
    }

    [TestMethod]
    public void OneIncrementedDigitTest()
    {
      int[] digits = { 9 };
      int[] correctOutput = { 1, 0 };

      int[] methodOutput = solution.PlusOne(digits);

      CollectionAssert.AreEqual(correctOutput, methodOutput);
    }

    [TestMethod]
    public void SeveralIncrementedDigitTest()
    {
      int[] digits = { 9, 9 };
      int[] correctOutput = { 1, 0, 0 };

      int[] methodOutput = solution.PlusOne(digits);

      CollectionAssert.AreEqual(correctOutput, methodOutput);
    }
  }
}
