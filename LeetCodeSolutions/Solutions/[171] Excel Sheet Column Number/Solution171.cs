namespace LeetCodeSolutions.Solutions.ExcelSheetColumnNumber
{
  public class Solution171
  {
    public int TitleToNumber(string columnTitle)
    {
      var result = 0;
      var charTitle = columnTitle.ToCharArray();
      foreach (var letter in charTitle)
      {
        int tmp = letter - 'A' + 1;
        result = result * 26 + tmp;
      }

      return result;
    }
  }
}
