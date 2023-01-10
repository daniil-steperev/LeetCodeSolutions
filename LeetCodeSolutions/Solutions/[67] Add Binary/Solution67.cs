using System.Text;

namespace LeetCodeSolutions.AddBinary
{
  public class Solution67
  {
    private const int OverflowingElement = 2;

    public string AddBinary(string a, string b)
    {
      int extraElement = 0;
      int aStrPointer = a.Length - 1;
      int bStrPointer = b.Length - 1;

      StringBuilder result = new StringBuilder();
      while (aStrPointer != -1 || bStrPointer != -1)
      {
        int resCharVal;
        if (aStrPointer == -1)
        {
          resCharVal = GetIntValue(b[bStrPointer--]) + extraElement;
        }
        else if (bStrPointer == -1)
        {
          resCharVal = GetIntValue(a[aStrPointer--]) + extraElement;
        }
        else
        {
          resCharVal = GetIntValue(a[aStrPointer--]) + GetIntValue(b[bStrPointer--]) + extraElement;
        }

        extraElement = CountExtraElement(resCharVal);
        result.Insert(0, resCharVal % 2);
      }

      if (extraElement == 1)
      {
        result.Insert(0, 1);
      }

      return result.ToString();
    }

    private int CountExtraElement(int elem)
    {
      return elem >= OverflowingElement ? 1 : 0;
    }

    private int GetIntValue(char elem)
    {
      return elem - '0';
    }
  }
}
