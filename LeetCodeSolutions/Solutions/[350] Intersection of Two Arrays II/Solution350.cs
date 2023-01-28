using System.Collections.Generic;

namespace LeetCodeSolutions.Solutions.IntersectionOfTwoArraysII
{
  public class Solution350
  {
    // N = nums1.Length, M = nums2.Length.
    // Time complexity: O(N + M).
    // Space complexity = O(min(N, M)).
    public int[] Intersect(int[] nums1, int[] nums2)
    {
      // Consider Nums1 length is less than Nums2 length.
      if (nums1.Length > nums2.Length)
      {
        return Intersect(nums2, nums1);
      }

      Dictionary<int, int> hashSet = new Dictionary<int, int>();
      foreach (var number in nums1)
      {
        if (hashSet.ContainsKey(number))
        {
          hashSet[number]++;
        }
        else
        {
          hashSet.Add(number, 1);
        }
      }

      List<int> resultList = new List<int>();
      foreach (var number in nums2)
      {
        if (hashSet.ContainsKey(number))
        {
          resultList.Add(number);
          hashSet[number]--;

          if (hashSet[number] == 0)
          {
            hashSet.Remove(number);
          }
        }
      }

      return resultList.ToArray();
    }
  }
}
