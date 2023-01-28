namespace LeetCodeSolutions.Solutions.PowerOfThree
{
  public class Solution326
  {
    public bool IsPowerOfThree(int n)
    {
      // In constraints: (-2)^31 <= n <= 2^31.
      // 2^31 >= n = 3^x.
      // Then log3(2^31) >= x => 19 >= x.
      // Then we can use mod for 3^19 = 1162261467.
      return n > 0 && 1162261467 % n == 0;
    }
  }
}
