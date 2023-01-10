using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutions.Solutions.PascalsTriangle
{
  public class Solution118
  {
    public IList<IList<int>> Generate(int numRows)
    {
      IList<IList<int>> generatedPascalTriangle = InitializePascalTriangle(numRows);
      for (int rowNumber = 2; rowNumber < numRows; rowNumber++)
      {
        for (int i = 1; i < rowNumber; i++)
        {
          generatedPascalTriangle[rowNumber][i] = generatedPascalTriangle[rowNumber - 1][i - 1] + generatedPascalTriangle[rowNumber - 1][i];
        }
      }

      return generatedPascalTriangle;
    }

    private IList<IList<int>> InitializePascalTriangle(int numRows)
    {
      IList<IList<int>> emptyPascalTriangle = new List<IList<int>>()
      {
        new List<int>() { 1, },
      };

      for (int rowNumber = 1; rowNumber < numRows; rowNumber++)
      {
        List<int> row = new List<int>() { 1, };
        row.AddRange(Enumerable.Repeat(0, rowNumber - 1));
        row.Add(1);

        emptyPascalTriangle.Add(row);
      }

      return emptyPascalTriangle;
    }
  }
}
