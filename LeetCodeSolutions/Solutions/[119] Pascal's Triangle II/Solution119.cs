using System.Collections.Generic;

namespace LeetCodeSolutions.Solutions.PascalsTriangle
{
  public class Solution119
  {
    public IList<int> GetRow(int rowIndex)
    {
      if (rowIndex == 0)
      {
        return new List<int>() { 1, };
      }

      if (rowIndex == 1)
      {
        return new List<int>() { 1, 1, };
      }

      int tmp, prevVal;
      List<int> generatedRow = new List<int>() { 1, 1, };
      for (int rowNumber = 2; rowNumber <= rowIndex; rowNumber++)
      {
        tmp = 1;
        for (int i = 1; i < rowNumber; i++)
        {
          prevVal = generatedRow[i];
          generatedRow[i] += tmp;
          tmp = prevVal;
        }

        generatedRow.Add(1);
      }

      return generatedRow;
    }
  }
}
