using LeetCodeSolutions.Solutions.Util;

namespace LeetCodeSolutions.Solutions.ReverseLinkedList
{
  public class Solution206
  {
    public ListNode ReverseList(ListNode head)
    {
      ListNode prevNode = null;
      ListNode currNode = head;
      while (currNode != null)
      {
        ListNode nextNode = currNode.next;
        currNode.next = prevNode;
        prevNode = currNode;
        currNode = nextNode;
      }

      return prevNode;
    }
  }
}
