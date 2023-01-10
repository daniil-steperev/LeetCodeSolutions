using LeetCodeSolutions.Solutions.ClimbingStairs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Tests.ClimbingStairs
{

  [TestClass]
  public class Solution70Tester : AbstractSolutionTester<Solution70>
  {

    [TestMethod]
    public void BasicNTest()
    {
      int n = 2;
      int correctOutput = 2;

      int methodOutput = solution.ClimbStairs(n);

      Assert.AreEqual(correctOutput, methodOutput);
    }

    [TestMethod]
    public void ComplexNTest()
    {
      int n = 3;
      int correctOutput = 3;

      int methodOutput = solution.ClimbStairs(n);

      Assert.AreEqual(correctOutput, methodOutput);
    }
  }
}
