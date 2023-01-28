using LeetCodeSolutions.Solutions.PowerOfThree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Tests.PowerOfThree
{
  [TestClass]
  public class Solution326Tester: AbstractSolutionTester<Solution326>
  {
    [TestMethod]
    public void PowerOfTreeTest()
    {
      int testNumber = 27;

      bool isMethodPowerOfThree = solution.IsPowerOfThree(testNumber);

      Assert.IsTrue(isMethodPowerOfThree);
    }

    [TestMethod]
    public void ZeroTest()
    {
      int testNumber = 0;

      bool isMethodPowerOfThree = solution.IsPowerOfThree(testNumber);

      Assert.IsFalse(isMethodPowerOfThree);
    }

    [TestMethod]
    public void NotPowerOfTreeTest()
    {
      int testNumber = -1;

      bool isMethodPowerOfThree = solution.IsPowerOfThree(testNumber);

      Assert.IsFalse(isMethodPowerOfThree);
    }
  }
}
