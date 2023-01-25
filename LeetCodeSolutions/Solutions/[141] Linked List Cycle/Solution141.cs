using LeetCodeSolutions.Solutions.Util;

namespace LeetCodeSolutions.Solutions.LinkedListCycle
{
  public class Solution141
  {
    private const int CheckedValue = -1000000;

    public bool HasCycle(ListNode head)
    {
      while (head != null)
      {
        if (head.val == CheckedValue)
        {
          return true;
        }

        head.val = CheckedValue;
        head = head.next;
      }

      return false;
    }
  }
}
