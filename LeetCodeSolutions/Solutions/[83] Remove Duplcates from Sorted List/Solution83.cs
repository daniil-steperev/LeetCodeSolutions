namespace LeetCodeSolutions.Solutions.Util
{
  public class Solution83
  {
    public ListNode DeleteDuplicates(ListNode head)
    {
      if (head == null)
      {
        return null;
      }

      if (head.next == null)
      {
        return head;
      }

      ListNode prevElement = head;
      ListNode curElement = head.next;
      while (curElement != null)
      {
        if (curElement.val == prevElement.val)
        {
          curElement = curElement.next;
          prevElement.next = curElement;
          continue;
        }

        prevElement = curElement;
        curElement = curElement.next;
      }

      return head;
    }
  }
}
