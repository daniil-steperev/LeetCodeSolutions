using LeetCodeSolutions.Solutions.ReverseLinkedList;
using LeetCodeSolutions.Solutions.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Tests.ReverseLinkedList
{
  [TestClass]
  public class Solution206Tester : AbstractSolutionTester<Solution206>
  {
    [TestMethod]
    public void BigListTest()
    {
      ListNode testListHead = 
        new ListNode(1, 
          new ListNode(2, 
            new ListNode(3, 
              new ListNode(4, 
                new ListNode(5)))));

      ListNode reveresedListHead =
        new ListNode(5,
          new ListNode(4,
            new ListNode(3,
              new ListNode(2,
                new ListNode(1)))));

      ListNode methodReversedHead = solution.ReverseList(testListHead);

      Assert.IsTrue(AreLinkedListEqual(reveresedListHead, methodReversedHead));
    }

    [TestMethod]
    public void SmallListTest()
    {
      ListNode testListHead =
        new ListNode(1,
          new ListNode(2));

      ListNode reveresedListHead =
        new ListNode(2,
          new ListNode(1));

      ListNode methodReversedHead = solution.ReverseList(testListHead);

      Assert.IsTrue(AreLinkedListEqual(reveresedListHead, methodReversedHead));
    }

    [TestMethod]
    public void EmptyListTest()
    {
      ListNode testListHead = null;

      ListNode methodReversedHead = solution.ReverseList(testListHead);

      Assert.IsNull(methodReversedHead);
    }

    private bool AreLinkedListEqual(ListNode fstHead, ListNode sndHead)
    {
      while (fstHead != null)
      {
        if (sndHead == null)
        {
          return false;
        }

        if (fstHead.val != sndHead.val)
        {
          return false;
        }

        fstHead = fstHead.next;
        sndHead = sndHead.next;
      }

      return sndHead == null;
    }
  }
}
