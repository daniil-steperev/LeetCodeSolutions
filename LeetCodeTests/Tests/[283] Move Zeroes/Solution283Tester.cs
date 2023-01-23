using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeSolutions.Solutions._283__Move_Zeroes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Tests._283__Move_Zeroes
{
  [TestClass]
  public class Solution283Tester : AbstractSolutionTester<Solution283>
  {
    [TestMethod]
    public void BigZerosTest()
    {
      int[] notSortedNums = { 0, 1, 0, 3, 12 };
      int[] sortedNums = { 1, 3, 12, 0, 0 };

      solution.MoveZeroes(ref notSortedNums);

      CollectionAssert.AreEqual(notSortedNums, sortedNums);
    }

    [TestMethod]
    public void SmallZerosTest()
    {
      int[] notSortedNums = { 0 };
      int[] sortedNums = { 0 };

      solution.MoveZeroes(ref notSortedNums);

      CollectionAssert.AreEqual(notSortedNums, sortedNums);
    }
  }
}
