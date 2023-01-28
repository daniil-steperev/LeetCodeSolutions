using LeetCodeSolutions.Solutions.HappyNumber;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Tests.HappyNumber
{
  [TestClass]
  public class Solution202Tester : AbstractSolutionTester<Solution202>
  {
    [TestMethod]
    public void HappyNumberTest()
    {
      int testNumber = 19;

      bool methodHappyResult = solution.IsHappy(testNumber);

      Assert.IsTrue(methodHappyResult);
    }

    [TestMethod]
    public void NotHappyNumberTest()
    {
      int testNumber = 2;

      bool methodHappyResult = solution.IsHappy(testNumber);

      Assert.IsFalse(methodHappyResult);
    }

    [TestMethod]
    public void NotHappySecondNumberTest()
    {
      int testNumber = 3;

      bool methodHappyResult = solution.IsHappy(testNumber);

      Assert.IsFalse(methodHappyResult);
    }

    [TestMethod]
    public void NotHappyThirdNumberTest()
    {
      int testNumber = 5;

      bool methodHappyResult = solution.IsHappy(testNumber);

      Assert.IsFalse(methodHappyResult);
    }
  }
}
