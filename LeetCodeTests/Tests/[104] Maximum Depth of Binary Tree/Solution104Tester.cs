using LeetCodeSolutions.Solutions.MaximumDepthOfBinaryTree;
using LeetCodeSolutions.Solutions.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Tests._104__Maximum_Depth_of_Binary_Tree
{
  [TestClass]
  public class Solution104Tester : AbstractSolutionTester<Solution104>
  {
    [TestMethod]
    public void BigDepthTest()
    {
      int maxDepth = 3;
      TreeNode root = new TreeNode()
      {
        val = 3,
        left = new TreeNode(9),
        right = new TreeNode()
        {
          val = 20,
          left = new TreeNode(15),
          right = new TreeNode(7),
        }
      };

      int methodMaxDepth = solution.MaxDepth(root);

      Assert.AreEqual(maxDepth, methodMaxDepth);
    }

    [TestMethod]
    public void SmallDepthTest()
    {
      int maxDepth = 2;
      TreeNode root = new TreeNode()
      {
        val = 1,
        left = new TreeNode(2),
      };

      int methodMaxDepth = solution.MaxDepth(root);

      Assert.AreEqual(maxDepth, methodMaxDepth);
    }
  }
}
