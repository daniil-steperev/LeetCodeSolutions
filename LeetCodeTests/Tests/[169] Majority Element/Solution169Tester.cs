using LeetCodeSolutions.Solutions.MajorityElement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Tests.MajorityElement
{
  [TestClass]
  public class Solution169Tester : AbstractSolutionTester<Solution169>
  {
    [TestMethod]
    public void ShortMajorityElementTest()
    {
      int[] nums = { 3, 2, 3, };
      int majorityElement = 3;

      int methodMajorityElement = solution.MajorityElement(nums);

      Assert.AreEqual(majorityElement, methodMajorityElement);
    }

    [TestMethod]
    public void BigMajorityElementTest()
    {
      int[] nums = { 2, 2, 1, 1, 1, 2, 2, };
      int majorityElement = 2;

      int methodMajorityElement = solution.MajorityElement(nums);

      Assert.AreEqual(majorityElement, methodMajorityElement);
    }
  }
}
