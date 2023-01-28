using LeetCodeSolutions.Solutions.MissingNumber;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Tests._268__Missing_Number
{
  [TestClass]
  public class Solution268Tester : AbstractSolutionTester<Solution268>
  {
    [TestMethod]
    public void MiddleNumberMissingTest()
    {
      int[] testArray = { 3, 0, 1 };
      int correctMissingNumber = 2;

      int methodMissingNumber = solution.MissingNumber(testArray);

      Assert.AreEqual(correctMissingNumber, methodMissingNumber);
    }

    [TestMethod]
    public void LastNumberMissingTest()
    {
      int[] testArray = { 0, 1 };
      int correctMissingNumber = 2;

      int methodMissingNumber = solution.MissingNumber(testArray);

      Assert.AreEqual(correctMissingNumber, methodMissingNumber);
    }
  }
}
