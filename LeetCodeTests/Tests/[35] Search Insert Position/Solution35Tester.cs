using LeetCodeSolutions.SearchInsertPosition;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Tests.SearchInsertPosition
{
  [TestClass]
  public class Solution35Tester : AbstractSolutionTester<Solution35>
  {
    [TestMethod]
    public void TargetFoundTest()
    {
      int target = 5;
      int[] nums = { 1, 3, 5, 6 };
      int correctIndex = 2;

      int resultIndex = solution.SearchInsert(nums, target);

      Assert.AreEqual(correctIndex, resultIndex);
    }

    [TestMethod]
    public void LeftIsSmallerTest()
    {
      int target = 2;
      int[] nums = { 1, 3, 5, 6 };
      int correctIndex = 1;

      int resultIndex = solution.SearchInsert(nums, target);

      Assert.AreEqual(correctIndex, resultIndex);
    }

    [TestMethod]
    public void LeftIsLargerTest()
    {
      int target = 7;
      int[] nums = { 1, 3, 5, 6 };
      int correctIndex = 4;

      int resultIndex = solution.SearchInsert(nums, target);

      Assert.AreEqual(correctIndex, resultIndex);
    }

    [TestMethod]
    public void OneElementTest()
    {
      int target = 1;
      int[] nums = { 1 };
      int correctIndex = 0;

      int resultIndex = solution.SearchInsert(nums, target);

      Assert.AreEqual(correctIndex, resultIndex);
    }
  }
}
