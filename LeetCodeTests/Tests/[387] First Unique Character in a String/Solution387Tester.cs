using LeetCodeSolutions.Solutions.FirstUniqueCharacterInString;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Tests.FirstUniqueCharacterInString
{
  [TestClass]
  public class Solution387Tester : AbstractSolutionTester<Solution387>
  {
    [TestMethod]
    public void FirstNonRepeatingCharacterTest()
    {
      string testString = "leetcode";
      int correctFirstCharIndex = 0;

      int methodFirstCharIndex = solution.FirstUniqChar(testString);

      Assert.AreEqual(correctFirstCharIndex, methodFirstCharIndex);
    }

    [TestMethod]
    public void MiddleNonRepeatingCharacterTest()
    {
      string testString = "loveleetcode";
      int correctFirstCharIndex = 2;

      int methodFirstCharIndex = solution.FirstUniqChar(testString);

      Assert.AreEqual(correctFirstCharIndex, methodFirstCharIndex);
    }

    [TestMethod]
    public void NoNonRepeatingCharacterTest()
    {
      string testString = "aabb";
      int correctFirstCharIndex = -1;

      int methodFirstCharIndex = solution.FirstUniqChar(testString);

      Assert.AreEqual(correctFirstCharIndex, methodFirstCharIndex);
    }
  }
}
