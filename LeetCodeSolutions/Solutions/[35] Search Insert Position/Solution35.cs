namespace LeetCodeSolutions.SearchInsertPosition
{
  public class Solution35
  {
    public int SearchInsert(int[] nums, int target)
    {
      int leftIndex = 0;
      int rightIndex = nums.Length;
      int midIndex = -1;
      while (rightIndex - leftIndex > 1)
      {
        midIndex = (leftIndex + rightIndex) / 2;
        if (nums[midIndex] == target)
        {
          return midIndex;
        }

        if (nums[midIndex] > target)
        {
          rightIndex = midIndex;
        }
        else
        {
          leftIndex = midIndex;
        }
      }

      return nums[leftIndex] >= target ? leftIndex : rightIndex;
    }
  }
}
