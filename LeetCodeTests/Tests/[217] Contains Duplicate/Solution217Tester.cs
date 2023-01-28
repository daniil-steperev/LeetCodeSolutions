using LeetCodeSolutions.Solutions.ContainsDuplicate;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Tests.ContainsDuplicate
{
  [TestClass]
  public class Solution217Tester : AbstractSolutionTester<Solution217>
  {
    [TestMethod]
    public void ShortContainsDuplicatesTest()
    {
      int[] testArray = { 1, 2, 3, 1 };

      bool isMethodContainsDuplicates = solution.ContainsDuplicate(testArray);

      Assert.IsTrue(isMethodContainsDuplicates);
    }

    [TestMethod]
    public void LongContainsDuplicatesTest()
    {
      int[] testArray = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

      bool isMethodContainsDuplicates = solution.ContainsDuplicate(testArray);

      Assert.IsTrue(isMethodContainsDuplicates);
    }

    [TestMethod]
    public void NotContainsDuplicates()
    {
      int[] testArray = { 1, 2, 3, 4 };

      bool isMethodContainsDuplicates = solution.ContainsDuplicate(testArray);

      Assert.IsFalse(isMethodContainsDuplicates);
    }
  }
}
