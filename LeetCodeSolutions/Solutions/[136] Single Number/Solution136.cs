namespace LeetCodeSolutions.Solutions.SingleNumber
{
  public class Solution136
  {
    public int SingleNumber(int[] nums)
    {
      int numberAccumulator = nums[0];

      for (int i = 1; i < nums.Length; i++)
      {
        numberAccumulator ^= nums[i];
      }

      return numberAccumulator;
    }
  }
}
