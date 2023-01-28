using LeetCodeSolutions.Solutions.NumberOfOneBits;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Tests.NumberOfOneBits
{
  [TestClass]
  public class Solution191Tester : AbstractSolutionTester<Solution191>
  {
    [TestMethod]
    public void MediumOnesTest()
    {
      uint testValue = 11;
      int correctHammingWeight = 3;

      int methodHammingWeight = solution.HammingWeight(testValue);

      Assert.AreEqual(correctHammingWeight, methodHammingWeight);
    }

    [TestMethod]
    public void SmallOnesTest()
    {
      uint testValue = 128;
      int correctHammingWeight = 1;

      int methodHammingWeight = solution.HammingWeight(testValue);

      Assert.AreEqual(correctHammingWeight, methodHammingWeight);
    }

    
    [TestMethod]
    public void BigOnesTest()
    {
      uint testValue = 4294967293;
      int correctHammingWeight = 31;

      int methodHammingWeight = solution.HammingWeight(testValue);

      Assert.AreEqual(correctHammingWeight, methodHammingWeight);
    }
  }
}
