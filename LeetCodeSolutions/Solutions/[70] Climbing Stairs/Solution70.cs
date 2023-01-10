namespace LeetCodeSolutions.Solutions.ClimbingStairs
{
  public class Solution70
  {
    public int ClimbStairs(int n)
    {
      if (n <= 2)
      {
        return n;
      }

      int fstPref = 1;
      int sndPref = 2;
      int cur = 0;
      for (int i = 3; i <= n; i++)
      {
        cur = fstPref + sndPref;
        fstPref = sndPref;
        sndPref = cur;
      }

      return cur;
    }
  }
}
