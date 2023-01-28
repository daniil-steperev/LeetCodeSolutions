using LeetCodeSolutions.Solutions.ValidAnagram;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Tests.ValidAnagram
{
  [TestClass]
  public class Solution242Tester : AbstractSolutionTester<Solution242>
  {
    [TestMethod]
    public void IsAnagramTest()
    {
      string testString = "anagram";
      string testAnagram = "nagaram";

      bool isMethodAnagram = solution.IsAnagram(testString, testAnagram);

      Assert.IsTrue(isMethodAnagram);
    }

    [TestMethod]
    public void IsNotAnagramTest()
    {
      string testString = "rat";
      string testAnagram = "car";

      bool isMethodAnagram = solution.IsAnagram(testString, testAnagram);

      Assert.IsFalse(isMethodAnagram);
    }
  }
}
