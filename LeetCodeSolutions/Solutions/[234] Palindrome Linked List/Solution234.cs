using LeetCodeSolutions.Solutions.RemoveDuplcatesFromSortedList;

namespace LeetCodeSolutions.Solutions._234__Palindrome_Linked_List
{
  public class Solution234
  {
    public bool IsPalindrome(ListNode head)
    {
      ListNode slowNode = head, fastNode = head, prevNode, tmpNode;

      // After cycle slowNode will be a pointer to the middle node of the list.
      while (fastNode != null && fastNode.next != null)
      {
        slowNode = slowNode.next;
        fastNode = fastNode.next.next;
      }

      // Reverse second list half order.
      prevNode = slowNode;
      slowNode = slowNode.next;
      prevNode.next = null;
      while (slowNode != null)
      {
        tmpNode = slowNode.next;
        slowNode.next = prevNode;
        prevNode = slowNode;
        slowNode= tmpNode;
      }

      // Check list using two pointers.
      slowNode = prevNode;
      prevNode = head;
      while (slowNode != null)
      {
        if (prevNode.val != slowNode.val)
        {
          return false;
        }

        slowNode = slowNode.next;
        prevNode = prevNode.next;
      }

      return true;
    }
  }
}
