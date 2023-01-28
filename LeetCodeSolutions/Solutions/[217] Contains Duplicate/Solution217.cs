using System;

namespace LeetCodeSolutions.Solutions.ContainsDuplicate
{
  public class Solution217
  {

    // Time complexity: O(nlogn)
    // Space complexity: O(1)
    public bool ContainsDuplicate(int[] nums)
    {
      Array.Sort(nums);
      for (int i = 1; i < nums.Length; i++)
      {
        if (nums[i] == nums[i - 1])
        {
          return true;
        }
      }

      return false;
    }
  }
}
