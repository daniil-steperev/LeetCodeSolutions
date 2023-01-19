using LeetCodeSolutions.Solutions.LinkedListCycle;
using LeetCodeSolutions.Solutions.RemoveDuplcatesFromSortedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Tests._141__Linked_List_Cycle
{
  [TestClass]
  public class Solution141Tester : AbstractSolutionTester<Solution141>
  {
    [TestMethod]
    public void BigCycleTest()
    {
      bool hasCycle = true;
      ListNode head = new ListNode()
      {
        val = 3,
      };

      head.next = new ListNode()
      {
        val = 2,
        next = new ListNode()
        {
          val = 0,
          next = new ListNode()
          {
            val = -4,
            next = head,
          }
        }
      };

      bool methodOutput = solution.HasCycle(head);

      Assert.AreEqual(hasCycle, methodOutput);
    }

    [TestMethod]
    public void SmallCycleTest()
    {
      bool hasCycle = true;
      ListNode head = new ListNode()
      {
        val = 1,
      };

      head.next = new ListNode()
      {
        val = 2,
        next = head,
      };

      bool methodOutput = solution.HasCycle(head);

      Assert.AreEqual(hasCycle, methodOutput);
    }

    [TestMethod]
    public void NoCycleTest()
    {
      bool hasCycle = false;
      ListNode head = new ListNode()
      {
        val = 1,
      };

      bool methodOutput = solution.HasCycle(head);

      Assert.AreEqual(hasCycle, methodOutput);
    }
  }
}
