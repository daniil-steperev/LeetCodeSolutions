using LeetCodeSolutions.Solutions.MergeSortedArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Tests.MergeSortedArray
{
  [TestClass]
  public class Solution88Tester : AbstractSolutionTester<Solution88>
  {
    [TestMethod]
    public void SixElementsTest()
    {
      int m = 3;
      int n = 3;
      int[] nums1 = { 1, 2, 3, 0, 0, 0, };
      int[] nums2 = { 2, 5, 6, };
      int[] correctOutput = { 1, 2, 2, 3, 5, 6, };

      solution.Merge(ref nums1, m, nums2, n);

      CollectionAssert.AreEqual(correctOutput, nums1);
    }

    [TestMethod]
    public void SecondNullArrayTest()
    {
      int m = 1;
      int n = 0;
      int[] nums1 = { 1, };
      int[] nums2 = { };
      int[] correctOutput = { 1, };

      solution.Merge(ref nums1, m, nums2, n);

      CollectionAssert.AreEqual(correctOutput, nums1);
    }

    [TestMethod]
    public void FstNullArrayTest()
    {
      int m = 0;
      int n = 1;
      int[] nums1 = { 0, };
      int[] nums2 = { 1, };
      int[] correctOutput = { 1, };

      solution.Merge(ref nums1, m, nums2, n);

      CollectionAssert.AreEqual(correctOutput, nums1);
    }
  }
}
