using System.Collections.Generic;

namespace LeetCodeSolutions.Solutions.BinaryTreeInorderTraversal
{
  public class Solution94
  {
    public IList<int> InorderTraversal(TreeNode root)
    {
      IList<int> result = new List<int>();
      Stack<TreeNode> stack = new Stack<TreeNode>();

      TreeNode curNode = root;
      while (curNode != null || stack.Count > 0)
      {
        if (curNode == null && stack.Count > 0)
        {
          curNode = stack.Pop();
          result.Add(curNode.val);
          curNode = curNode.right;
          continue;
        }

        stack.Push(curNode);
        curNode = curNode.left;
      }

      return result;
    }
  }
}
