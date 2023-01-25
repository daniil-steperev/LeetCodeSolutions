using LeetCodeSolutions.Solutions.BinaryTreeInorderTraversal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using LeetCodeSolutions.Solutions.Util;

namespace LeetCodeTests.Tests.BinaryTreeInorderTraversal
{
  [TestClass]
  public class Solution94Tester : AbstractSolutionTester<Solution94>
  {
    [TestMethod]
    public void ThreeNodesTest()
    {
      List<int> corectOutput = new List<int>(new int[] { 1, 3, 2 });
      TreeNode root = new TreeNode()
      {
        val = 1,
        left = null,
        right = new TreeNode()
        {
          val = 2,
          left = new TreeNode()
          {
            val = 3,
          },
        }
      };

      List<int> methodOutput = (List<int>)solution.InorderTraversal(root);

      CollectionAssert.AreEqual(corectOutput, methodOutput);
    }

    [TestMethod]
    public void NullRootTest()
    {
      List<int> corectOutput = new List<int>();
      TreeNode root = null;

      List<int> methodOutput = (List<int>)solution.InorderTraversal(root);

      CollectionAssert.AreEqual(corectOutput, methodOutput);
    }

    [TestMethod]
    public void OneElementTest()
    {
      List<int> corectOutput = new List<int>(new int[] { 1, });
      TreeNode root = new TreeNode(1);

      List<int> methodOutput = (List<int>)solution.InorderTraversal(root);

      CollectionAssert.AreEqual(corectOutput, methodOutput);
    }
  }
}
