using LeetCodeSolutions.Solutions.PascalsTriangle;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCodeTests.Tests.PascalsTriangle
{
  [TestClass]
  public class Solution118Tester : AbstractSolutionTester<Solution118>
  {
    [TestMethod]
    public void BigPascalTriangleTest()
    {
      int numRows = 5;
      IList<IList<int>> correctOutput = new List<IList<int>>()
      {
        new List<int>() { 1, },
        new List<int>() { 1, 1 },
        new List<int>() { 1, 2, 1 },
        new List<int>() { 1, 3, 3, 1 },
        new List<int>() { 1, 4, 6, 4, 1 },
      };

      IList<IList<int>> methodOutput = solution.Generate(numRows);

      Assert.IsTrue(AssertListsAreEqual(correctOutput, methodOutput));
    }

    [TestMethod]
    public void ShortPascalTriangleTest()
    {
      int numRows = 1;
      IList<IList<int>> correctOutput = new List<IList<int>>()
      {
        new List<int>() { 1, },
      };

      IList<IList<int>> methodOutput = solution.Generate(numRows);

      Assert.IsTrue(AssertListsAreEqual(correctOutput, methodOutput));
    }

    private bool AssertListsAreEqual(IList<IList<int>> fstList, IList<IList<int>> sndList)
    {
      if (!HasListsEquallSize(fstList, sndList))
      {
        return false;
      }

      for (int i = 0; i < fstList.Count; i++)
      {
        if (!HasListsEquallSize(fstList[i], sndList[i]))
        {
          return false;
        }

        for (int j = 0; j < fstList[i].Count; j++)
        {
          if (fstList[i][j] != sndList[i][j])
          {
            return false;
          }
        }
      }

      return true;
    }

    private bool HasListsEquallSize<T>(IList<T> fstList, IList<T> sndList)
    {
      return fstList != null && sndList != null && fstList.Count == sndList.Count;
    }
  }
}
