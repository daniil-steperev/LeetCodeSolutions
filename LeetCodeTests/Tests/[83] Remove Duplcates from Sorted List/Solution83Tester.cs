using LeetCodeSolutions.Solutions.RemoveDuplcatesFromSortedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests.Tests.RemoveDuplcatesFromSortedList
{

  [TestClass]
  public class Solution83Tester : AbstractSolutionTester<Solution83>
  {
    [TestMethod]
    public void NullHeadTest()
    {
      ListNode nullHead = null;

      ListNode methodHead = solution.DeleteDuplicates(nullHead);

      Assert.IsNull(methodHead);
    }


    [TestMethod]
    public void ThreeElementsTest()
    {
      ListNode testHead = new ListNode()
      {
        val = 1,
        next = new ListNode()
        {
          val = 1,
          next = new ListNode()
          {
            val = 2,
          }
        }
      };

      ListNode correctOutput = new ListNode()
      {
        val = 1,
        next = new ListNode()
        {
          val = 2,
        }
      };

      ListNode methodHead = solution.DeleteDuplicates(testHead);

      while(correctOutput != null)
      {
        Assert.AreEqual(correctOutput.val, methodHead.val);

        correctOutput = correctOutput.next;
        methodHead = methodHead.next;
      }
    }

    [TestMethod]
    public void FiveElementsTest()
    {
      ListNode testHead = new ListNode()
      {
        val = 1,
        next = new ListNode()
        {
          val = 1,
          next = new ListNode()
          {
            val = 2,
            next = new ListNode()
            {
              val = 3,
              next = new ListNode()
              {
                val = 3,
              }
            }
          }
        }
      };

      ListNode correctOutput = new ListNode()
      {
        val = 1,
        next = new ListNode()
        {
          val = 2,
          next = new ListNode()
          {
            val = 3,
          }
        }
      };

      ListNode methodHead = solution.DeleteDuplicates(testHead);

      while (correctOutput != null)
      {
        Assert.AreEqual(correctOutput.val, methodHead.val);

        correctOutput = correctOutput.next;
        methodHead = methodHead.next;
      }
    }
  }
}
