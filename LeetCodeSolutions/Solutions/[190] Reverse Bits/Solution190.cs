using System;

namespace LeetCodeSolutions.Solutions.ReverseBits
{
  public class Solution190
  {
    private const int BitStringLength = 31;

    public uint ReverseBits(uint n)
    {
      uint res = 0;
      var curDeg = 0;
      while (curDeg <= BitStringLength)
      {
        res += (n & 1) << (BitStringLength - curDeg++);
        n >>= 1;
      }

      return res;
    }
  }
}
