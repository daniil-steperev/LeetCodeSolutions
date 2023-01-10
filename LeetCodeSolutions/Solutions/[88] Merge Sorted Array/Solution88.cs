namespace LeetCodeSolutions.Solutions.MergeSortedArray
{
  public class Solution88
  {
    public void Merge(ref int[] nums1, int m, int[] nums2, int n)
    {
      int lIndex = m - 1;
      int rIndex = n - 1;
      int curSortedIndex = m + n - 1;
      while (lIndex >= 0 && rIndex >= 0)
      {
        if (nums1[lIndex] > nums2[rIndex])
        {
          nums1[curSortedIndex--] = nums1[lIndex--];
        }
        else
        {
          nums1[curSortedIndex--] = nums2[rIndex--];
        }
      }

      while(rIndex >= 0)
      {
        nums1[curSortedIndex--] = nums2[rIndex--];
      }
    }
  }
}
