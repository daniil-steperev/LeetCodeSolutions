using LeetCodeSolutions.Solutions.ExcelSheetColumnNumber;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Tests.ExcelSheetColumnNumber
{
  [TestClass]
  public class Solution171Tester : AbstractSolutionTester<Solution171>
  {
    [TestMethod]
    public void EasyColumnTest()
    {
      string testColumn = "A";
      int correctColumnNumber = 1;

      int methodColumnNumber = solution.TitleToNumber(testColumn);

      Assert.AreEqual(correctColumnNumber, methodColumnNumber);
    }

    [TestMethod]
    public void MiddleColumnTest()
    {
      string testColumn = "AB";
      int correctColumnNumber = 28;

      int methodColumnNumber = solution.TitleToNumber(testColumn);

      Assert.AreEqual(correctColumnNumber, methodColumnNumber);
    }

    [TestMethod]
    public void HardColumnTest()
    {
      string testColumn = "ZY";
      int correctColumnNumber = 701;

      int methodColumnNumber = solution.TitleToNumber(testColumn);

      Assert.AreEqual(correctColumnNumber, methodColumnNumber);
    }
  }
}
