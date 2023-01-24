using LeetCodeSolutions.Solutions._234__Palindrome_Linked_List;
using LeetCodeSolutions.Solutions.RemoveDuplcatesFromSortedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Tests._234__Palindrome_Linked_List
{
  [TestClass]
  public class Solution234Tester : AbstractSolutionTester<Solution234>
  {
    [TestMethod]
    public void PalindromeTest()
    {
      ListNode head = new ListNode()
      {
        val = 1,
        next = new ListNode()
        {
          val = 2,
          next = new ListNode()
          {
            val = 2,
            next = new ListNode()
            {
              val = 1,
            }
          }
        }
      };

      bool isMethodPalindrome = solution.IsPalindrome(head);

      Assert.IsTrue(isMethodPalindrome);
    }

    [TestMethod]
    public void NotPalindromeTest()
    {
      ListNode head = new ListNode()
      {
        val = 1,
        next = new ListNode()
        {
          val = 2,
        }
      };

      bool isMethodPalindrome = solution.IsPalindrome(head);

      Assert.IsFalse(isMethodPalindrome);
    }
  }
}
