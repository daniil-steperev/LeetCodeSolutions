namespace LeetCodeSolutions.Solutions._283__Move_Zeroes
{
  public class Solution283
  {
    public void MoveZeroes(ref int[] nums)
    {
      int snowBallSize = 0;

      for (int i = 0; i < nums.Length; i++)
      {
        if (nums[i] == 0)
        {
          snowBallSize++;
          continue;
        }

        if (snowBallSize > 0)
        {
          nums[i - snowBallSize] = nums[i];
          nums[i] = 0;
        }
      }
    }
  }
}
