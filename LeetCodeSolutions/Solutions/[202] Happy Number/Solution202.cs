using System;

namespace LeetCodeSolutions.Solutions.HappyNumber
{
  public class Solution202
  {
    public bool IsHappy(int n)
    {
      while (n != 1)
      {
        n = FindDoubleVal(n);
        if (n == 4)
        {
          return false;
        }
      }

      return true;
    }

    private int FindDoubleVal(int n)
    {
      var res = 0;
      while (n > 0)
      {
        res += (int)Math.Pow(n % 10, 2);
        n /= 10;
      }

      return res;
    }
  }
}
