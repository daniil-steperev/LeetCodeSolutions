using LeetCodeSolutions.Solutions.PascalsTriangle;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCodeTests.Tests.PascalsTriangle
{
  [TestClass]
  public class Solution119Tester : AbstractSolutionTester<Solution119>
  {
    [TestMethod]
    public void BigRowPascalTriangleTest()
    {
      int rowIndex = 3;
      List<int> correctOutput = new List<int>() { 1, 3, 3, 1, };

      List<int> methodOutput = (List<int>)solution.GetRow(rowIndex);

      CollectionAssert.AreEqual(correctOutput, methodOutput);
    }

    [TestMethod]
    public void FstRowPascalTriangleTest()
    {
      int rowIndex = 1;
      List<int> correctOutput = new List<int>() { 1, 1, };

      List<int> methodOutput = (List<int>)solution.GetRow(rowIndex);

      CollectionAssert.AreEqual(correctOutput, methodOutput);
    }

    [TestMethod]
    public void ZeroRowPascalTriangleTest()
    {
      int rowIndex = 0;
      List<int> correctOutput = new List<int>() { 1, };

      List<int> methodOutput = (List<int>)solution.GetRow(rowIndex);

      CollectionAssert.AreEqual(correctOutput, methodOutput);
    }
  }
}
