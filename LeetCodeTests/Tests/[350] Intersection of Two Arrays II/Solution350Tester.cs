using LeetCodeSolutions.Solutions.IntersectionOfTwoArraysII;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Tests.IntersectionOfTwoArraysII
{
  [TestClass]
  public class Solution350Tester : AbstractSolutionTester<Solution350>
  {
    [TestMethod]
    public void FirstArrayBiggerIntersectionTest()
    {
      int[] nums1 = { 1, 2, 2, 1 };
      int[] nums2 = { 2, 2 };
      int[] correctIntersection = { 2, 2 };

      int[] methodIntersection = solution.Intersect(nums1, nums2);

      CollectionAssert.AreEqual(correctIntersection, methodIntersection);
    }

    [TestMethod]
    public void SecondArrayBiggerIntersectionTest()
    {
      int[] nums1 = { 4, 9, 5 };
      int[] nums2 = { 9, 4, 9, 8, 4 };
      int[] correctIntersection = { 9, 4 };

      int[] methodIntersection = solution.Intersect(nums1, nums2);

      CollectionAssert.AreEqual(correctIntersection, methodIntersection);
    }
  }
}
