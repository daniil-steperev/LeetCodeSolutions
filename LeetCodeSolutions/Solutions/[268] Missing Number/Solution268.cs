using System.Linq;

namespace LeetCodeSolutions.Solutions.MissingNumber
{
  public class Solution268
  {
    public int MissingNumber(int[] nums)
    {
      var numsLen = nums.Length + 1;
      return (numsLen * (numsLen - 1) / 2) - nums.Sum();
    }
  }
}
