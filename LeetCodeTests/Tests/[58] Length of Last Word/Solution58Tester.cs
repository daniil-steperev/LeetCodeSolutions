using LeetCodeSolutions.LengthOfTheLastWord;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Tests.LengthOfTheLastWord
{
  [TestClass]
  public class Solution58Tester : AbstractSolutionTester<Solution58>
  {
    [TestMethod]
    public void HelloWorldTest()
    {
      string inputString = "Hello World";
      int correctLength = 5;

      int resultLength = solution.LengthOfLastWord(inputString);

      Assert.AreEqual(correctLength, resultLength);
    }

    [TestMethod]
    public void FlyTheMoonTest()
    {
      string inputString = "   fly me   to   the moon  ";
      int correctLength = 4;

      int resultLength = solution.LengthOfLastWord(inputString);

      Assert.AreEqual(correctLength, resultLength);
    }

    [TestMethod]
    public void LuffyJoyboyTest()
    {
      string inputString = "luffy is still joyboy";
      int correctLength = 6;

      int resultLength = solution.LengthOfLastWord(inputString);

      Assert.AreEqual(correctLength, resultLength);
    }
  }
}
