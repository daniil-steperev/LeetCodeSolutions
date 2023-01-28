using LeetCodeSolutions.Solutions.ReverseString;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Tests.ReverseString
{
  [TestClass]
  public class Solution344Tester : AbstractSolutionTester<Solution344>
  {
    [TestMethod]
    public void HelloStringTest()
    {
      char[] testString = { 'h', 'e', 'l', 'l', 'o' };
      char[] testReversedString = { 'o', 'l', 'l', 'e', 'h' };

      char[] methodReversedString = solution.ReverseString(testString);

      CollectionAssert.AreEqual(methodReversedString, testReversedString);
    }

    [TestMethod]
    public void HannahStringTest()
    {
      char[] testString = { 'H', 'a', 'n', 'n', 'a', 'h' };
      char[] testReversedString = { 'h', 'a', 'n', 'n', 'a', 'H' };

      char[] methodReversedString = solution.ReverseString(testString);

      CollectionAssert.AreEqual(methodReversedString, testReversedString);
    }
  }
}
