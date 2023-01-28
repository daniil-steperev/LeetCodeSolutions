namespace LeetCodeSolutions.Solutions.SqrtX
{
  public class Solution69
  {
    public int MySqrt(int x)
    {
      if (x == 0)
      {
        return 0;
      }

      int lowVal = 1, highVal = x, midVal, tmpVal, answer = 0;
      while (lowVal <= highVal)
      {
        midVal = lowVal + (highVal - lowVal) / 2;
        tmpVal = x / midVal;
        if (tmpVal == midVal)
        {
          return midVal;
        }

        if (tmpVal < midVal)
        {
          highVal = midVal - 1;
        }
        else
        {
          lowVal = midVal + 1;
          answer = midVal;
        }
      }

      return answer;
    }
  }
}
