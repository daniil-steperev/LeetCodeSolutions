using LeetCodeSolutions.AddBinary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Tests.AddBinary
{
  [TestClass]
  public class Solution67Tester : AbstractSolutionTester<Solution67>
  {

    [TestMethod]
    public void IncrementedBinarySimpleTest()
    {
      string a = "11";
      string b = "1";
      string correctOutput = "100";

      string methodOutput = solution.AddBinary(a, b);
      
      Assert.AreEqual(correctOutput, methodOutput);
    }

    [TestMethod]
    public void IncrementedBinaryComplexTest()
    {
      string a = "1010";
      string b = "1011";
      string correctOutput = "10101";

      string methodOutput = solution.AddBinary(a, b);

      Assert.AreEqual(correctOutput, methodOutput);
    }

    [TestMethod]
    public void EqualBinaryComplexTest()
    {
      string a = "1111";
      string b = "1111";
      string correctOutput = "11110";

      string methodOutput = solution.AddBinary(a, b);

      Assert.AreEqual(correctOutput, methodOutput);
    }
  }
}
